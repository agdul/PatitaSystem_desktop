// Archivo: Presentacion/Forms/Dashboard_Form.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using PatitaSystem.Dominio.Auth;
using PatitaSystem.Dominio.Sesion;
using PatitaSystem.Presentacion.Forms;
using Presentacion;

namespace PatitaSystem
{
    /// <summary>
    /// Dashboard principal con Drawer lateral y pestañas.
    /// - Gestiona apertura/cierre del Drawer.
    /// - Aplica visibilidad de tabs según el rol del usuario (IdRol) en sesión.
    /// - Cablea botones a formularios externos, ocultando el Dashboard y evitando instancias duplicadas.
    /// </summary>
    public partial class Dashboard_Form : MaterialForm
    {
        // ---- Formularios hijos (single instance) ----------------------------
        private FormAdministrador? _formAdministrador;
        private FormCarrito? _formVendedor;
        private Turnos_Form? _formTurnos;
        private FormMascotas? _formMascotas;
        private LoginStyle_2003? _formReportes;

        // ---- Estado interno (drawer) ----------------------------------------
        private bool _drawerShown = false;
        private System.Windows.Forms.Timer? _hideTmr;

        // ---- Sesión actual ---------------------------------------------------
        private SesionActual? _sesion;

        // ---- Tabs (referencias y backup de todas) ---------------------------
        private TabPage? _tabPatitaShop;
        private TabPage? _tabPatitaPelu;
        // private TabPage? _tabPatitaConfig; // futuro
        private List<TabPage> _todasLasTabs = new();

        /// <summary>
        /// Constructor. Inicializa MaterialSkin, oculta Drawer al inicio y layout inicial.
        /// </summary>
        public Dashboard_Form()
        {
            InitializeComponent();

            try
            {
                // MaterialSkin
                var skin = MaterialSkinManager.Instance;
                skin.AddFormToManage(this);
                skin.Theme = MaterialSkinManager.Themes.DARK;
                skin.ColorScheme = new ColorScheme(
                    Primary.Teal700, Primary.Teal900, Primary.Teal500,
                    Accent.Green200, TextShade.WHITE
                );

                // Drawer fuera del árbol al iniciar
                if (DRW_Menu is not null)
                {
                    DRW_Menu.Visible = false;
                    DRW_Menu.Dock = DockStyle.None;
                    DRW_Menu.IsOpen = false;
                }

                // Layout inicial
                ReorganizarAhora();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en constructor de Dashboard:\n\n" + ex,
                   "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Configura la sesión autenticada (inyectada desde ContextoPatita).
        /// </summary>
        public void ConfigureWithSession(SesionActual sesion)
        {
            _sesion = sesion ?? throw new ArgumentNullException(nameof(sesion));
            InicializarTabsSegunDesigner();
            // Reglas de rol se aplican en OnShown cuando el form ya está estable.
        }

        /// <summary>
        /// Cableado de eventos de botones del Dashboard y fallback si aún no indexamos tabs.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // ---- Botón hamburguesa (mostrar/ocultar Drawer)
            BTN_Menu.Click -= BTN_Menu_Click;
            BTN_Menu.Click += BTN_Menu_Click;

            // ---- Cableado de navegación
            BTN_Ventas.Click -= BTN_Ventas_Click;
            BTN_Ventas.Click += BTN_Ventas_Click;

            BTN_Productos.Click -= BTN_Productos_Click;
            BTN_Productos.Click += BTN_Productos_Click;

            BTN_Turnos.Click -= BTN_Turnos_Click;
            BTN_Turnos.Click += BTN_Turnos_Click;

            BTN_Mascotas.Click -= BTN_Mascotas_Click;
            BTN_Mascotas.Click += BTN_Mascotas_Click;

            BTN_AdminMenu.Click -= BTN_AdminMenu_Click;
            BTN_AdminMenu.Click += BTN_AdminMenu_Click;

            BTN_Reportes.Click -= BTN_Reportes_Click;
            BTN_Reportes.Click += BTN_Reportes_Click;

            // Indexar tabs si aun no lo hicimos
            if (_todasLasTabs.Count == 0)
                InicializarTabsSegunDesigner();
        }

        /// <summary>
        /// Al mostrarse el formulario, aplicar reglas de rol y sincronizar Drawer.
        /// </summary>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (_sesion is not null && _sesion.EstaAutenticado)
                AplicarReglasDeRol();
            else
                SincronizarDrawerConTabs();
        }

