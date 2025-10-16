// Archivo: Presentacion/Forms/FormAdministrador.cs
using static PatitaSystem.Program;  // para acceder a Program.Services si lo tenés como global
using Microsoft.Extensions.DependencyInjection;
using MaterialSkin;
using MaterialSkin.Controls;
using PatitaSystem.Dominio.Usuarios;           // DTO
using PatitaSystem.Infraestructura.Http;       // AuthHeader + UsuarioApiClient
using PatitaSystem.Infraestructura.Seguridad;  // TokenStore
using PatitaSystem.Presentacion.Forms;
using System.Net;
using System.Net.Http;                         // HttpClient
using System.Net.Http.Headers;
using PatitaSystem.Dominio.Producto;


namespace PatitaSystem.Presentacion.Forms
{
    /// <summary>
    /// FormAdministrador con Drawer + Tabs.
    /// - Mantiene tu cliente de API y la carga de listas.
    /// - Expone ModoSoloProductos para mostrar únicamente la pestaña Productos cuando se abre desde Dashboard → Productos.
    /// </summary>
    public partial class FormAdministrador : MaterialForm
    {
        // =========================
        //  NUEVO: control de tabs
        // =========================
        private List<TabPage> _todasLasTabs = new();
        private TabPage? _tabProductos;
        private bool _snapshotTomado = false;

        // Host lateral para el drawer (evita que pinte debajo del app-bar del MaterialForm)
        private Panel? _drawerHost;
        private int _drawerWidthBackup = 0;

        // === BUSCADOR: estado y debounce ===
        private System.Windows.Forms.Timer? _buscadorTmr;
        private List<UsuarioListadoDto> _usuariosCache = new(); // ajustá el tipo exacto si difiere
        private List<ProductoResponse> _productosCache = new();


        /// <summary>
        /// Si true, el formulario opera mostrando solo la pestaña de Productos.
        /// Puede cambiarse en runtime; luego llamar a <see cref="AplicarRestriccionSoloProductos"/>.
        /// </summary>
        public bool ModoSoloProductos { get; set; }

        // =========================
        //  API Usuarios (ya tenías)
        // =========================
        private readonly UsuarioApiClient _usuarioApi;
        private readonly DireccionApiClient _direccionApi;
        private readonly IServiceProvider _serviceProvider;

        // Una sola instancia para el modal de registro
        private FormRegistrarUsuario? _frmRegistrarUsuario;

        public FormAdministrador(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            TomarSnapshotDeTabsInicial();
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));


