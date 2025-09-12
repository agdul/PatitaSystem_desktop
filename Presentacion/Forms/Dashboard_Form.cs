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

namespace PatitaSystem
{
    /// <summary>
    /// Dashboard principal con Drawer lateral y pestañas.
    /// - Gestiona apertura/cierre del Drawer.
    /// - Aplica visibilidad de tabs según el rol del usuario (IdRol) en sesión.
    /// </summary>
    public partial class Dashboard_Form : MaterialForm
    {
        // ---- Estado interno (drawer) ----------------------------------------
        private bool _drawerShown = false;
        private System.Windows.Forms.Timer? _hideTmr;

        // ---- Sesión actual ---------------------------------------------------
        private SesionActual? _sesion;

        // ---- Tabs (referencias y backup de todas) ---------------------------
        private TabPage? _tabPatitaShop;
        private TabPage? _tabPatitaPelu;
        // private TabPage? _tabPatitaConfig; // <- (FUTURO) cuando agregues la pestaña de Config
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
                    // 🔒 Importante: NO remover del árbol. Sólo ocultar y sacar Dock.
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
        /// Suministrá la sesión auténticada desde fuera (ej. ContextoPatita) apenas crees el Dashboard.
        /// LUEGO llama a <see cref="InicializarTabsSegunDesigner"/> y <see cref="AplicarReglasDeRol"/>.
        /// </summary>
        public void ConfigureWithSession(SesionActual sesion)
        {
            _sesion = sesion ?? throw new ArgumentNullException(nameof(sesion));

            InicializarTabsSegunDesigner();
            // 👇 No aplico reglas acá para evitar animaciones tempranas de Drawer.
            //    Las aplico en OnShown cuando el form ya está estable.
        }

        /// <summary>
        /// Si el Designer no conectó eventos, cableamos acá. También
        /// intentamos inicializar si aún no tenemos snapshot de tabs.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BTN_Menu.Click -= BTN_Menu_Click;
            BTN_Menu.Click += BTN_Menu_Click;

            // En caso de que ConfigureWithSession aún no se haya llamado,
            // intentamos al menos indexar las tabs (sin aplicar reglas).
            if (_todasLasTabs.Count == 0)
                InicializarTabsSegunDesigner();

            // ❌ Evitar aplicar reglas acá, ver OnShown.
        }

        /// <summary>
        /// Al mostrarse el formulario (ya creado y sin animación inicial),
        /// aplicamos reglas de rol y sincronizamos el Drawer.
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

            if (tabs is not null && tabs.Visible)
            {
                int left = (Controls.Contains(DRW_Menu) && DRW_Menu.Visible) ? DRW_Menu.Width : 0;
                tabs.Left = Math.Max(0, left);
                tabs.Width = Math.Max(0, ClientSize.Width - left);
            }