        // ---------------------------------------------------------------------
        // EVENTOS DE UI
        // ---------------------------------------------------------------------

        private void BTN_Menu_Click(object? sender, EventArgs e)
        {
            if (_drawerShown) CloseDrawer();
            else OpenDrawer();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (TABS_MenuPatita is not null && TABS_MenuPatita.Visible)
            {
                int left = (Controls.Contains(DRW_Menu) && DRW_Menu.Visible) ? DRW_Menu.Width : 0;
                TABS_MenuPatita.Left = Math.Max(0, left);
                TABS_MenuPatita.Width = Math.Max(0, ClientSize.Width - left);
            }

            ReorganizarAhora();
        }

        // ---------------------------------------------------------------------
        // CABLEADO DE BOTONES → VISTAS (single-instance + ocultar dashboard)
        // ---------------------------------------------------------------------

        private void BTN_Ventas_Click(object? sender, EventArgs e)
        {
            if (_formVendedor is null || _formVendedor.IsDisposed)
            {
                _formVendedor = new FormCarrito
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                _formVendedor.FormClosed += (_, __) =>
                {
                    _formVendedor?.Dispose();
                    _formVendedor = null;
                    this.Show();
                    this.Activate();
                };
            }

            this.Hide();
            _formVendedor.Show();
            _formVendedor.BringToFront();
            _formVendedor.Focus();
        }

        private void BTN_Productos_Click(object? sender, EventArgs e)
        {
            AbrirAdministradorSoloProductos();
        }

        private void BTN_Turnos_Click(object? sender, EventArgs e)
        {
            if (_formTurnos is null || _formTurnos.IsDisposed)
            {
                _formTurnos = new Turnos_Form
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                _formTurnos.FormClosed += (_, __) =>
                {
                    _formTurnos?.Dispose();
                    _formTurnos = null;
                    this.Show();
                    this.Activate();
                };
            }

            this.Hide();
            _formTurnos.Show();
            _formTurnos.BringToFront();
            _formTurnos.Focus();
        }

        private void BTN_Mascotas_Click(object? sender, EventArgs e)
        {
            if (_formMascotas is null || _formMascotas.IsDisposed)
            {
                _formMascotas = new FormMascotas
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                _formMascotas.FormClosed += (_, __) =>
                {
                    _formMascotas?.Dispose();
                    _formMascotas = null;
                    this.Show();
                    this.Activate();
                };
            }

            this.Hide();
            _formMascotas.Show();
            _formMascotas.BringToFront();
            _formMascotas.Focus();
        }

        private void BTN_AdminMenu_Click(object? sender, EventArgs e)
        {
            AbrirAdministradorSinRestriccion();
        }

        private void BTN_Reportes_Click(object? sender, EventArgs e)
        {
            if (_formReportes is null || _formReportes.IsDisposed)
            {
                _formReportes = new LoginStyle_2003
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                _formReportes.FormClosed += (_, __) =>
                {
                    _formReportes?.Dispose();
                    _formReportes = null;
                    this.Show();
                    this.Activate();
                };
            }

            this.Hide();
            _formReportes.Show();
            _formReportes.BringToFront();
            _formReportes.Focus();
        }

        private void AbrirAdministradorSoloProductos()
        {
            if (_formAdministrador is null || _formAdministrador.IsDisposed)
            {
                _formAdministrador = new FormAdministrador
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                _formAdministrador.ModoSoloProductos = true;

                _formAdministrador.FormClosed += (_, __) =>
                {
                    _formAdministrador?.Dispose();
                    _formAdministrador = null;
                    this.Show();
                    this.Activate();
                };
            }
            else
            {
                _formAdministrador.ModoSoloProductos = true;
                _formAdministrador.AplicarRestriccionSoloProductos();
            }

            this.Hide();
            _formAdministrador.Show();
            _formAdministrador.BringToFront();
            _formAdministrador.Focus();
        }