            // -----------------------------
            // MaterialSkin (tu configuración)
            // -----------------------------
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Teal700, Primary.Teal900, Primary.Teal500,
                Accent.Green200, TextShade.WHITE
            );

            // Vincular Drawer con el TabControl (tu control se llama TABS_MenuAdmin)
            //drawerMenu.BaseTabControl = TABS_MenuAdmin;

            // ---------------------------------------------------
            // HttpClient con token (AuthHeader + TokenStore local)
            // ---------------------------------------------------
            var tokenStore = new TokenStore(); // lee token desde %LOCALAPPDATA%\PatitaSystem\auth.token
            var authHandler = new AuthHeader(tokenStore)
            {
                InnerHandler = new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    UseCookies = false
                }
            };

            var http = new HttpClient(authHandler, disposeHandler: true)
            {
                BaseAddress = new System.Uri("http://localhost:3001/api/v1/"),
                Timeout = System.TimeSpan.FromSeconds(40)
            };
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            http.DefaultRequestHeaders.UserAgent.ParseAdd("PatitaSystem-Desktop");

            _usuarioApi = new UsuarioApiClient(http);
            _direccionApi = new DireccionApiClient(http);
            

            // -----------------------------------------
            // Config columnas + carga real al mostrar UI
            // -----------------------------------------
            ConfigurarListaUsuarios();
            ConfigurarListaTurnos();
            ConfigurarListaProductos();

            this.Load -= FormAdministrador_LoadAsync;
            this.Load += FormAdministrador_LoadAsync;


            // Buscador: timer para debounce (para no filtrar en cada tecla)
            _buscadorTmr = new System.Windows.Forms.Timer { Interval = 150 };
            _buscadorTmr.Tick += (_, __) =>
            {
                _buscadorTmr!.Stop();
                AplicarFiltroUsuarios(TXT_BuscarUsuario?.Text ?? string.Empty);
            };

            // Handlers de UI
            if (TXT_BuscarUsuario != null)
            {
                TXT_BuscarUsuario.TextChanged -= TXT_BuscarUsuario_TextChanged;
                TXT_BuscarUsuario.TextChanged += TXT_BuscarUsuario_TextChanged;
            }
            if (BTN_LimpiarBusqueda != null)
            {
                BTN_LimpiarBusqueda.Click -= BTN_LimpiarBusqueda_Click;
                BTN_LimpiarBusqueda.Click += BTN_LimpiarBusqueda_Click;
            }
        }

        /// <summary>
        /// Toma una única vez el snapshot de tabs tal como vienen del Designer.
        /// Detecta además la Tab de Productos por Name o por Text.
        /// </summary>
        private void TomarSnapshotDeTabsInicial()
        {
            if (_snapshotTomado) return;
            if (TABS_MenuAdmin is null) return;

            // Snapshot del orden original
            _todasLasTabs = TABS_MenuAdmin.TabPages.Cast<TabPage>().ToList();

            // Detectar Productos por Name o por Text
            _tabProductos = DetectarTabProductos();

            _snapshotTomado = true;
        }

        /// <summary>
        /// Devuelve la Tab de Productos buscando por Name (tolerante) o por el Text visible.
        /// </summary>
        private TabPage? DetectarTabProductos()
        {
            if (TABS_MenuAdmin is null) return null;
            var pages = TABS_MenuAdmin.TabPages.Cast<TabPage>().ToList();

            // 1) Por Name
            string[] nombresProductos = { "TAB_Productos", "tabProductos", "tabProduct", "TAB_Product", "Productos", "productos" };
            var porName = pages.FirstOrDefault(tp =>
                nombresProductos.Any(n => string.Equals(tp.Name, n, System.StringComparison.OrdinalIgnoreCase)));
            if (porName != null) return porName;

            // 2) Por Text (lo que ve el usuario)
            string[] textosProductos = { "Productos", "Producto", "Shop", "PatitaShop" };
            var porText = pages.FirstOrDefault(tp =>
                textosProductos.Any(t => string.Equals(tp.Text?.Trim(), t, System.StringComparison.OrdinalIgnoreCase)));
            return porText;
        }



        /// <summary>
        /// Al mostrarse el formulario: indexa tabs, sincroniza el Drawer y aplica la restricción si corresponde.
        /// </summary>
        protected override void OnShown(System.EventArgs e)
        {
            base.OnShown(e);

            TomarSnapshotDeTabsInicial();

            if (ModoSoloProductos)
                AplicarRestriccionSoloProductos();
            else
                RestaurarTodasLasTabs();

            // Aquí se vuelve a acoplar y **se muestra** el Drawer
            SincronizarDrawerConTabs();
            _ = CargarProductosDesdeApiAsync();
        }




        // =========================
        //  USUARIOS (TAB 1)
        // =========================

        /// <summary>Define columnas del ListView de usuarios y limpia items previos.</summary>
        private void ConfigurarListaUsuarios()
        {
            if (LIS_Usuario.View != View.Details)
                LIS_Usuario.View = View.Details;

            LIS_Usuario.FullRowSelect = true;
            LIS_Usuario.GridLines = true;

            if (LIS_Usuario.Columns.Count == 0)
            {
                LIS_Usuario.Columns.Add("ID", 60);
                LIS_Usuario.Columns.Add("Nombre", 150);
                LIS_Usuario.Columns.Add("Apellido", 150);
                LIS_Usuario.Columns.Add("Usuario", 150);
                LIS_Usuario.Columns.Add("Email", 210);
                LIS_Usuario.Columns.Add("Celular", 170);
                LIS_Usuario.Columns.Add("Estado", 90);
            }

            LIS_Usuario.Items.Clear();
        }

        /// <summary>Carga usuarios desde la API y llena el ListView.</summary>
        private async void FormAdministrador_LoadAsync(object? sender, System.EventArgs e)
        {
            await CargarUsuariosDesdeApiAsync();
        }

        /// <summary>GET /usuario/ y pintado de filas.</summary>
        private async Task CargarUsuariosDesdeApiAsync()
        {
            try
            {
                using var cts = new CancellationTokenSource(System.TimeSpan.FromSeconds(20));
                var usuarios = await _usuarioApi.GetUsuariosAsync(cts.Token);

                // Cacheamos TODO el listado original
                _usuariosCache = usuarios.ToList();

                // Pintamos a partir de la cache (no hagas otro loop aparte)
                RenderUsuarios(_usuariosCache);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("La solicitud de usuarios expiró (timeout).",
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API de usuarios.\n\nDetalle: {ex.Message}",
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error inesperado al cargar usuarios:\n{ex}",
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------
        //  Apertura modal única
        // ---------------------------
        /// <summary>
        /// Abre FormRegistrarUsuario como modal única instancia, ocultando este formulario mientras tanto.
        /// Al cerrar, vuelve a mostrar y refresca la lista de usuarios.
        /// </summary>
        private async Task AbrirFormRegistrarUsuarioAsync(Usuario? usuarioParaEditar = null)
        {
            if (_frmRegistrarUsuario is { IsDisposed: false } && _frmRegistrarUsuario.Visible)
            {
                _frmRegistrarUsuario.BringToFront();
                _frmRegistrarUsuario.Focus();
                return;
            }

            if (BTN_CrearUsuario is not null) BTN_CrearUsuario.Enabled = false;

            try
            {
                _frmRegistrarUsuario = (usuarioParaEditar is null)
                    ? new FormRegistrarUsuario(_usuarioApi, _direccionApi)
                    : new FormRegistrarUsuario(_usuarioApi, _direccionApi, usuarioParaEditar);

                _frmRegistrarUsuario.FormClosed += (_, __) => _frmRegistrarUsuario = null;

                this.Hide();
                var result = _frmRegistrarUsuario.ShowDialog(this);

                // Refrescamos (independiente del resultado)
                await CargarUsuariosDesdeApiAsync();
            }
            finally
            {
                this.Show();
                this.Activate();
                if (BTN_CrearUsuario is not null) BTN_CrearUsuario.Enabled = true;

                _frmRegistrarUsuario?.Dispose();
                _frmRegistrarUsuario = null;
            }
        }

        // Botón CREAR → abre modal UNA sola instancia y oculta Admin
        private async void BTN_Crear_Click(object sender, System.EventArgs e)
        {
            await AbrirFormRegistrarUsuarioAsync();
        }

        // Botón MODIFICAR → abre modal con datos del seleccionado
        private async void BTN_Modificar_Click(object sender, System.EventArgs e)
        {
            if (LIS_Usuario.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para modificar.");
                return;
            }

            var item = LIS_Usuario.SelectedItems[0];
            var usuarioSeleccionado = new Usuario
            {
                Id = item.SubItems[0].Text,
                Nombre = item.SubItems[1].Text,
                Email = item.SubItems[2].Text,
                Telefono = item.SubItems.Count > 3 ? item.SubItems[3].Text : ""
            };

            await AbrirFormRegistrarUsuarioAsync(usuarioSeleccionado);
        }

        // Botón ELIMINAR (UI local; cuando tengas endpoint hacemos DELETE)
        private void BTN_Eliminar_Click(object sender, System.EventArgs e)
        {
            if (LIS_Usuario.SelectedItems.Count > 0)
            {
                var item = LIS_Usuario.SelectedItems[0];
                string usuario = item.SubItems[1].Text;

                var resultado = MessageBox.Show(
                    $"¿Desea borrar al usuario {usuario}?",
                    "Confirmar borrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        LIS_Usuario.Items.Remove(item);
                        MessageBox.Show("Usuario borrado en la lista local.", "Éxito");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Error al borrar usuario: " + ex.Message, "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para borrar.", "Atención");
            }
        }

        // Clase interna (para pasar al form de edición)
        public class Usuario
        {
            public string Id { get; set; } = "";
            public string Nombre { get; set; } = "";
            public string Email { get; set; } = "";
            public string Telefono { get; set; } = "";
        }

        // =========================
        //  TURNOS (TAB 2)
        // =========================
        private void ConfigurarListaTurnos()
        {
            if (LISTV_ListaTurnos.View != View.Details)
                LISTV_ListaTurnos.View = View.Details;

            LISTV_ListaTurnos.FullRowSelect = true;
            LISTV_ListaTurnos.GridLines = true;

            if (LISTV_ListaTurnos.Columns.Count == 0)
            {
                LISTV_ListaTurnos.Columns.Add("ID", 50);
                LISTV_ListaTurnos.Columns.Add("Usuario", 150);
                LISTV_ListaTurnos.Columns.Add("Email", 175);
                LISTV_ListaTurnos.Columns.Add("Telefono", 170);
                LISTV_ListaTurnos.Columns.Add("Turno", 170);
            }
        }

        // =========================
        //  PRODUCTOS (TAB 3)
        // =========================
        private void ConfigurarListaProductos()
        {
            if (LIST_Producto.View != View.Details)
                LIST_Producto.View = View.Details;

            LIST_Producto.FullRowSelect = true;
            LIST_Producto.GridLines = true;

            if (LIST_Producto.Columns.Count == 0)
            {
                LIST_Producto.Columns.Add("ID", 50);
                LIST_Producto.Columns.Add("Producto", 150);
                LIST_Producto.Columns.Add("Estado", 100);
            }
        }

        private void materialButton7_Click(object sender, System.EventArgs e)
        {
            if (LIST_Producto.SelectedItems.Count > 0)
            {
                var item = LIST_Producto.SelectedItems[0];
                string producto = item.SubItems[1].Text;

                var confirm = MessageBox.Show(
                    $"¿Estás seguro de eliminar {producto}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // TODO: DELETE real cuando tengas endpoint
                    LIST_Producto.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un producto primero.");
            }
        }

        private void materialButton9_Click(object sender, System.EventArgs e)
        {
            if (LIST_Producto.SelectedItems.Count > 0)
            {
                var frm = new FormEditarProducto(LIST_Producto);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccioná un producto primero.");
            }
        }

        // ============================================================
        // === NUEVO: Manejo de Tabs + Drawer (solo Productos / normal)
        // ============================================================

        /// <summary>
        /// Indexa las tabs actuales, guarda snapshot y localiza la pestaña de Productos por Name.
        /// </summary>
        private void InicializarTabsSegunDesigner()
        {
            if (TABS_MenuAdmin is null) return;

            _todasLasTabs = TABS_MenuAdmin.TabPages.Cast<TabPage>().ToList();

            // Ajustá estos nombres a los que tengas en el Designer
            string[] nombresProductos = { "TAB_Productos", "tabProductos", "tabProduct", "TAB_Product" };

            _tabProductos = _todasLasTabs.FirstOrDefault(tp =>
                nombresProductos.Any(n => string.Equals(tp.Name, n, System.StringComparison.OrdinalIgnoreCase)));
        }

        /// <summary>
        /// Enlaza el Drawer al TabControl y normaliza índices/estado.
        /// </summary>
        private void SincronizarDrawerConTabs()
        {
            if (drawerMenu is null || TABS_MenuAdmin is null) return;

            // Enlazar siempre al TabControl definitivo
            if (drawerMenu.BaseTabControl != TABS_MenuAdmin)
                drawerMenu.BaseTabControl = TABS_MenuAdmin;

            // Si no hay páginas, oculto el drawer y salgo
            if (TABS_MenuAdmin.TabPages.Count == 0)
            {
                TABS_MenuAdmin.SelectedIndex = -1;
                drawerMenu.IsOpen = false;
                drawerMenu.Visible = false;
                drawerMenu.Dock = DockStyle.None;
                drawerMenu.Invalidate();
                return;
            }

            // Asegurar selección válida del TabControl
            if (TABS_MenuAdmin.SelectedIndex < 0)
                TABS_MenuAdmin.SelectedIndex = 0;
            if (TABS_MenuAdmin.SelectedIndex >= TABS_MenuAdmin.TabPages.Count)
                TABS_MenuAdmin.SelectedIndex = TABS_MenuAdmin.TabPages.Count - 1;

            // **MOSTRAR** el Drawer: dockear a la izquierda, abrir y traer al frente
            drawerMenu.Visible = true;
            drawerMenu.Dock = DockStyle.Left;
            drawerMenu.IsOpen = true;
            drawerMenu.BringToFront();

            // Por si el TabControl quedó oculto (algunas transiciones)
            TABS_MenuAdmin.Visible = true;

            // Repintar
            drawerMenu.Invalidate();
            drawerMenu.Refresh();
        }


        /// <summary>
        /// Deja visible únicamente la pestaña de Productos.
        /// Si no se encuentra, por seguridad oculta todas.
        /// </summary>
        public void AplicarRestriccionSoloProductos()
        {
            if (TABS_MenuAdmin is null) return;

            // Desacoplar Drawer mientras manipulamos
            ComenzarActualizacionSeguraDelDrawer();

            // Si nunca tomamos snapshot o no hay tabs, no hacemos nada destructivo
            if (!_snapshotTomado || _todasLasTabs.Count == 0)
            {
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            // Re-detectar por si cambió el Name/Text
            _tabProductos ??= DetectarTabProductos();

            if (_tabProductos is null)
            {
                // No tocar nada y avisar (así no te dejo la pantalla en blanco)
                FinalizarActualizacionSeguraDelDrawer();
                MessageBox.Show(
                    "No se encontró la pestaña 'Productos'. Verificá el Name/Text de la Tab en el Designer.",
                    "Admin - Solo Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asegurar que Productos esté en el TabControl
            if (!TABS_MenuAdmin.TabPages.Contains(_tabProductos))
                TABS_MenuAdmin.TabPages.Add(_tabProductos);

            // Seleccionar primero Productos
            TABS_MenuAdmin.SelectedTab = _tabProductos;

            // Remover el resto de pestañas (una a una; jamás Clear() acá)
            var aRemover = TABS_MenuAdmin.TabPages.Cast<TabPage>()
                .Where(tp => tp != _tabProductos)
                .ToList();

            foreach (var tp in aRemover)
                TABS_MenuAdmin.TabPages.Remove(tp);

            // Selección válida
            TABS_MenuAdmin.SelectedTab = _tabProductos;

            // Reacoplar Drawer y refrescar
            FinalizarActualizacionSeguraDelDrawer();
        }


        /// <summary>
        /// Restaura todas las TabPages al orden original (sale del modo restricción).
        /// </summary>
        public void RestaurarTodasLasTabs()
        {
            if (TABS_MenuAdmin is null) return;

            // Desacoplar Drawer mientras tocamos el TabControl
            ComenzarActualizacionSeguraDelDrawer();

            // Si no hay snapshot, no tocamos nada
            if (!_snapshotTomado || _todasLasTabs.Count == 0)
            {
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            // 1) Agregar las pestañas que falten (NO removemos ninguna)
            foreach (var tp in _todasLasTabs)
            {
                if (!TABS_MenuAdmin.TabPages.Contains(tp))
                    TABS_MenuAdmin.TabPages.Add(tp);
            }

            // 2) Seleccionar una pestaña estable (la primera del snapshot si existe)
            var primera = _todasLasTabs[0];
            if (TABS_MenuAdmin.TabPages.Contains(primera))
                TABS_MenuAdmin.SelectedTab = primera;
            else if (TABS_MenuAdmin.TabPages.Count > 0)
                TABS_MenuAdmin.SelectedIndex = 0;
            else
                TABS_MenuAdmin.SelectedIndex = -1;

            // 3) Reacoplar Drawer
            FinalizarActualizacionSeguraDelDrawer();
        }


        private void ComenzarActualizacionSeguraDelDrawer()
        {
            if (drawerMenu is null) return;

            drawerMenu.BaseTabControl = null;
            drawerMenu.IsOpen = false;
            drawerMenu.Visible = false;
            drawerMenu.Dock = DockStyle.None;

            drawerMenu.SuspendLayout();
            TABS_MenuAdmin?.SuspendLayout();
        }

        private void FinalizarActualizacionSeguraDelDrawer()
        {
            if (TABS_MenuAdmin is null || drawerMenu is null) return;

            drawerMenu.BaseTabControl = TABS_MenuAdmin;

            if (TABS_MenuAdmin.TabPages.Count == 0)
            {
                TABS_MenuAdmin.SelectedIndex = -1;
            }
            else
            {
                if (TABS_MenuAdmin.SelectedIndex < 0) TABS_MenuAdmin.SelectedIndex = 0;
                if (TABS_MenuAdmin.SelectedIndex >= TABS_MenuAdmin.TabPages.Count)
                    TABS_MenuAdmin.SelectedIndex = TABS_MenuAdmin.TabPages.Count - 1;
            }

            TABS_MenuAdmin.ResumeLayout(performLayout: false);
            drawerMenu.ResumeLayout(performLayout: false);
            drawerMenu.Invalidate();
            drawerMenu.Refresh();
        }

        private void ReacoplarDrawerDiferido()
        {
            if (!IsHandleCreated)
            {
                // Si aún no hay handle, re-acoplamos directo
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            // Ejecutar Finalizar... cuando termine el stack de eventos actual
            BeginInvoke(new MethodInvoker(FinalizarActualizacionSeguraDelDrawer));
        }


        /// <summary>
        /// Rellena el ListView 'LIS_Usuario' con la lista entregada (full o filtrada).
        /// </summary>
        private void RenderUsuarios(IEnumerable<UsuarioListadoDto> lista)
        {
            LIS_Usuario.BeginUpdate();
            LIS_Usuario.Items.Clear();

            foreach (var u in lista)
            {
                var nombreParaMostrar = !string.IsNullOrWhiteSpace(u.Usuario)
                    ? u.Usuario
                    : $"{u.Nombre} {u.Apellido}".Trim();

                var item = new ListViewItem(new[]
                {
                     u.IdUsuario.ToString(),
                     u.Nombre ?? "",
                     u.Apellido ?? "",
                     u.Usuario ?? "",
                     u.Email ?? "",
                     u.Celular ?? "",
                     u.EstadoUsuario ? "Activo" : "Inactivo",
                }); LIS_Usuario.Items.Add(item);

            }

            LIS_Usuario.EndUpdate();
        }

        /// <summary>
        /// Aplica el filtro sobre la cache local (_usuariosCache) y re-renderiza.
        /// </summary>
        private void AplicarFiltroUsuarios(string query)
        {
            if (_usuariosCache is null || _usuariosCache.Count == 0)
            {
                LIS_Usuario.Items.Clear();
                return;
            }

            query = (query ?? string.Empty).Trim();

            if (query.Length == 0)
            {
                RenderUsuarios(_usuariosCache);
                return;
            }

            // Coincidencia flexible: usuario, nombre+apellido y email
            var filtrados = _usuariosCache.Where(u =>
            {
                string usuario = u.Usuario ?? "";
                string nombre = u.Nombre ?? "";
                string apellido = u.Apellido ?? "";
                string email = u.Email ?? "";
                string nombreCompleto = $"{nombre} {apellido}".Trim();

                return usuario.Contains(query, StringComparison.OrdinalIgnoreCase)
                    || nombreCompleto.Contains(query, StringComparison.OrdinalIgnoreCase)
                    || email.Contains(query, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            RenderUsuarios(filtrados);
        }

        // === Handlers del buscador ===
        private void TXT_BuscarUsuario_TextChanged(object? sender, EventArgs e)
        {
            _buscadorTmr?.Stop();
            _buscadorTmr?.Start(); // debounce 150ms
        }

        private void BTN_LimpiarBusqueda_Click(object? sender, EventArgs e)
        {
            if (TXT_BuscarUsuario is null) return;

            // Evitar doble disparo de TextChanged
            TXT_BuscarUsuario.TextChanged -= TXT_BuscarUsuario_TextChanged;
            TXT_BuscarUsuario.Text = string.Empty;
            TXT_BuscarUsuario.TextChanged += TXT_BuscarUsuario_TextChanged;

            AplicarFiltroUsuarios(string.Empty);
        }

        private async void BTN_AgregarProducto_Click(object sender, EventArgs e)
        {
            // Evitar instancias duplicadas: si ya está abierto, lo traemos al frente
            var abierto = Application.OpenForms.OfType<FormAgregarProducto>().FirstOrDefault();
            if (abierto is not null)
            {
                if (abierto.WindowState == FormWindowState.Minimized)
                    abierto.WindowState = FormWindowState.Normal;

                abierto.BringToFront();
                abierto.Activate();
                return;
            }

            // Deshabilitar el botón mientras se muestra el modal
            if (BTN_AgregarProducto is not null) BTN_AgregarProducto.Enabled = false;

            try
            {
                var productoApi = _serviceProvider.GetRequiredService<ProductoApiClient>();
                var lineaApi = _serviceProvider.GetRequiredService<LineaApiClient>();
                using var frm = new FormAgregarProducto(productoApi, lineaApi); // si tu formulario requiere dependencias, inyéctalas acá
                var result =  frm.ShowDialog(this);

                // Si confirmaste el alta en el modal, refrescá el listado (descomentá si ya existe el método)
                if (result == DialogResult.OK)
                {
                    await CargarProductosDesdeApiAsync();
                    // RenderProductos(_productosCache); // o el método que uses para repintar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir 'Agregar Producto'.\n\nDetalle: {ex.Message}",
                    "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (BTN_AgregarProducto is not null) BTN_AgregarProducto.Enabled = true;
            }
        }

        /// <summary>
        /// GET /producto/ y pintado de filas en LIST_Producto.
        /// Usa DI para resolver ProductoApiClient (con token).
        /// </summary>
        private async Task CargarProductosDesdeApiAsync()
        {
            try
            {
                var productoApi = _serviceProvider.GetRequiredService<ProductoApiClient>();
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(20));

                var productos = await productoApi.ListarAsync(cts.Token);
                _productosCache = productos.ToList();

                RenderProductos(_productosCache);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("La solicitud de productos expiró (timeout).",
                    "Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API de productos.\n\nDetalle: {ex.Message}",
                    "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cargar productos:\n{ex}",
                    "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Rellena el ListView LIST_Producto con ID, Nombre y (por ahora) Stock "-".
        /// </summary>
        private void RenderProductos(IEnumerable<ProductoResponse> lista)
        {
            if (LIST_Producto.View != View.Details)
                LIST_Producto.View = View.Details;

            LIST_Producto.BeginUpdate();
            LIST_Producto.Items.Clear();

            foreach (var p in lista)
            {
                // Stock: no viene en ProductoResponse; mostramos "-" hasta que definamos la fuente real
                var item = new ListViewItem(new[]
                {
                    p.IdProducto.ToString(),
                    p.NombreProducto ?? string.Empty,
                    p.EstadoProducto ? "Activo" : "Inactivo",
                });

                LIST_Producto.Items.Add(item);
            }

            LIST_Producto.EndUpdate();
        }

    }
}