            ReorganizarAhora();
        }

        // ---------------------------------------------------------------------
        // LÓGICA DE DRAWER
        // ---------------------------------------------------------------------

        private void OpenDrawer()
        {
            if (DRW_Menu is null) return;

            // Asegurar acople y estado coherente antes de abrir
            FinalizarActualizacionSeguraDelDrawer();

            // Volver visible y dockear a la izquierda
            DRW_Menu.Visible = true;
            DRW_Menu.Dock = DockStyle.Left;
            DRW_Menu.BringToFront();
            DRW_Menu.IsOpen = true;

            if (tabs is not null)
            {
                tabs.Visible = true;
                tabs.Left = DRW_Menu.Width;
                tabs.Width = Math.Max(0, ClientSize.Width - tabs.Left);
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

            if (tabs is not null)
            {
                tabs.Visible = false;
                tabs.Left = 0;
                tabs.Width = ClientSize.Width;
            }

            if (DRW_Menu is not null)
            {
                // 🔒 Importante: NO remover de Controls, sólo ocultar/sin dock
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

        /// <summary>
        /// Indexa las TabPage existentes por su Name (según Designer) y
        /// guarda un snapshot del orden original para restaurar cuando cambie el rol.
        /// </summary>
        private void InicializarTabsSegunDesigner()
        {
            if (tabs is null) return;

            // Cacheo el orden original (para poder restaurar)
            _todasLasTabs = tabs.TabPages.Cast<TabPage>().ToList();

            // Buscar por Name, tolerando nombres del Designer (minúsculas/mayúsculas)
            string[] nombresShop = { "TAB_PatitaShop", "tabPatitaShop" };
            string[] nombresPelu = { "TAB_PatitaPelu", "tabPatitaPelu" };

            _tabPatitaShop = _todasLasTabs.FirstOrDefault(tp =>
                nombresShop.Any(n => string.Equals(tp.Name, n, StringComparison.OrdinalIgnoreCase)));

            _tabPatitaPelu = _todasLasTabs.FirstOrDefault(tp =>
                nombresPelu.Any(n => string.Equals(tp.Name, n, StringComparison.OrdinalIgnoreCase)));

            // (FUTURO) _tabPatitaConfig cuando exista

            // Evento Suscripto para blindar cambios de colección
            SuscribirEventosDeTabs();

            // Dejar enlazado/normalizado el Drawer (sin aplicar reglas todavía)
            FinalizarActualizacionSeguraDelDrawer();
        }


        /// <summary>
        /// Se suscribe a los eventos del TabControl para mantener el Drawer
        /// siempre consistente (índice y cantidad).
        /// </summary>
        private void SuscribirEventosDeTabs()
        {
            if (tabs is null) return;

            tabs.ControlAdded -= Tabs_ColeccionCambio;
            tabs.ControlRemoved -= Tabs_ColeccionCambio;
            tabs.SelectedIndexChanged -= Tabs_SeleccionCambio;

            tabs.ControlAdded += Tabs_ColeccionCambio;
            tabs.ControlRemoved += Tabs_ColeccionCambio;
            tabs.SelectedIndexChanged += Tabs_SeleccionCambio;
        }

        /// <summary>
        /// Cuando cambia la colección de pestañas (agregar/quitar),
        /// desacopla-actualiza-reacopla el Drawer y normaliza el índice.
        /// </summary>
        private void Tabs_ColeccionCambio(object? sender, ControlEventArgs e)
        {
            ComenzarActualizacionSeguraDelDrawer();

            if (tabs!.TabPages.Count == 0)
            {
                tabs.SelectedIndex = -1;
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            if (tabs.SelectedIndex < 0) tabs.SelectedIndex = 0;
            if (tabs.SelectedIndex >= tabs.TabPages.Count)
                tabs.SelectedIndex = tabs.TabPages.Count - 1;

            FinalizarActualizacionSeguraDelDrawer();
        }

        /// <summary>
        /// Cuando cambia la pestaña seleccionada, forzamos repintado seguro del Drawer.
        /// </summary>
        private void Tabs_SeleccionCambio(object? sender, EventArgs e)
        {
            FinalizarActualizacionSeguraDelDrawer();
        }



        /// <summary>
        /// Mantiene el Drawer alineado con el TabControl:
        /// - Enlaza BaseTabControl
        /// - Normaliza tabs.SelectedIndex
        /// - Refresca el Drawer
        /// </summary>
        private void SincronizarDrawerConTabs()
        {
            if (DRW_Menu is null || tabs is null) return;

            // Asegurar el enlace (si no lo seteaste en el Designer)
            if (DRW_Menu.BaseTabControl != tabs)
                DRW_Menu.BaseTabControl = tabs;

            // Si no hay páginas: oculto Drawer y dejo el TabControl "sin selección"
            if (tabs.TabPages.Count == 0)
            {
                tabs.SelectedIndex = -1;
                DRW_Menu.IsOpen = false;
                DRW_Menu.Visible = false;
                DRW_Menu.Dock = DockStyle.None;
                DRW_Menu.Invalidate();
                return;
            }

            // Clamp del índice seleccionado del TabControl
            if (tabs.SelectedIndex < 0)
                tabs.SelectedIndex = 0;
            if (tabs.SelectedIndex >= tabs.TabPages.Count)
                tabs.SelectedIndex = tabs.TabPages.Count - 1;

            // Refrescar Drawer (re-pinta con el índice válido)
            DRW_Menu.Invalidate();
            DRW_Menu.Refresh();
        }

        /// <summary>
        /// Desacopla el Drawer del TabControl y lo deja oculto/sin dock
        /// para evitar que su AnimationManager dispare ticks mientras cambiamos tabs.
        /// </summary>
        private void ComenzarActualizacionSeguraDelDrawer()
        {
            if (DRW_Menu is null) return;

            DRW_Menu.BaseTabControl = null;   // desacoplar
            DRW_Menu.IsOpen = false;
            DRW_Menu.Visible = false;
            DRW_Menu.Dock = DockStyle.None;

            DRW_Menu.SuspendLayout();
            tabs?.SuspendLayout();
        }

        /// <summary>
        /// Reacopla el Drawer al TabControl, normaliza SelectedIndex
        /// y refresca el Drawer con estado consistente.
        /// </summary>
        private void FinalizarActualizacionSeguraDelDrawer()
        {
            if (tabs is null || DRW_Menu is null) return;

            DRW_Menu.BaseTabControl = tabs;

            if (tabs.TabPages.Count == 0)
            {
                tabs.SelectedIndex = -1;
            }
            else
            {
                if (tabs.SelectedIndex < 0) tabs.SelectedIndex = 0;
                if (tabs.SelectedIndex >= tabs.TabPages.Count)
                    tabs.SelectedIndex = tabs.TabPages.Count - 1;
            }

            tabs.ResumeLayout(performLayout: false);
            DRW_Menu.ResumeLayout(performLayout: false);
            DRW_Menu.Invalidate();
            DRW_Menu.Refresh();
        }

        /// <summary>
        /// Aplica la regla de negocio: qué tabs ve cada rol.
        /// </summary>
        private void AplicarReglasDeRol()
        {
            if (tabs is null || _todasLasTabs.Count == 0) return;

            // Restaurar todas antes de filtrar (importante si cambiás de usuario sin cerrar la app)
            ComenzarActualizacionSeguraDelDrawer();
            RestaurarTodasLasTabs(coreOnly: true);

            int rol = _sesion?.Usuario?.IdRol ?? 0;

            if (rol == Roles.Admin)
            {
                // Admin ve TODO: no hacemos nada más.
                // (Cuando implementes Config, Admin la verá también).
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            if (rol == Roles.Estilista)
            {
                // Estilista: sólo PatitaPelu
                QuitarTodosMenos(_tabPatitaPelu, coreOnly: true);
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            if (rol == Roles.Vendedor)
            {
                // Vendedor: sólo PatitaShop
                QuitarTodosMenos(_tabPatitaShop, coreOnly: true);
                FinalizarActualizacionSeguraDelDrawer();
                return;
            }

            // Rol desconocido: por seguridad, no mostrar nada (o mostrar lo mínimo).
            QuitarTodosMenos(null, coreOnly: true);
            FinalizarActualizacionSeguraDelDrawer();
        }

        /// <summary>
        /// Quita del TabControl todas las tabs excepto la permitida. Si la permitida es null, quita todas.
        /// </summary>
        private void QuitarTodosMenos(TabPage? tabPermitida, bool coreOnly = false)
        {
            foreach (var tp in _todasLasTabs)
            {
                if (tp != tabPermitida && tabs.TabPages.Contains(tp))
                    tabs.TabPages.Remove(tp);
            }

            if (tabPermitida is not null && !tabs.TabPages.Contains(tabPermitida))
                tabs.TabPages.Add(tabPermitida);

            if (tabPermitida is not null)
                tabs.SelectedTab = tabPermitida;

            if (!coreOnly) FinalizarActualizacionSeguraDelDrawer();
        }

        /// <summary>
        /// Vuelve a poner todas las TabPage en el orden original.
        /// </summary>
        private void RestaurarTodasLasTabs(bool coreOnly = false)
        {
            tabs.TabPages.Clear();
            tabs.TabPages.AddRange(_todasLasTabs.ToArray());

            if (!coreOnly) FinalizarActualizacionSeguraDelDrawer();
        }
    }
}