        private void AbrirAdministradorSinRestriccion()
        {
            if (_formAdministrador is null || _formAdministrador.IsDisposed)
            {
                _formAdministrador = new FormAdministrador
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                _formAdministrador.FormClosed += (_, __) =>
                {
                    _formAdministrador?.Dispose();
                    _formAdministrador = null;
                    this.Show();
                    this.Activate();
                };
            }

            _formAdministrador.ModoSoloProductos = false;
            _formAdministrador.RestaurarTodasLasTabs();  // importante

            this.Hide();
            _formAdministrador.Show();
            _formAdministrador.BringToFront();
            _formAdministrador.Focus();
        }

        // ---------------------------------------------------------------------
        // LÓGICA DE DRAWER
        // ---------------------------------------------------------------------

        private void OpenDrawer()
        {
            if (DRW_Menu is null) return;

            FinalizarActualizacionSeguraDelDrawer();

            DRW_Menu.Visible = true;
            DRW_Menu.Dock = DockStyle.Left;
            DRW_Menu.BringToFront();
            DRW_Menu.IsOpen = true;

            if (TABS_MenuPatita is not null)
            {
                TABS_MenuPatita.Visible = true;
                TABS_MenuPatita.Left = DRW_Menu.Width;
                TABS_MenuPatita.Width = Math.Max(0, ClientSize.Width - TABS_MenuPatita.Left);
            }

            _drawerShown = true;
            if (BTN_Menu is not null) BTN_Menu.Text = "Cerrar";
            ReorganizarAhora();

            DisposeHideTimerIfAny();
        }

        private void CloseDrawer()
        {
            if (DRW_Menu is not null)
                DRW_Menu.IsOpen = false;

            if (BTN_Menu is not null)
                BTN_Menu.Text = "Menú";

            DisposeHideTimerIfAny();
            _hideTmr = new System.Windows.Forms.Timer { Interval = 220 };
            _hideTmr.Tick += OnHideTimerTick;
            _hideTmr.Start();
        }

        private void OnHideTimerTick(object? sender, EventArgs e)
        {
            DisposeHideTimerIfAny();

            if (TABS_MenuPatita is not null)
            {
                TABS_MenuPatita.Visible = false;
                TABS_MenuPatita.Left = 0;
                TABS_MenuPatita.Width = ClientSize.Width;
            }

            if (DRW_Menu is not null)
            {
                DRW_Menu.IsOpen = false;
                DRW_Menu.Visible = false;
                DRW_Menu.Dock = DockStyle.None;
            }

            _drawerShown = false;
            ReorganizarAhora();
        }

        private void DisposeHideTimerIfAny()
        {
            if (_hideTmr is null) return;
            _hideTmr.Stop();
            _hideTmr.Tick -= OnHideTimerTick;
            _hideTmr.Dispose();
            _hideTmr = null;
        }

        // ---------------------------------------------------------------------
        // LAYOUT "HERO" (LOGO + BOTÓN)
        // ---------------------------------------------------------------------

        private void ReorganizarAhora() => DistribuirHero(_drawerShown);

        private void DistribuirHero(bool drawerOpen)
        {
            if (PIC_Logo is null || BTN_Menu is null) return;

            int leftMargin = (Controls.Contains(DRW_Menu) && DRW_Menu.Visible) ? DRW_Menu.Width : 0;
            int availWidth = ClientSize.Width - leftMargin;
            if (availWidth < 0) availWidth = 0;

            int heroWidth = Math.Max(PIC_Logo.Width, BTN_Menu.Width);
            int heroLeft = leftMargin + (availWidth - heroWidth) / 2;

            int baseTop = 150;
            int shiftWhenOpen = -60;

            PIC_Logo.Left = heroLeft;
            PIC_Logo.Top = baseTop + (drawerOpen ? shiftWhenOpen : 0);

            BTN_Menu.Left = heroLeft + (heroWidth - BTN_Menu.Width) / 2;
            BTN_Menu.Top = PIC_Logo.Bottom - 45;
        }

