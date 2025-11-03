// Archivo: Presentacion/Forms/FormAgregarProducto.Autocomplete.cs
using MaterialSkin.Controls;
using PatitaSystem.Dominio.Producto;
using PatitaSystem.Infraestructura.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatitaSystem.Presentacion.Forms
{
    /// <summary>
    /// Parcial que agrega Autocomplete sobre TXT_ProductoBuscar,
    /// renderizando una lista flotante "tipo dropdown".
    /// </summary>
    public partial class FormAgregarProducto : MaterialForm
    {

        // Control flotante para sugerencias
        private Panel? _pnlSugerencias;
        private ListBox? _lstSugerencias;

        // Debounce + cancelación por tipeo
        private CancellationTokenSource? _autoCts;

        // Selección actual
        private int? _productoSeleccionadoId;
        private string? _productoSeleccionadoNombre;

        // ======== INICIALIZACIÓN AUTOCOMPLETE ========
        private void InicializarAutocompleteProducto()
        {
            // TXT_ProductoBuscar debe existir en tu .Designer
            if (TXT_ProductoBuscar is null)
                throw new InvalidOperationException("No se encontró el TextBox TXT_ProductoBuscar en el diseñador.");

            // Panel flotante
            _pnlSugerencias = new Panel
            {
                Visible = false,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Width = TXT_ProductoBuscar.Width,
                Height = 180
            };
            Controls.Add(_pnlSugerencias);
            _pnlSugerencias.BringToFront();

            // ListBox para opciones
            _lstSugerencias = new ListBox
            {
                Dock = DockStyle.Fill,
                IntegralHeight = false
            };
            _lstSugerencias.Click += (_, __) => ConfirmarSeleccionDesdeLista();
            _lstSugerencias.KeyDown += LstSugerencias_KeyDown;
            _pnlSugerencias.Controls.Add(_lstSugerencias);

            // Eventos TextBox
            TXT_ProductoBuscar.TextChanged += TXT_ProductoBuscar_TextChanged;
            TXT_ProductoBuscar.KeyDown += TXT_ProductoBuscar_KeyDown;
            TXT_ProductoBuscar.LostFocus += (_, __) =>
            {
                // Ocultamos solo si foco no queda en la lista
                if (!(_lstSugerencias?.Focused ?? false))
                    OcultarSugerencias();
            };

            // Reubicar popup cuando se mueva/redimensione
            TXT_ProductoBuscar.LocationChanged += (_, __) => ReposicionarPopup();
            TXT_ProductoBuscar.SizeChanged += (_, __) => ReposicionarPopup();
            this.Move += (_, __) => ReposicionarPopup();
            this.Resize += (_, __) => ReposicionarPopup();

            // Limpieza de CTS sin tocar Dispose del Designer
            this.FormClosed += (_, __) =>
            {
                _autoCts?.Cancel();
                _autoCts?.Dispose();
            };

            ReposicionarPopup();
        }

        // Llamar esto DESPUÉS de InitializeComponent() en tu constructor
        private void ReposicionarPopup()
        {
            if (_pnlSugerencias is null) return;

            var txt = TXT_ProductoBuscar;
            var abajo = new Point(txt.Left, txt.Bottom);
            _pnlSugerencias.Left = abajo.X;
            _pnlSugerencias.Top = abajo.Y + 2;
            _pnlSugerencias.Width = txt.Width;
        }

        // ============ EVENTOS UI ============

        private async void TXT_ProductoBuscar_TextChanged(object? sender, EventArgs e)
        {
            var q = TXT_ProductoBuscar.Text?.Trim() ?? string.Empty;

            // Si borró o menos de 2 chars → limpiar
            if (q.Length < 2)
            {
                _productoSeleccionadoId = null;
                _productoSeleccionadoNombre = null;
                LimpiarSugerencias();
                return;
            }

            // Debounce + cancelación
            _autoCts?.Cancel();
            _autoCts?.Dispose();
            _autoCts = new CancellationTokenSource();
            var ct = _autoCts.Token;

            try
            {
                await Task.Delay(250, ct); // debounce 250ms

                if (_productoApi is null) return;

                var resultados = await _productoApi
                    .BuscarAutocompleteAsync(q, limit: 8, offset: 0, ct)
                    .ConfigureAwait(true);

                PintarSugerencias(resultados);
            }
            catch (OperationCanceledException)
            {
                // ignorar: se canceló por seguir tipeando
            }
            catch (Exception ex)
            {
                // podés loguear si querés
                Console.WriteLine(ex);
                LimpiarSugerencias();
            }
        }

        private void TXT_ProductoBuscar_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!(_lstSugerencias?.Visible ?? false)) return;

            if (e.KeyCode == Keys.Down)
            {
                if (_lstSugerencias!.Items.Count > 0)
                {
                    _lstSugerencias.Focus();
                    _lstSugerencias.SelectedIndex = Math.Max(0, _lstSugerencias.SelectedIndex);
                }
                e.Handled = true;
            }
        }

        private void LstSugerencias_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmarSeleccionDesdeLista();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                OcultarSugerencias();
                TXT_ProductoBuscar.Focus();
                e.Handled = true;
            }
        }

        // ============ RENDER / SELECCIÓN ============

        private void PintarSugerencias(IReadOnlyList<ProductoSearchAutocomplete> items)
        {
            if (_lstSugerencias is null || _pnlSugerencias is null) return;

            _lstSugerencias.BeginUpdate();
            _lstSugerencias.Items.Clear();

            foreach (var it in items)
                _lstSugerencias.Items.Add(it);

            _lstSugerencias.EndUpdate();

            _pnlSugerencias.Visible = _lstSugerencias.Items.Count > 0;
            if (_pnlSugerencias.Visible)
                _lstSugerencias.SelectedIndex = 0;
        }

        private void LimpiarSugerencias()
        {
            if (_lstSugerencias is null || _pnlSugerencias is null) return;
            _lstSugerencias.Items.Clear();
            _pnlSugerencias.Visible = false;
        }

        private void OcultarSugerencias()
        {
            if (_pnlSugerencias is null) return;
            _pnlSugerencias.Visible = false;
        }

        private void ConfirmarSeleccionDesdeLista()
        {
            if (_lstSugerencias is null || _lstSugerencias.SelectedItem is null) return;

            var sel = (ProductoSearchAutocomplete)_lstSugerencias.SelectedItem;
            _productoSeleccionadoId = sel.IdProducto;
            _productoSeleccionadoNombre = sel.NombreProducto;

            TXT_ProductoBuscar.TextChanged -= TXT_ProductoBuscar_TextChanged; // evitar rebote
            TXT_ProductoBuscar.Text = sel.NombreProducto;
            TXT_ProductoBuscar.SelectionStart = TXT_ProductoBuscar.Text.Length;
            TXT_ProductoBuscar.TextChanged += TXT_ProductoBuscar_TextChanged;

            OcultarSugerencias();
            TXT_ProductoBuscar.Focus();
        }

        // ============ INTEGRACIÓN CON TU POST ============

        /// <summary>
        /// Devuelve el Id del producto elegido por el usuario.
        /// Si escribe manualmente y no elige, intentamos devolver null para forzar validación.
        /// </summary>
        private int? ObtenerProductoSeleccionadoId() => _productoSeleccionadoId;

        /// <summary>
        /// Llamar desde tu validación antes de crear la Presentación.
        /// </summary>
        private void ValidarProductoSeleccionado()
        {
            if (_productoSeleccionadoId is null)
                throw new InvalidOperationException("Seleccioná un producto de la lista de sugerencias.");
        }


    }
}
