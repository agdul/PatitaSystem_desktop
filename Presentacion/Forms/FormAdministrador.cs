// Archivo: Presentacion/Forms/FormAdministrador.cs
using MaterialSkin;
using MaterialSkin.Controls;
using PatitaSystem.Dominio.Usuarios;           // DTO
using PatitaSystem.Infraestructura.Http;       // AuthHeader + UsuarioApiClient
using PatitaSystem.Infraestructura.Seguridad;  // TokenStore
using System.Net;
using System.Net.Http;                         // HttpClient
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        /// <summary>
        /// Si true, el formulario opera mostrando solo la pestaña de Productos.
        /// Puede cambiarse en runtime; luego llamar a <see cref="AplicarRestriccionSoloProductos"/>.
        /// </summary>
        public bool ModoSoloProductos { get; set; }

        // =========================
        //  API Usuarios (ya tenías)
        // =========================
        private readonly UsuarioApiClient _usuarioApi;

        // Una sola instancia para el modal de registro
        private FormRegistrarUsuario? _frmRegistrarUsuario;

        public FormAdministrador()
        {
            InitializeComponent();
            TomarSnapshotDeTabsInicial();

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

            // -----------------------------------------
            // Config columnas + carga real al mostrar UI
            // -----------------------------------------
            ConfigurarListaUsuarios();
            ConfigurarListaTurnos();
            ConfigurarListaProductos();

            this.Load -= FormAdministrador_LoadAsync;
            this.Load += FormAdministrador_LoadAsync;
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
                        u.Password ?? "" // Mostrar password nunca es buena práctica; solo para testing.
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
                    ? new FormRegistrarUsuario(_usuarioApi)
                    : new FormRegistrarUsuario(_usuarioApi, usuarioParaEditar);

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


    }
}