        // ---------------------------------------------------------------------
        // ROLES → VISIBILIDAD DE TABS
        // ---------------------------------------------------------------------

        private void InicializarTabsSegunDesigner()
        {
            if (TABS_MenuPatita is null) return;

            _todasLasTabs = TABS_MenuPatita.TabPages.Cast<TabPage>().ToList();

            string[] nombresShop = { "TAB_PatitaShop", "tabPatitaShop" };
            string[] nombresPelu = { "TAB_PatitaPelu", "tabPatitaPelu" };

            _tabPatitaShop = _todasLasTabs.FirstOrDefault(tp =>
                nombresShop.Any(n => string.Equals(tp.Name, n, StringComparison.OrdinalIgnoreCase)));

            _tabPatitaPelu = _todasLasTabs.FirstOrDefault(tp =>
                nombresPelu.Any(n => string.Equals(tp.Name, n, StringComparison.OrdinalIgnoreCase)));

            SuscribirEventosDeTabs();
            FinalizarActualizacionSeguraDelDrawer();
        }

        private void SuscribirEventosDeTabs()
        {
            if (TABS_MenuPatita is null) return;

            TABS_MenuPatita.ControlAdded -= Tabs_ColeccionCambio;
            TABS_MenuPatita.ControlRemoved -= Tabs_ColeccionCambio;
            TABS_MenuPatita.SelectedIndexChanged -= Tabs_SeleccionCambio;

            TABS_MenuPatita.ControlAdded += Tabs_ColeccionCambio;
            TABS_MenuPatita.ControlRemoved += Tabs_ColeccionCambio;
            TABS_MenuPatita.SelectedIndexChanged += Tabs_SeleccionCambio;
        }

