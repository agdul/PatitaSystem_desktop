// Archivo: Presentacion/Forms/FormAdministrador.cs
using MaterialSkin;
using MaterialSkin.Controls;
using PatitaSystem.Dominio.Usuarios;           // DTO
using PatitaSystem.Infraestructura.Http;       // AuthHeader + UsuarioApiClient
using PatitaSystem.Infraestructura.Seguridad;  // TokenStore
using System.Net;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatitaSystem.Presentacion.Forms
{
    public partial class FormAdministrador : MaterialForm
    {
        // Cliente API de usuarios (readonly: lo inicializamos en el ctor)
        private readonly UsuarioApiClient _usuarioApi;

        // Creamos una instancia del formulario de registro de usuario
        private FormRegistrarUsuario? _frmRegistrarUsuario;

        public FormAdministrador()
        {
            InitializeComponent();

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
            drawerMenu.BaseTabControl = TABS_MenuAdmin;

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

            // -----------------------------------------
            // Config columnas + carga real al mostrar UI
            // -----------------------------------------
            ConfigurarListaUsuarios();
            ConfigurarListaTurnos();
            ConfigurarListaProductos();

            this.Load -= FormAdministrador_LoadAsync;
            this.Load += FormAdministrador_LoadAsync;
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
                LIS_Usuario.Columns.Add("Usuario", 150);
                LIS_Usuario.Columns.Add("Email", 190);
                LIS_Usuario.Columns.Add("Celular", 130);
                LIS_Usuario.Columns.Add("Estado", 130);
                LIS_Usuario.Columns.Add("Password", 150);
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

                LIS_Usuario.BeginUpdate();
                LIS_Usuario.Items.Clear();

                foreach (var u in usuarios)
                {
                    var nombreParaMostrar = !string.IsNullOrWhiteSpace(u.Usuario)
                        ? u.Usuario
                        : $"{u.Nombre} {u.Apellido}".Trim();

                    var item = new ListViewItem(new[]
                    {
                        u.IdUsuario.ToString(),
                        nombreParaMostrar,
                        u.Email ?? "",
                        u.Celular ?? "",
                        u.EstadoUsuario ? "Activo" : "Inactivo",
                        u.Password ?? "" // Si tienes campo de password (no es seguro mostrarlo)
                    });

                    LIS_Usuario.Items.Add(item);
                }

                LIS_Usuario.EndUpdate();
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("La solicitud de usuarios expiró (timeout).",
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (HttpRequestException ex)
            {
                // UsuarioApiClient lanza detalle con status + cuerpo si hay error.
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
        //  NUEVO: Apertura modal única
        // ---------------------------
        /// <summary>
        /// Abre FormRegistrarUsuario como **modal**, ocultando este formulario mientras tanto.
        /// - Evita múltiples instancias (si ya está abierta, la trae al frente).
        /// - Al cerrar, vuelve a mostrar este form y refresca la lista de usuarios.
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
                    ? new FormRegistrarUsuario(_usuarioApi)                   // <<<< PASAMOS EL CLIENTE
                    : new FormRegistrarUsuario(_usuarioApi, usuarioParaEditar);

                _frmRegistrarUsuario.FormClosed += (_, __) => _frmRegistrarUsuario = null;

                this.Hide();
                var result = _frmRegistrarUsuario.ShowDialog(this);

                // Refrescamos (si devolvió OK o no, igual no rompe)
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


        // Botón MODIFICAR (usa tu clase interna Usuario para pasar datos al form)
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

        // Clase interna tuya (para pasar al form de edición)
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
            if (ListViewProducto.View != View.Details)
                ListViewProducto.View = View.Details;

            ListViewProducto.FullRowSelect = true;
            ListViewProducto.GridLines = true;

            if (ListViewProducto.Columns.Count == 0)
            {
                ListViewProducto.Columns.Add("ID", 50);
                ListViewProducto.Columns.Add("Producto", 150);
                ListViewProducto.Columns.Add("Stock", 175);
            }
        }

        private void materialButton7_Click(object sender, System.EventArgs e)
        {
            if (ListViewProducto.SelectedItems.Count > 0)
            {
                var item = ListViewProducto.SelectedItems[0];
                string producto = item.SubItems[1].Text;

                var confirm = MessageBox.Show(
                    $"¿Estás seguro de eliminar {producto}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // TODO: DELETE real cuando tengas endpoint
                    ListViewProducto.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un producto primero.");
            }
        }

        private void materialButton9_Click(object sender, System.EventArgs e)
        {
            if (ListViewProducto.SelectedItems.Count > 0)
            {
                var frm = new FormEditarProducto(ListViewProducto);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccioná un producto primero.");
            }
        }
    }
}
