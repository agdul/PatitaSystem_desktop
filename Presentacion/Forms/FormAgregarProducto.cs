// Archivo: Presentacion/Forms/FormAgregarProducto.cs
using MaterialSkin;
using MaterialSkin.Controls;
using PatitaSystem.Dominio.Linea;
using PatitaSystem.Dominio.Presentacion;
using PatitaSystem.Dominio.Producto;
using PatitaSystem.Infraestructura.Http;
using PatitaSystem.Presentacion.Commons;
using PatitaSystem.Presentacion.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatitaSystem.Presentacion.Forms
{
    /// <summary>
    /// Alta de Producto y (a futuro) Presentación.
    /// - Carga CBX_Linea desde /linea/ (que ya incluye categorías).
    /// - Al cambiar la línea, carga CBX_Categoria con las categorías anidadas.
    /// - Crea producto vía /producto/.
    /// </summary>
    public partial class FormAgregarProducto : MaterialForm
    {
        
        private readonly LineaApiClient? _lineaApi;
        private readonly ProductoApiClient? _productoApi;
        private readonly PresentacionApiClient? _presentacionApi;
        private readonly CancellationTokenSource _cts = new();

        private List<LineaResponse> _lineas = new(); // cache local para filtrar categorías

        // Para que el padre pueda inspeccionar el creado si quiere
        public ProductoResponse? ProductoCreado { get; private set; }



        // Diseñador
        public FormAgregarProducto()
        {
            InitializeComponent();
            InicializarAutocompleteProducto();
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Teal700, Primary.Teal900, Primary.Teal500,
                Accent.Green200, TextShade.WHITE
            );

            BTN_AgregarProducto.Click += BTN_AgregarProducto_Click;
            BTN_AgregarPresentacion.Click += BTN_AgregarPresentacion_Click;

            // cuando cambia la línea, refrescamos categorías
            CBX_Linea.SelectedIndexChanged += (_, __) => RefrescarCategoriasSegunLinea();

            this.Load += async (_, __) => await CargarLineasYCategoriasAsync();
        }

        // Runtime
        public FormAgregarProducto(ProductoApiClient productoApi, LineaApiClient lineaApi, PresentacionApiClient presentacionApiClient) : this()
        {
            _productoApi = productoApi ?? throw new ArgumentNullException(nameof(productoApi));
            _lineaApi = lineaApi ?? throw new ArgumentNullException(nameof(lineaApi));
            _presentacionApi = presentacionApiClient ?? throw new ArgumentNullException(nameof(presentacionApiClient));

            InicializarAutocompleteProducto();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _cts.Cancel();
            _cts.Dispose();
            base.OnFormClosing(e);
        }

        // -----------------------------
        // Carga de combos
        // -----------------------------
        private async Task CargarLineasYCategoriasAsync()
        {
            await UiHelpers.RunSafeAsync(
                this,
                new Control[] { BTN_AgregarProducto, BTN_AgregarPresentacion, CBX_Linea, CBX_Categoria },
                async () =>
                {
                    if (_lineaApi is null)
                        throw new InvalidOperationException("LineaApiClient no fue inyectado.");

                    _lineas = new List<LineaResponse>(await _lineaApi.ListarAsync(_cts.Token).ConfigureAwait(true));

                    // Llenar CBX_Linea
                    CBX_Linea.DisplayMember = nameof(LineaResponse.NombreLinea);
                    CBX_Linea.ValueMember = nameof(LineaResponse.IdLinea);
                    CBX_Linea.DataSource = _lineas;

                    // Llenar CBX_Categoria según la línea seleccionada
                    RefrescarCategoriasSegunLinea();
                }
            );
        }

        private void RefrescarCategoriasSegunLinea()
        {
            // línea seleccionada
            var lineaSeleccionada = CBX_Linea.SelectedItem as LineaResponse;

            var categorias = lineaSeleccionada?.Categorias ?? new List<LineaResponse.CategoriaXLineaResponce>();

            // Si querés, agregamos un "placeholder" arriba:
            // categorias = new [] { new LineaResponce.CategoriaXLineaResponce { IdCategoria = 0, NombreCategoria = "— Seleccione —" } }
            //                 .Concat(categorias).ToList();

            CBX_Categoria.DisplayMember = nameof(LineaResponse.CategoriaXLineaResponce.NombreCategoria);
            CBX_Categoria.ValueMember = nameof(LineaResponse.CategoriaXLineaResponce.IdCategoria);
            CBX_Categoria.DataSource = categorias;

            if (CBX_Categoria.Items.Count > 0)
                CBX_Categoria.SelectedIndex = 0;
        }

        // -----------------------------
        // Botones
        // -----------------------------
        private async void BTN_AgregarProducto_Click(object? sender, EventArgs e)
        {
            await UiHelpers.RunSafeAsync(
                this,
                new Control[] { BTN_AgregarProducto, BTN_AgregarPresentacion },
                async () =>
                {
                    var req = ConstruirRequestDesdeUI();
                    ValidarRequest(req);

                    if (_productoApi is null)
                        throw new InvalidOperationException("ProductoApiClient no fue inyectado.");

                    var creado = await _productoApi.CrearAsync(req, _cts.Token).ConfigureAwait(true);
                    if (creado is null)
                        throw new Exception("La API no devolvió datos del producto creado.");

                    ProductoCreado = creado;
                    this.DialogResult = DialogResult.OK;  // <<--- CLAVE
                    this.Close();                         // <<--- CLAVE

                }
            );
        }

        private async void BTN_AgregarPresentacion_Click(object? sender, EventArgs e)
        {
            await UiHelpers.RunSafeAsync(
                this,
                new Control[] { BTN_AgregarProducto, BTN_AgregarPresentacion },
                async () =>
                {
                    // 1) Verificar selección de producto (autocomplete)
                    ValidarProductoSeleccionado();
                    var idProducto = ObtenerProductoSeleccionadoId()!.Value;

                    // 2) Construir request (el id va en la URL, no es necesario en el body)
                    var req = new PresentacionRequest
                    {
                        NombrePresentacion = TXTB_NombrePresentacion.Text?.Trim() ?? string.Empty,
                        Descripcion = TXT_Descripcion.Text?.Trim() ?? string.Empty,
                        Stock = int.TryParse(TXT_Stock.Text?.Trim(), out var stock) ? stock : 0,
                        PrecioCompra = decimal.TryParse(TXT_PrecioDeCompra.Text?.Trim(), out var precio) ? precio : 0m,
                        PorcentajeAumento = decimal.TryParse(TXTB_PorcentajeAumento.Text?.Trim(), out var porcentaje) ? porcentaje : 0m
                    };

                    // 3) Validaciones de negocio rápidas
                    ValidarPresentacionRequest(req);

                    // 4) Cliente inyectado
                    if (_presentacionApi is null)
                        throw new InvalidOperationException("PresentacionApiClient no fue inyectado.");

                    // 5) Llamada a la API: POST /producto/{idProducto}/presentacion
                    var creado = await _presentacionApi
                        .CrearAsync(idProducto, req, _cts.Token)
                        .ConfigureAwait(true);

                    // 6) Feedback + limpieza
                    MessageBox.Show(this,
                        $"Presentación creada OK.\nProducto ID: {idProducto}\nNombre: {creado?.NombrePresentacion ?? req.NombrePresentacion}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormularioPresentacion();

                    // (Opcional) Si tenés una grilla/lista de presentaciones, refrescala:
                    // var items = await _presentacionApi.ListarPorProductoAsync(idProducto, _cts.Token).ConfigureAwait(true);
                    // BindPresentaciones(items);
                }
            );
        }


        // -----------------------------
        // Mapeo y validaciones
        // -----------------------------
        private ProductoRequest ConstruirRequestDesdeUI()
        {
            var nombre = TXTB_NombreProducto.Text?.Trim() ?? string.Empty;

            var idLinea = CBX_Linea.SelectedValue is int li ? li :
                          (CBX_Linea.SelectedItem as LineaResponse)?.IdLinea ?? 0;

            var idCategoria = CBX_Categoria.SelectedValue is int ca ? ca :
                (CBX_Categoria.SelectedItem as LineaResponse.CategoriaXLineaResponce)?.IdCategoria ?? 0;

            return new ProductoRequest
            {
                NombreProducto = nombre,
                IdLinea = idLinea,
                IdCategoria = idCategoria
            };
        }

        private void ValidarRequest(ProductoRequest req)
        {
            if (string.IsNullOrWhiteSpace(req.NombreProducto))
                throw new ArgumentException("El nombre de producto es obligatorio.");
            if (req.IdLinea <= 0)
                throw new ArgumentException("Debe seleccionar una línea válida.");
            if (req.IdCategoria <= 0)
                throw new ArgumentException("Debe seleccionar una categoría válida.");
        }

        private void LimpiarFormulario()
        {
            TXTB_NombreProducto.Text = string.Empty;
            if (CBX_Linea.Items.Count > 0) CBX_Linea.SelectedIndex = 0;
            RefrescarCategoriasSegunLinea();

            // Campos de Presentación (por si después los usás)
            TXTB_NombrePresentacion.Text = string.Empty;
            TXT_Descripcion.Text = string.Empty;
            TXT_Stock.Text = string.Empty;
            TXT_PrecioDeCompra.Text = string.Empty;
            TXTB_PorcentajeAumento.Text = string.Empty;
        }

        private static void ValidarPresentacionRequest(PresentacionRequest req)
        {
            if (string.IsNullOrWhiteSpace(req.NombrePresentacion))
                throw new InvalidOperationException("El nombre de la presentación es obligatorio.");

            if (req.PrecioCompra < 0)
                throw new InvalidOperationException("El precio de compra no puede ser negativo.");

            if (req.PorcentajeAumento < 0)
                throw new InvalidOperationException("El porcentaje de aumento no puede ser negativo.");
        }

        private void LimpiarFormularioPresentacion()
        {
            TXTB_NombrePresentacion.Text = string.Empty;
            TXT_Descripcion.Text = string.Empty;
            TXT_Stock.Text = string.Empty;
            TXT_PrecioDeCompra.Text = string.Empty;
            TXTB_PorcentajeAumento.Text = string.Empty;
        }


    }
}