        private void Tabs_ColeccionCambio(object? sender, ControlEventArgs e)
        {
            ComenzarActualizacionSeguraDelDrawer();

            if (TABS_MenuPatita!.TabPages.Count == 0)
            {
                TABS_MenuPatita.SelectedIndex = -1;
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            if (TABS_MenuPatita.SelectedIndex < 0) TABS_MenuPatita.SelectedIndex = 0;
            if (TABS_MenuPatita.SelectedIndex >= TABS_MenuPatita.TabPages.Count)
                TABS_MenuPatita.SelectedIndex = TABS_MenuPatita.TabPages.Count - 1;

            FinalizarActualizacionSeguraDelDrawer();
        }

        private void Tabs_SeleccionCambio(object? sender, EventArgs e)
        {
            FinalizarActualizacionSeguraDelDrawer();
        }

        private void SincronizarDrawerConTabs()
        {
            if (DRW_Menu is null || TABS_MenuPatita is null) return;

            if (DRW_Menu.BaseTabControl != TABS_MenuPatita)
                DRW_Menu.BaseTabControl = TABS_MenuPatita;

            if (TABS_MenuPatita.TabPages.Count == 0)
            {
                TABS_MenuPatita.SelectedIndex = -1;
                DRW_Menu.IsOpen = false;
                DRW_Menu.Visible = false;
                DRW_Menu.Dock = DockStyle.None;
                DRW_Menu.Invalidate();
                return;
            }

            if (TABS_MenuPatita.SelectedIndex < 0)
                TABS_MenuPatita.SelectedIndex = 0;
            if (TABS_MenuPatita.SelectedIndex >= TABS_MenuPatita.TabPages.Count)
                TABS_MenuPatita.SelectedIndex = TABS_MenuPatita.TabPages.Count - 1;

            DRW_Menu.Invalidate();
            DRW_Menu.Refresh();
        }

        private void ComenzarActualizacionSeguraDelDrawer()
        {
            if (DRW_Menu is null) return;

            DRW_Menu.BaseTabControl = null;
            DRW_Menu.IsOpen = false;
            DRW_Menu.Visible = false;
            DRW_Menu.Dock = DockStyle.None;

            DRW_Menu.SuspendLayout();
            TABS_MenuPatita?.SuspendLayout();
        }

        private void FinalizarActualizacionSeguraDelDrawer()
        {
            if (TABS_MenuPatita is null || DRW_Menu is null) return;

            DRW_Menu.BaseTabControl = TABS_MenuPatita;

            if (TABS_MenuPatita.TabPages.Count == 0)
            {
                TABS_MenuPatita.SelectedIndex = -1;
            }
            else
            {
                if (TABS_MenuPatita.SelectedIndex < 0) TABS_MenuPatita.SelectedIndex = 0;
                if (TABS_MenuPatita.SelectedIndex >= TABS_MenuPatita.TabPages.Count)
                    TABS_MenuPatita.SelectedIndex = TABS_MenuPatita.TabPages.Count - 1;
            }

            TABS_MenuPatita.ResumeLayout(performLayout: false);
            DRW_Menu.ResumeLayout(performLayout: false);
            DRW_Menu.Invalidate();
            DRW_Menu.Refresh();
        }

        private void AplicarReglasDeRol()
        {
            if (TABS_MenuPatita is null || _todasLasTabs.Count == 0) return;

            // Desacoplar el Drawer una sola vez para todas las operaciones
            ComenzarActualizacionSeguraDelDrawer();

            // 1) Restaurar (sin Clear)
            RestaurarTodasLasTabs(coreOnly: true);

            int rol = _sesion?.Usuario?.IdRol ?? 0;

            if (rol == Roles.Admin)
            {
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            if (rol == Roles.Estilista)
            {
                QuitarTodosMenos(_tabPatitaPelu, coreOnly: true);
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            if (rol == Roles.Vendedor)
            {
                QuitarTodosMenos(_tabPatitaShop, coreOnly: true);
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            QuitarTodosMenos(null, coreOnly: true);
            FinalizarActualizacionSeguraDelDrawer();
        }

        private void QuitarTodosMenos(TabPage? tabPermitida, bool coreOnly = false)
        {
            if (TABS_MenuPatita is null) return;

            // Seleccionar primero la tab permitida (si existe) para no disparar deselect raro
            if (tabPermitida is not null && TABS_MenuPatita.TabPages.Contains(tabPermitida))
                TABS_MenuPatita.SelectedTab = tabPermitida;

            foreach (var tp in _todasLasTabs)
            {
                if (tp != tabPermitida && TABS_MenuPatita.TabPages.Contains(tp))
                    TABS_MenuPatita.TabPages.Remove(tp);
            }

            if (tabPermitida is not null && !TABS_MenuPatita.TabPages.Contains(tabPermitida))
                TABS_MenuPatita.TabPages.Add(tabPermitida);

            // Clamp de selección
            if (TABS_MenuPatita.TabPages.Count == 0)
                TABS_MenuPatita.SelectedIndex = -1;
            else if (TABS_MenuPatita.SelectedIndex < 0)
                TABS_MenuPatita.SelectedIndex = 0;

            if (!coreOnly) FinalizarActualizacionSeguraDelDrawer();
        }

        private void RestaurarTodasLasTabs(bool coreOnly = false)
        {
            if (TABS_MenuPatita is null) return;

            // *** IMPORTANTE: no usar Clear() aquí ***
            foreach (var tp in _todasLasTabs)
            {
                if (!TABS_MenuPatita.TabPages.Contains(tp))
                    TABS_MenuPatita.TabPages.Add(tp);
            }

            // Selección estable
            if (TABS_MenuPatita.TabPages.Count > 0 && TABS_MenuPatita.SelectedIndex < 0)
                TABS_MenuPatita.SelectedIndex = 0;
            if (TABS_MenuPatita.SelectedIndex >= TABS_MenuPatita.TabPages.Count)
                TABS_MenuPatita.SelectedIndex = TABS_MenuPatita.TabPages.Count - 1;

            if (!coreOnly) FinalizarActualizacionSeguraDelDrawer();
        }
    }
}
