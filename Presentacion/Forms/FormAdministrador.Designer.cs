namespace PatitaSystem.Presentacion.Forms
{
    partial class FormAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TABS_MenuAdmin = new MaterialSkin.Controls.MaterialTabControl();
            TAB_Usuario = new TabPage();
            PNL_UsuarioBotones = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            BTN_CrearUsuario = new MaterialSkin.Controls.MaterialButton();
            BTN_ModificarUsuario = new MaterialSkin.Controls.MaterialButton();
            BTN_EliminarUsuario = new MaterialSkin.Controls.MaterialButton();
            PNL_ListaUsuario = new Panel();
            PNL_BuscarUsuario = new Panel();
            LAYPanel_BuscarUsuario = new TableLayoutPanel();
            TBLAY_PanelLimpiar = new TableLayoutPanel();
            BTN_LimpiarBusqueda = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            TXT_BuscarUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            PIC_Buscador = new PictureBox();
            LIS_Usuario = new MaterialSkin.Controls.MaterialListView();
            TAB_Turno = new TabPage();
            PNL_RootTurnos = new Panel();
            PNL_TurnoCuerpo = new Panel();
            PNL_TurnoLista = new Panel();
            LISTV_ListaTurnos = new MaterialSkin.Controls.MaterialListView();
            PNL_TurnoBotones = new Panel();
            TLP_TurnosBotones = new TableLayoutPanel();
            BTN_AsignarTurno = new MaterialSkin.Controls.MaterialButton();
            BTN_ModificarTurno = new MaterialSkin.Controls.MaterialButton();
            BTN_EliminarTurno = new MaterialSkin.Controls.MaterialButton();
            PNL_TunosCabezera = new Panel();
            PNL_BuscarTurno = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            LBL_BuscarTurno = new MaterialSkin.Controls.MaterialLabel();
            PNL_Calendar = new Panel();
            CANDELAR_Turno = new MonthCalendar();
            TAB_Producto = new TabPage();
            PNL_ProductoContenido = new Panel();
            PNL_ProductoBotones = new Panel();
            TLP_ProductoBotones = new TableLayoutPanel();
            BTN_EliminarProducto = new MaterialSkin.Controls.MaterialButton();
            BTN_ModificarProducto = new MaterialSkin.Controls.MaterialButton();
            BTN_AgregarProducto = new MaterialSkin.Controls.MaterialButton();
            PNL_ProductoLista = new Panel();
            LIST_Producto = new MaterialSkin.Controls.MaterialListView();
            PNL_ProductoCabezera = new Panel();
            TLP_ProductoBuscador = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            BTN_ProductoLimpiar = new MaterialSkin.Controls.MaterialFloatingActionButton();
            LBL_ProductoLimpiar = new MaterialSkin.Controls.MaterialLabel();
            TXT_ProductoBuscar = new MaterialSkin.Controls.MaterialTextBox2();
            PIC_ProductoBuscar = new PictureBox();
            TAB_Mascota = new TabPage();
            TAB_Reporte = new TabPage();
            drawerMenu = new MaterialSkin.Controls.MaterialDrawer();
            PIC_Logo = new PictureBox();
            PNL_Root = new Panel();
            PNL_Contenido = new Panel();
            PNL_DrawerHost = new Panel();
            TABS_MenuAdmin.SuspendLayout();
            TAB_Usuario.SuspendLayout();
            PNL_UsuarioBotones.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            PNL_ListaUsuario.SuspendLayout();
            PNL_BuscarUsuario.SuspendLayout();
            LAYPanel_BuscarUsuario.SuspendLayout();
            TBLAY_PanelLimpiar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_Buscador).BeginInit();
            TAB_Turno.SuspendLayout();
            PNL_RootTurnos.SuspendLayout();
            PNL_TurnoCuerpo.SuspendLayout();
            PNL_TurnoLista.SuspendLayout();
            PNL_TurnoBotones.SuspendLayout();
            TLP_TurnosBotones.SuspendLayout();
            PNL_TunosCabezera.SuspendLayout();
            PNL_BuscarTurno.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            PNL_Calendar.SuspendLayout();
            TAB_Producto.SuspendLayout();
            PNL_ProductoContenido.SuspendLayout();
            PNL_ProductoBotones.SuspendLayout();
            TLP_ProductoBotones.SuspendLayout();
            PNL_ProductoLista.SuspendLayout();
            PNL_ProductoCabezera.SuspendLayout();
            TLP_ProductoBuscador.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_ProductoBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PIC_Logo).BeginInit();
            PNL_Root.SuspendLayout();
            PNL_Contenido.SuspendLayout();
            PNL_DrawerHost.SuspendLayout();
            SuspendLayout();
            // 
            // TABS_MenuAdmin
            // 
            TABS_MenuAdmin.Controls.Add(TAB_Usuario);
            TABS_MenuAdmin.Controls.Add(TAB_Turno);
            TABS_MenuAdmin.Controls.Add(TAB_Producto);
            TABS_MenuAdmin.Controls.Add(TAB_Mascota);
            TABS_MenuAdmin.Controls.Add(TAB_Reporte);
            TABS_MenuAdmin.Depth = 0;
            TABS_MenuAdmin.Dock = DockStyle.Fill;
            TABS_MenuAdmin.Location = new Point(0, 0);
            TABS_MenuAdmin.Margin = new Padding(3, 2, 3, 2);
            TABS_MenuAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            TABS_MenuAdmin.Multiline = true;
            TABS_MenuAdmin.Name = "TABS_MenuAdmin";
            TABS_MenuAdmin.SelectedIndex = 0;
            TABS_MenuAdmin.Size = new Size(792, 509);
            TABS_MenuAdmin.TabIndex = 2;
            // 
            // TAB_Usuario
            // 
            TAB_Usuario.BackColor = Color.DarkGray;
            TAB_Usuario.Controls.Add(PNL_UsuarioBotones);
            TAB_Usuario.Controls.Add(PNL_ListaUsuario);
            TAB_Usuario.Location = new Point(4, 24);
            TAB_Usuario.Margin = new Padding(3, 2, 3, 2);
            TAB_Usuario.Name = "TAB_Usuario";
            TAB_Usuario.Padding = new Padding(3, 2, 3, 2);
            TAB_Usuario.Size = new Size(784, 481);
            TAB_Usuario.TabIndex = 0;
            TAB_Usuario.Text = "Usuarios";
            // 
            // PNL_UsuarioBotones
            // 
            PNL_UsuarioBotones.Controls.Add(tableLayoutPanel1);
            PNL_UsuarioBotones.Dock = DockStyle.Fill;
            PNL_UsuarioBotones.Location = new Point(3, 285);
            PNL_UsuarioBotones.Name = "PNL_UsuarioBotones";
            PNL_UsuarioBotones.Size = new Size(778, 194);
            PNL_UsuarioBotones.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(BTN_CrearUsuario, 0, 0);
            tableLayoutPanel1.Controls.Add(BTN_ModificarUsuario, 1, 0);
            tableLayoutPanel1.Controls.Add(BTN_EliminarUsuario, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(778, 87);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // BTN_CrearUsuario
            // 
            BTN_CrearUsuario.Anchor = AnchorStyles.None;
            BTN_CrearUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_CrearUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_CrearUsuario.Depth = 0;
            BTN_CrearUsuario.HighEmphasis = true;
            BTN_CrearUsuario.Icon = null;
            BTN_CrearUsuario.Location = new Point(96, 25);
            BTN_CrearUsuario.Margin = new Padding(4);
            BTN_CrearUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_CrearUsuario.Name = "BTN_CrearUsuario";
            BTN_CrearUsuario.NoAccentTextColor = Color.Empty;
            BTN_CrearUsuario.Size = new Size(67, 36);
            BTN_CrearUsuario.TabIndex = 2;
            BTN_CrearUsuario.Text = "Crear";
            BTN_CrearUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_CrearUsuario.UseAccentColor = false;
            BTN_CrearUsuario.UseVisualStyleBackColor = true;
            BTN_CrearUsuario.Click += BTN_Crear_Click;
            // 
            // BTN_ModificarUsuario
            // 
            BTN_ModificarUsuario.Anchor = AnchorStyles.None;
            BTN_ModificarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_ModificarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_ModificarUsuario.Depth = 0;
            BTN_ModificarUsuario.HighEmphasis = true;
            BTN_ModificarUsuario.Icon = null;
            BTN_ModificarUsuario.Location = new Point(339, 25);
            BTN_ModificarUsuario.Margin = new Padding(4);
            BTN_ModificarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_ModificarUsuario.Name = "BTN_ModificarUsuario";
            BTN_ModificarUsuario.NoAccentTextColor = Color.Empty;
            BTN_ModificarUsuario.Size = new Size(99, 36);
            BTN_ModificarUsuario.TabIndex = 1;
            BTN_ModificarUsuario.Text = "Modificar";
            BTN_ModificarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_ModificarUsuario.UseAccentColor = false;
            BTN_ModificarUsuario.UseVisualStyleBackColor = true;
            BTN_ModificarUsuario.Click += BTN_Modificar_Click;
            // 
            // BTN_EliminarUsuario
            // 
            BTN_EliminarUsuario.Anchor = AnchorStyles.None;
            BTN_EliminarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_EliminarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_EliminarUsuario.Depth = 0;
            BTN_EliminarUsuario.ForeColor = SystemColors.ControlDarkDark;
            BTN_EliminarUsuario.HighEmphasis = true;
            BTN_EliminarUsuario.Icon = null;
            BTN_EliminarUsuario.Location = new Point(604, 25);
            BTN_EliminarUsuario.Margin = new Padding(4);
            BTN_EliminarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_EliminarUsuario.Name = "BTN_EliminarUsuario";
            BTN_EliminarUsuario.NoAccentTextColor = Color.Empty;
            BTN_EliminarUsuario.Size = new Size(88, 36);
            BTN_EliminarUsuario.TabIndex = 0;
            BTN_EliminarUsuario.Text = "ELIMINAR";
            BTN_EliminarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_EliminarUsuario.UseAccentColor = false;
            BTN_EliminarUsuario.UseVisualStyleBackColor = true;
            BTN_EliminarUsuario.Click += BTN_Eliminar_Click;
            // 
            // PNL_ListaUsuario
            // 
            PNL_ListaUsuario.Controls.Add(PNL_BuscarUsuario);
            PNL_ListaUsuario.Controls.Add(LIS_Usuario);
            PNL_ListaUsuario.Dock = DockStyle.Top;
            PNL_ListaUsuario.Location = new Point(3, 2);
            PNL_ListaUsuario.Name = "PNL_ListaUsuario";
            PNL_ListaUsuario.Size = new Size(778, 283);
            PNL_ListaUsuario.TabIndex = 4;
            // 
            // PNL_BuscarUsuario
            // 
            PNL_BuscarUsuario.Controls.Add(LAYPanel_BuscarUsuario);
            PNL_BuscarUsuario.Dock = DockStyle.Top;
            PNL_BuscarUsuario.Location = new Point(0, 0);
            PNL_BuscarUsuario.Name = "PNL_BuscarUsuario";
            PNL_BuscarUsuario.Size = new Size(778, 76);
            PNL_BuscarUsuario.TabIndex = 4;
            // 
            // LAYPanel_BuscarUsuario
            // 
            LAYPanel_BuscarUsuario.ColumnCount = 5;
            LAYPanel_BuscarUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.94049F));
            LAYPanel_BuscarUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.240717F));
            LAYPanel_BuscarUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.67998F));
            LAYPanel_BuscarUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.370816F));
            LAYPanel_BuscarUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.2463188F));
            LAYPanel_BuscarUsuario.Controls.Add(TBLAY_PanelLimpiar, 3, 0);
            LAYPanel_BuscarUsuario.Controls.Add(TXT_BuscarUsuario, 2, 0);
            LAYPanel_BuscarUsuario.Controls.Add(PIC_Buscador, 1, 0);
            LAYPanel_BuscarUsuario.Dock = DockStyle.Top;
            LAYPanel_BuscarUsuario.Location = new Point(0, 0);
            LAYPanel_BuscarUsuario.Name = "LAYPanel_BuscarUsuario";
            LAYPanel_BuscarUsuario.RowCount = 1;
            LAYPanel_BuscarUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LAYPanel_BuscarUsuario.Size = new Size(778, 76);
            LAYPanel_BuscarUsuario.TabIndex = 0;
            // 
            // TBLAY_PanelLimpiar
            // 
            TBLAY_PanelLimpiar.ColumnCount = 1;
            TBLAY_PanelLimpiar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TBLAY_PanelLimpiar.Controls.Add(BTN_LimpiarBusqueda, 0, 0);
            TBLAY_PanelLimpiar.Controls.Add(materialLabel1, 0, 1);
            TBLAY_PanelLimpiar.Dock = DockStyle.Fill;
            TBLAY_PanelLimpiar.Location = new Point(488, 3);
            TBLAY_PanelLimpiar.Name = "TBLAY_PanelLimpiar";
            TBLAY_PanelLimpiar.RowCount = 2;
            TBLAY_PanelLimpiar.RowStyles.Add(new RowStyle(SizeType.Percent, 67.14286F));
            TBLAY_PanelLimpiar.RowStyles.Add(new RowStyle(SizeType.Percent, 32.8571434F));
            TBLAY_PanelLimpiar.Size = new Size(66, 70);
            TBLAY_PanelLimpiar.TabIndex = 6;
            // 
            // BTN_LimpiarBusqueda
            // 
            BTN_LimpiarBusqueda.AutoSize = true;
            BTN_LimpiarBusqueda.Depth = 0;
            BTN_LimpiarBusqueda.Dock = DockStyle.Fill;
            BTN_LimpiarBusqueda.Icon = Properties.Resources.cruz;
            BTN_LimpiarBusqueda.Location = new Point(3, 3);
            BTN_LimpiarBusqueda.Mini = true;
            BTN_LimpiarBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_LimpiarBusqueda.Name = "BTN_LimpiarBusqueda";
            BTN_LimpiarBusqueda.Padding = new Padding(0, 12, 0, 0);
            BTN_LimpiarBusqueda.Size = new Size(60, 41);
            BTN_LimpiarBusqueda.TabIndex = 2;
            BTN_LimpiarBusqueda.Text = "Limpiar";
            BTN_LimpiarBusqueda.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Fill;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(3, 47);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(60, 23);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Limpiar";
            materialLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // TXT_BuscarUsuario
            // 
            TXT_BuscarUsuario.AnimateReadOnly = false;
            TXT_BuscarUsuario.BackgroundImageLayout = ImageLayout.None;
            TXT_BuscarUsuario.CharacterCasing = CharacterCasing.Normal;
            TXT_BuscarUsuario.Depth = 0;
            TXT_BuscarUsuario.Dock = DockStyle.Fill;
            TXT_BuscarUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_BuscarUsuario.HelperText = "Buscar";
            TXT_BuscarUsuario.HideSelection = true;
            TXT_BuscarUsuario.LeadingIcon = null;
            TXT_BuscarUsuario.Location = new Point(228, 3);
            TXT_BuscarUsuario.MaxLength = 32767;
            TXT_BuscarUsuario.MouseState = MaterialSkin.MouseState.OUT;
            TXT_BuscarUsuario.Name = "TXT_BuscarUsuario";
            TXT_BuscarUsuario.PasswordChar = '\0';
            TXT_BuscarUsuario.PrefixSuffixText = null;
            TXT_BuscarUsuario.ReadOnly = false;
            TXT_BuscarUsuario.RightToLeft = RightToLeft.No;
            TXT_BuscarUsuario.SelectedText = "";
            TXT_BuscarUsuario.SelectionLength = 0;
            TXT_BuscarUsuario.SelectionStart = 0;
            TXT_BuscarUsuario.ShortcutsEnabled = true;
            TXT_BuscarUsuario.ShowAssistiveText = true;
            TXT_BuscarUsuario.Size = new Size(254, 64);
            TXT_BuscarUsuario.TabIndex = 0;
            TXT_BuscarUsuario.TabStop = false;
            TXT_BuscarUsuario.TextAlign = HorizontalAlignment.Left;
            TXT_BuscarUsuario.TrailingIcon = null;
            TXT_BuscarUsuario.UseSystemPasswordChar = false;
            // 
            // PIC_Buscador
            // 
            PIC_Buscador.BackgroundImageLayout = ImageLayout.Center;
            PIC_Buscador.Dock = DockStyle.Top;
            PIC_Buscador.ErrorImage = null;
            PIC_Buscador.Image = Properties.Resources.buscadorMiembro;
            PIC_Buscador.Location = new Point(157, 3);
            PIC_Buscador.Name = "PIC_Buscador";
            PIC_Buscador.Size = new Size(65, 49);
            PIC_Buscador.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_Buscador.TabIndex = 1;
            PIC_Buscador.TabStop = false;
            // 
            // LIS_Usuario
            // 
            LIS_Usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LIS_Usuario.AutoSizeTable = false;
            LIS_Usuario.BackColor = Color.FromArgb(255, 255, 255);
            LIS_Usuario.BorderStyle = BorderStyle.None;
            LIS_Usuario.Depth = 0;
            LIS_Usuario.FullRowSelect = true;
            LIS_Usuario.Location = new Point(0, 81);
            LIS_Usuario.Margin = new Padding(3, 2, 3, 2);
            LIS_Usuario.MinimumSize = new Size(175, 75);
            LIS_Usuario.MouseLocation = new Point(-1, -1);
            LIS_Usuario.MouseState = MaterialSkin.MouseState.OUT;
            LIS_Usuario.Name = "LIS_Usuario";
            LIS_Usuario.OwnerDraw = true;
            LIS_Usuario.Size = new Size(778, 202);
            LIS_Usuario.TabIndex = 3;
            LIS_Usuario.UseCompatibleStateImageBehavior = false;
            LIS_Usuario.View = View.Details;
            // 
            // TAB_Turno
            // 
            TAB_Turno.BackColor = Color.RosyBrown;
            TAB_Turno.Controls.Add(PNL_RootTurnos);
            TAB_Turno.Location = new Point(4, 24);
            TAB_Turno.Margin = new Padding(3, 2, 3, 2);
            TAB_Turno.Name = "TAB_Turno";
            TAB_Turno.Padding = new Padding(3, 2, 3, 2);
            TAB_Turno.Size = new Size(784, 481);
            TAB_Turno.TabIndex = 1;
            TAB_Turno.Text = "Turnos";
            // 
            // PNL_RootTurnos
            // 
            PNL_RootTurnos.Controls.Add(PNL_TurnoCuerpo);
            PNL_RootTurnos.Controls.Add(PNL_TunosCabezera);
            PNL_RootTurnos.Dock = DockStyle.Fill;
            PNL_RootTurnos.Location = new Point(3, 2);
            PNL_RootTurnos.Name = "PNL_RootTurnos";
            PNL_RootTurnos.Size = new Size(778, 477);
            PNL_RootTurnos.TabIndex = 5;
            // 
            // PNL_TurnoCuerpo
            // 
            PNL_TurnoCuerpo.Controls.Add(PNL_TurnoLista);
            PNL_TurnoCuerpo.Controls.Add(PNL_TurnoBotones);
            PNL_TurnoCuerpo.Dock = DockStyle.Fill;
            PNL_TurnoCuerpo.Location = new Point(301, 0);
            PNL_TurnoCuerpo.Name = "PNL_TurnoCuerpo";
            PNL_TurnoCuerpo.Size = new Size(477, 477);
            PNL_TurnoCuerpo.TabIndex = 6;
            // 
            // PNL_TurnoLista
            // 
            PNL_TurnoLista.Controls.Add(LISTV_ListaTurnos);
            PNL_TurnoLista.Dock = DockStyle.Fill;
            PNL_TurnoLista.Location = new Point(0, 0);
            PNL_TurnoLista.Name = "PNL_TurnoLista";
            PNL_TurnoLista.Size = new Size(477, 305);
            PNL_TurnoLista.TabIndex = 2;
            // 
            // LISTV_ListaTurnos
            // 
            LISTV_ListaTurnos.AutoSizeTable = false;
            LISTV_ListaTurnos.BackColor = Color.FromArgb(255, 255, 255);
            LISTV_ListaTurnos.BorderStyle = BorderStyle.None;
            LISTV_ListaTurnos.Depth = 0;
            LISTV_ListaTurnos.Dock = DockStyle.Fill;
            LISTV_ListaTurnos.FullRowSelect = true;
            LISTV_ListaTurnos.Location = new Point(0, 0);
            LISTV_ListaTurnos.Margin = new Padding(3, 2, 3, 2);
            LISTV_ListaTurnos.MinimumSize = new Size(175, 75);
            LISTV_ListaTurnos.MouseLocation = new Point(-1, -1);
            LISTV_ListaTurnos.MouseState = MaterialSkin.MouseState.OUT;
            LISTV_ListaTurnos.Name = "LISTV_ListaTurnos";
            LISTV_ListaTurnos.OwnerDraw = true;
            LISTV_ListaTurnos.Size = new Size(477, 305);
            LISTV_ListaTurnos.TabIndex = 0;
            LISTV_ListaTurnos.UseCompatibleStateImageBehavior = false;
            LISTV_ListaTurnos.View = View.Details;
            // 
            // PNL_TurnoBotones
            // 
            PNL_TurnoBotones.Controls.Add(TLP_TurnosBotones);
            PNL_TurnoBotones.Dock = DockStyle.Bottom;
            PNL_TurnoBotones.Location = new Point(0, 305);
            PNL_TurnoBotones.Name = "PNL_TurnoBotones";
            PNL_TurnoBotones.Size = new Size(477, 172);
            PNL_TurnoBotones.TabIndex = 1;
            // 
            // TLP_TurnosBotones
            // 
            TLP_TurnosBotones.ColumnCount = 3;
            TLP_TurnosBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLP_TurnosBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLP_TurnosBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLP_TurnosBotones.Controls.Add(BTN_AsignarTurno, 0, 0);
            TLP_TurnosBotones.Controls.Add(BTN_ModificarTurno, 2, 0);
            TLP_TurnosBotones.Controls.Add(BTN_EliminarTurno, 1, 0);
            TLP_TurnosBotones.Dock = DockStyle.Top;
            TLP_TurnosBotones.Location = new Point(0, 0);
            TLP_TurnosBotones.Name = "TLP_TurnosBotones";
            TLP_TurnosBotones.RowCount = 1;
            TLP_TurnosBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_TurnosBotones.Size = new Size(477, 78);
            TLP_TurnosBotones.TabIndex = 0;
            // 
            // BTN_AsignarTurno
            // 
            BTN_AsignarTurno.Anchor = AnchorStyles.None;
            BTN_AsignarTurno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_AsignarTurno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_AsignarTurno.Depth = 0;
            BTN_AsignarTurno.HighEmphasis = true;
            BTN_AsignarTurno.Icon = null;
            BTN_AsignarTurno.Location = new Point(11, 21);
            BTN_AsignarTurno.Margin = new Padding(4);
            BTN_AsignarTurno.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_AsignarTurno.Name = "BTN_AsignarTurno";
            BTN_AsignarTurno.NoAccentTextColor = Color.Empty;
            BTN_AsignarTurno.Size = new Size(135, 36);
            BTN_AsignarTurno.TabIndex = 2;
            BTN_AsignarTurno.Text = "Asignar Turno";
            BTN_AsignarTurno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_AsignarTurno.UseAccentColor = false;
            BTN_AsignarTurno.UseVisualStyleBackColor = true;
            // 
            // BTN_ModificarTurno
            // 
            BTN_ModificarTurno.Anchor = AnchorStyles.None;
            BTN_ModificarTurno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_ModificarTurno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_ModificarTurno.Depth = 0;
            BTN_ModificarTurno.HighEmphasis = true;
            BTN_ModificarTurno.Icon = null;
            BTN_ModificarTurno.Location = new Point(321, 21);
            BTN_ModificarTurno.Margin = new Padding(4);
            BTN_ModificarTurno.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_ModificarTurno.Name = "BTN_ModificarTurno";
            BTN_ModificarTurno.NoAccentTextColor = Color.Empty;
            BTN_ModificarTurno.Size = new Size(151, 36);
            BTN_ModificarTurno.TabIndex = 4;
            BTN_ModificarTurno.Text = "Modificar turno";
            BTN_ModificarTurno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_ModificarTurno.UseAccentColor = false;
            BTN_ModificarTurno.UseVisualStyleBackColor = true;
            // 
            // BTN_EliminarTurno
            // 
            BTN_EliminarTurno.Anchor = AnchorStyles.None;
            BTN_EliminarTurno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_EliminarTurno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_EliminarTurno.Depth = 0;
            BTN_EliminarTurno.HighEmphasis = true;
            BTN_EliminarTurno.Icon = null;
            BTN_EliminarTurno.Location = new Point(172, 21);
            BTN_EliminarTurno.Margin = new Padding(4);
            BTN_EliminarTurno.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_EliminarTurno.Name = "BTN_EliminarTurno";
            BTN_EliminarTurno.NoAccentTextColor = Color.Empty;
            BTN_EliminarTurno.Size = new Size(130, 36);
            BTN_EliminarTurno.TabIndex = 3;
            BTN_EliminarTurno.Text = "Elimiar Turno";
            BTN_EliminarTurno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_EliminarTurno.UseAccentColor = false;
            BTN_EliminarTurno.UseVisualStyleBackColor = true;
            // 
            // PNL_TunosCabezera
            // 
            PNL_TunosCabezera.Controls.Add(PNL_BuscarTurno);
            PNL_TunosCabezera.Dock = DockStyle.Left;
            PNL_TunosCabezera.Location = new Point(0, 0);
            PNL_TunosCabezera.Name = "PNL_TunosCabezera";
            PNL_TunosCabezera.Size = new Size(301, 477);
            PNL_TunosCabezera.TabIndex = 5;
            // 
            // PNL_BuscarTurno
            // 
            PNL_BuscarTurno.Controls.Add(tableLayoutPanel2);
            PNL_BuscarTurno.Controls.Add(PNL_Calendar);
            PNL_BuscarTurno.Dock = DockStyle.Top;
            PNL_BuscarTurno.Location = new Point(0, 0);
            PNL_BuscarTurno.Name = "PNL_BuscarTurno";
            PNL_BuscarTurno.Size = new Size(301, 229);
            PNL_BuscarTurno.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.6159687F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.8505F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel2.Controls.Add(LBL_BuscarTurno, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(301, 34);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // LBL_BuscarTurno
            // 
            LBL_BuscarTurno.AutoSize = true;
            LBL_BuscarTurno.Depth = 0;
            LBL_BuscarTurno.Dock = DockStyle.Fill;
            LBL_BuscarTurno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_BuscarTurno.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            LBL_BuscarTurno.Location = new Point(83, 0);
            LBL_BuscarTurno.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_BuscarTurno.Name = "LBL_BuscarTurno";
            LBL_BuscarTurno.Size = new Size(128, 34);
            LBL_BuscarTurno.TabIndex = 3;
            LBL_BuscarTurno.Text = "Buscar Turno:";
            LBL_BuscarTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PNL_Calendar
            // 
            PNL_Calendar.Controls.Add(CANDELAR_Turno);
            PNL_Calendar.Dock = DockStyle.Bottom;
            PNL_Calendar.Location = new Point(0, 34);
            PNL_Calendar.Name = "PNL_Calendar";
            PNL_Calendar.Size = new Size(301, 195);
            PNL_Calendar.TabIndex = 2;
            // 
            // CANDELAR_Turno
            // 
            CANDELAR_Turno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CANDELAR_Turno.Location = new Point(27, 20);
            CANDELAR_Turno.Margin = new Padding(8, 7, 8, 7);
            CANDELAR_Turno.Name = "CANDELAR_Turno";
            CANDELAR_Turno.RightToLeft = RightToLeft.Yes;
            CANDELAR_Turno.RightToLeftLayout = true;
            CANDELAR_Turno.ShowTodayCircle = false;
            CANDELAR_Turno.TabIndex = 1;
            // 
            // TAB_Producto
            // 
            TAB_Producto.Controls.Add(PNL_ProductoContenido);
            TAB_Producto.Controls.Add(PNL_ProductoCabezera);
            TAB_Producto.Location = new Point(4, 24);
            TAB_Producto.Margin = new Padding(3, 2, 3, 2);
            TAB_Producto.Name = "TAB_Producto";
            TAB_Producto.Padding = new Padding(3, 2, 3, 2);
            TAB_Producto.Size = new Size(784, 481);
            TAB_Producto.TabIndex = 2;
            TAB_Producto.Text = "Productos";
            TAB_Producto.UseVisualStyleBackColor = true;
            // 
            // PNL_ProductoContenido
            // 
            PNL_ProductoContenido.Controls.Add(PNL_ProductoBotones);
            PNL_ProductoContenido.Controls.Add(PNL_ProductoLista);
            PNL_ProductoContenido.Dock = DockStyle.Fill;
            PNL_ProductoContenido.Location = new Point(3, 105);
            PNL_ProductoContenido.Margin = new Padding(7);
            PNL_ProductoContenido.Name = "PNL_ProductoContenido";
            PNL_ProductoContenido.Size = new Size(778, 374);
            PNL_ProductoContenido.TabIndex = 5;
            // 
            // PNL_ProductoBotones
            // 
            PNL_ProductoBotones.Controls.Add(TLP_ProductoBotones);
            PNL_ProductoBotones.Dock = DockStyle.Top;
            PNL_ProductoBotones.Location = new Point(0, 185);
            PNL_ProductoBotones.Name = "PNL_ProductoBotones";
            PNL_ProductoBotones.Size = new Size(778, 69);
            PNL_ProductoBotones.TabIndex = 5;
            // 
            // TLP_ProductoBotones
            // 
            TLP_ProductoBotones.ColumnCount = 3;
            TLP_ProductoBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.77635F));
            TLP_ProductoBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.6760941F));
            TLP_ProductoBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLP_ProductoBotones.Controls.Add(BTN_EliminarProducto, 2, 0);
            TLP_ProductoBotones.Controls.Add(BTN_ModificarProducto, 1, 0);
            TLP_ProductoBotones.Controls.Add(BTN_AgregarProducto, 0, 0);
            TLP_ProductoBotones.Dock = DockStyle.Fill;
            TLP_ProductoBotones.Location = new Point(0, 0);
            TLP_ProductoBotones.Name = "TLP_ProductoBotones";
            TLP_ProductoBotones.RowCount = 1;
            TLP_ProductoBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_ProductoBotones.Size = new Size(778, 69);
            TLP_ProductoBotones.TabIndex = 0;
            // 
            // BTN_EliminarProducto
            // 
            BTN_EliminarProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTN_EliminarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_EliminarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_EliminarProducto.Depth = 0;
            BTN_EliminarProducto.HighEmphasis = true;
            BTN_EliminarProducto.Icon = null;
            BTN_EliminarProducto.Location = new Point(532, 16);
            BTN_EliminarProducto.Margin = new Padding(15);
            BTN_EliminarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_EliminarProducto.Name = "BTN_EliminarProducto";
            BTN_EliminarProducto.NoAccentTextColor = Color.Empty;
            BTN_EliminarProducto.Size = new Size(231, 36);
            BTN_EliminarProducto.TabIndex = 1;
            BTN_EliminarProducto.Text = "Eliminar producto";
            BTN_EliminarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_EliminarProducto.UseAccentColor = false;
            BTN_EliminarProducto.UseVisualStyleBackColor = true;
            BTN_EliminarProducto.Click += materialButton7_Click;
            // 
            // BTN_ModificarProducto
            // 
            BTN_ModificarProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTN_ModificarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_ModificarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_ModificarProducto.Depth = 0;
            BTN_ModificarProducto.HighEmphasis = true;
            BTN_ModificarProducto.Icon = null;
            BTN_ModificarProducto.Location = new Point(270, 16);
            BTN_ModificarProducto.Margin = new Padding(15);
            BTN_ModificarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_ModificarProducto.Name = "BTN_ModificarProducto";
            BTN_ModificarProducto.NoAccentTextColor = Color.Empty;
            BTN_ModificarProducto.Size = new Size(232, 36);
            BTN_ModificarProducto.TabIndex = 3;
            BTN_ModificarProducto.Text = "Modificar Producto";
            BTN_ModificarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_ModificarProducto.UseAccentColor = false;
            BTN_ModificarProducto.UseVisualStyleBackColor = true;
            BTN_ModificarProducto.Click += materialButton9_Click;
            // 
            // BTN_AgregarProducto
            // 
            BTN_AgregarProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTN_AgregarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_AgregarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_AgregarProducto.Depth = 0;
            BTN_AgregarProducto.HighEmphasis = true;
            BTN_AgregarProducto.Icon = null;
            BTN_AgregarProducto.Location = new Point(15, 16);
            BTN_AgregarProducto.Margin = new Padding(15);
            BTN_AgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_AgregarProducto.Name = "BTN_AgregarProducto";
            BTN_AgregarProducto.NoAccentTextColor = Color.Empty;
            BTN_AgregarProducto.Size = new Size(225, 36);
            BTN_AgregarProducto.TabIndex = 2;
            BTN_AgregarProducto.Text = "Agregar Producto";
            BTN_AgregarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_AgregarProducto.UseAccentColor = false;
            BTN_AgregarProducto.UseVisualStyleBackColor = true;
            // 
            // PNL_ProductoLista
            // 
            PNL_ProductoLista.Controls.Add(LIST_Producto);
            PNL_ProductoLista.Dock = DockStyle.Top;
            PNL_ProductoLista.Location = new Point(0, 0);
            PNL_ProductoLista.Name = "PNL_ProductoLista";
            PNL_ProductoLista.Size = new Size(778, 185);
            PNL_ProductoLista.TabIndex = 4;
            // 
            // LIST_Producto
            // 
            LIST_Producto.AutoSizeTable = false;
            LIST_Producto.BackColor = Color.FromArgb(255, 255, 255);
            LIST_Producto.BorderStyle = BorderStyle.None;
            LIST_Producto.Depth = 0;
            LIST_Producto.Dock = DockStyle.Fill;
            LIST_Producto.FullRowSelect = true;
            LIST_Producto.Location = new Point(0, 0);
            LIST_Producto.Margin = new Padding(3, 2, 3, 2);
            LIST_Producto.MinimumSize = new Size(175, 75);
            LIST_Producto.MouseLocation = new Point(-1, -1);
            LIST_Producto.MouseState = MaterialSkin.MouseState.OUT;
            LIST_Producto.Name = "LIST_Producto";
            LIST_Producto.OwnerDraw = true;
            LIST_Producto.Size = new Size(778, 185);
            LIST_Producto.TabIndex = 0;
            LIST_Producto.UseCompatibleStateImageBehavior = false;
            LIST_Producto.View = View.Details;
            // 
            // PNL_ProductoCabezera
            // 
            PNL_ProductoCabezera.Controls.Add(TLP_ProductoBuscador);
            PNL_ProductoCabezera.Dock = DockStyle.Top;
            PNL_ProductoCabezera.Location = new Point(3, 2);
            PNL_ProductoCabezera.Name = "PNL_ProductoCabezera";
            PNL_ProductoCabezera.Size = new Size(778, 103);
            PNL_ProductoCabezera.TabIndex = 4;
            // 
            // TLP_ProductoBuscador
            // 
            TLP_ProductoBuscador.ColumnCount = 5;
            TLP_ProductoBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.85646F));
            TLP_ProductoBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.1435413F));
            TLP_ProductoBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 263F));
            TLP_ProductoBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            TLP_ProductoBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 222F));
            TLP_ProductoBuscador.Controls.Add(tableLayoutPanel3, 3, 0);
            TLP_ProductoBuscador.Controls.Add(TXT_ProductoBuscar, 2, 0);
            TLP_ProductoBuscador.Controls.Add(PIC_ProductoBuscar, 1, 0);
            TLP_ProductoBuscador.Dock = DockStyle.Fill;
            TLP_ProductoBuscador.Location = new Point(0, 0);
            TLP_ProductoBuscador.Name = "TLP_ProductoBuscador";
            TLP_ProductoBuscador.RowCount = 1;
            TLP_ProductoBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 74F));
            TLP_ProductoBuscador.Size = new Size(778, 103);
            TLP_ProductoBuscador.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(BTN_ProductoLimpiar, 0, 0);
            tableLayoutPanel3.Controls.Add(LBL_ProductoLimpiar, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(475, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel3.Size = new Size(77, 97);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // BTN_ProductoLimpiar
            // 
            BTN_ProductoLimpiar.Anchor = AnchorStyles.None;
            BTN_ProductoLimpiar.Depth = 0;
            BTN_ProductoLimpiar.Icon = Properties.Resources.cruz;
            BTN_ProductoLimpiar.Location = new Point(15, 5);
            BTN_ProductoLimpiar.Mini = true;
            BTN_ProductoLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_ProductoLimpiar.Name = "BTN_ProductoLimpiar";
            BTN_ProductoLimpiar.Size = new Size(46, 40);
            BTN_ProductoLimpiar.TabIndex = 6;
            BTN_ProductoLimpiar.UseVisualStyleBackColor = true;
            // 
            // LBL_ProductoLimpiar
            // 
            LBL_ProductoLimpiar.AutoSize = true;
            LBL_ProductoLimpiar.Depth = 0;
            LBL_ProductoLimpiar.Dock = DockStyle.Top;
            LBL_ProductoLimpiar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_ProductoLimpiar.Location = new Point(3, 50);
            LBL_ProductoLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_ProductoLimpiar.Name = "LBL_ProductoLimpiar";
            LBL_ProductoLimpiar.Size = new Size(71, 19);
            LBL_ProductoLimpiar.TabIndex = 7;
            LBL_ProductoLimpiar.Text = "Limpiar";
            // 
            // TXT_ProductoBuscar
            // 
            TXT_ProductoBuscar.AnimateReadOnly = false;
            TXT_ProductoBuscar.BackgroundImageLayout = ImageLayout.None;
            TXT_ProductoBuscar.CharacterCasing = CharacterCasing.Normal;
            TXT_ProductoBuscar.Depth = 0;
            TXT_ProductoBuscar.Dock = DockStyle.Fill;
            TXT_ProductoBuscar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_ProductoBuscar.HelperText = "Buscar";
            TXT_ProductoBuscar.HideSelection = true;
            TXT_ProductoBuscar.LeadingIcon = null;
            TXT_ProductoBuscar.Location = new Point(212, 3);
            TXT_ProductoBuscar.MaxLength = 32767;
            TXT_ProductoBuscar.MouseState = MaterialSkin.MouseState.OUT;
            TXT_ProductoBuscar.Name = "TXT_ProductoBuscar";
            TXT_ProductoBuscar.PasswordChar = '\0';
            TXT_ProductoBuscar.PrefixSuffixText = null;
            TXT_ProductoBuscar.ReadOnly = false;
            TXT_ProductoBuscar.RightToLeft = RightToLeft.No;
            TXT_ProductoBuscar.SelectedText = "";
            TXT_ProductoBuscar.SelectionLength = 0;
            TXT_ProductoBuscar.SelectionStart = 0;
            TXT_ProductoBuscar.ShortcutsEnabled = true;
            TXT_ProductoBuscar.ShowAssistiveText = true;
            TXT_ProductoBuscar.Size = new Size(257, 64);
            TXT_ProductoBuscar.TabIndex = 0;
            TXT_ProductoBuscar.TabStop = false;
            TXT_ProductoBuscar.TextAlign = HorizontalAlignment.Left;
            TXT_ProductoBuscar.TrailingIcon = null;
            TXT_ProductoBuscar.UseSystemPasswordChar = false;
            // 
            // PIC_ProductoBuscar
            // 
            PIC_ProductoBuscar.Dock = DockStyle.Top;
            PIC_ProductoBuscar.Image = Properties.Resources.buscador2;
            PIC_ProductoBuscar.Location = new Point(149, 3);
            PIC_ProductoBuscar.Name = "PIC_ProductoBuscar";
            PIC_ProductoBuscar.Size = new Size(57, 48);
            PIC_ProductoBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_ProductoBuscar.TabIndex = 1;
            PIC_ProductoBuscar.TabStop = false;
            // 
            // TAB_Mascota
            // 
            TAB_Mascota.Location = new Point(4, 24);
            TAB_Mascota.Margin = new Padding(3, 2, 3, 2);
            TAB_Mascota.Name = "TAB_Mascota";
            TAB_Mascota.Padding = new Padding(3, 2, 3, 2);
            TAB_Mascota.Size = new Size(784, 481);
            TAB_Mascota.TabIndex = 3;
            TAB_Mascota.Text = "Mascotas";
            TAB_Mascota.UseVisualStyleBackColor = true;
            // 
            // TAB_Reporte
            // 
            TAB_Reporte.Location = new Point(4, 24);
            TAB_Reporte.Margin = new Padding(3, 2, 3, 2);
            TAB_Reporte.Name = "TAB_Reporte";
            TAB_Reporte.Padding = new Padding(3, 2, 3, 2);
            TAB_Reporte.Size = new Size(784, 481);
            TAB_Reporte.TabIndex = 4;
            TAB_Reporte.Text = "Reportes";
            TAB_Reporte.UseVisualStyleBackColor = true;
            // 
            // drawerMenu
            // 
            drawerMenu.AutoHide = false;
            drawerMenu.AutoShow = false;
            drawerMenu.BackgroundWithAccent = false;
            drawerMenu.BaseTabControl = null;
            drawerMenu.Depth = 0;
            drawerMenu.Dock = DockStyle.Top;
            drawerMenu.HighlightWithAccent = true;
            drawerMenu.IndicatorWidth = 0;
            drawerMenu.IsOpen = true;
            drawerMenu.Location = new Point(0, 0);
            drawerMenu.Margin = new Padding(3, 2, 3, 2);
            drawerMenu.MouseState = MaterialSkin.MouseState.HOVER;
            drawerMenu.Name = "drawerMenu";
            drawerMenu.ShowIconsWhenHidden = false;
            drawerMenu.Size = new Size(200, 382);
            drawerMenu.TabIndex = 4;
            drawerMenu.Text = "materialDrawer1";
            drawerMenu.UseColors = false;
            // 
            // PIC_Logo
            // 
            PIC_Logo.Dock = DockStyle.Bottom;
            PIC_Logo.Image = Properties.Resources.logo2;
            PIC_Logo.Location = new Point(0, 398);
            PIC_Logo.Margin = new Padding(3, 2, 3, 2);
            PIC_Logo.Name = "PIC_Logo";
            PIC_Logo.Size = new Size(200, 111);
            PIC_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_Logo.TabIndex = 5;
            PIC_Logo.TabStop = false;
            // 
            // PNL_Root
            // 
            PNL_Root.Controls.Add(PNL_Contenido);
            PNL_Root.Controls.Add(PNL_DrawerHost);
            PNL_Root.Dock = DockStyle.Fill;
            PNL_Root.Location = new Point(3, 25);
            PNL_Root.Margin = new Padding(0);
            PNL_Root.Name = "PNL_Root";
            PNL_Root.Padding = new Padding(0, 20, 0, 0);
            PNL_Root.Size = new Size(992, 529);
            PNL_Root.TabIndex = 6;
            // 
            // PNL_Contenido
            // 
            PNL_Contenido.Controls.Add(TABS_MenuAdmin);
            PNL_Contenido.Dock = DockStyle.Fill;
            PNL_Contenido.Location = new Point(200, 20);
            PNL_Contenido.Name = "PNL_Contenido";
            PNL_Contenido.Size = new Size(792, 509);
            PNL_Contenido.TabIndex = 7;
            // 
            // PNL_DrawerHost
            // 
            PNL_DrawerHost.Controls.Add(drawerMenu);
            PNL_DrawerHost.Controls.Add(PIC_Logo);
            PNL_DrawerHost.Dock = DockStyle.Left;
            PNL_DrawerHost.Location = new Point(0, 20);
            PNL_DrawerHost.Name = "PNL_DrawerHost";
            PNL_DrawerHost.Size = new Size(200, 509);
            PNL_DrawerHost.TabIndex = 6;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 556);
            Controls.Add(PNL_Root);
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAdministrador";
            Padding = new Padding(3, 25, 3, 2);
            TABS_MenuAdmin.ResumeLayout(false);
            TAB_Usuario.ResumeLayout(false);
            PNL_UsuarioBotones.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            PNL_ListaUsuario.ResumeLayout(false);
            PNL_BuscarUsuario.ResumeLayout(false);
            LAYPanel_BuscarUsuario.ResumeLayout(false);
            TBLAY_PanelLimpiar.ResumeLayout(false);
            TBLAY_PanelLimpiar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_Buscador).EndInit();
            TAB_Turno.ResumeLayout(false);
            PNL_RootTurnos.ResumeLayout(false);
            PNL_TurnoCuerpo.ResumeLayout(false);
            PNL_TurnoLista.ResumeLayout(false);
            PNL_TurnoBotones.ResumeLayout(false);
            TLP_TurnosBotones.ResumeLayout(false);
            TLP_TurnosBotones.PerformLayout();
            PNL_TunosCabezera.ResumeLayout(false);
            PNL_BuscarTurno.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            PNL_Calendar.ResumeLayout(false);
            TAB_Producto.ResumeLayout(false);
            PNL_ProductoContenido.ResumeLayout(false);
            PNL_ProductoBotones.ResumeLayout(false);
            TLP_ProductoBotones.ResumeLayout(false);
            TLP_ProductoBotones.PerformLayout();
            PNL_ProductoLista.ResumeLayout(false);
            PNL_ProductoCabezera.ResumeLayout(false);
            TLP_ProductoBuscador.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_ProductoBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PIC_Logo).EndInit();
            PNL_Root.ResumeLayout(false);
            PNL_Contenido.ResumeLayout(false);
            PNL_DrawerHost.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl TABS_MenuAdmin;
        private TabPage TAB_Usuario;
        private TabPage TAB_Turno;
        private MaterialSkin.Controls.MaterialDrawer drawerMenu;
        private MaterialSkin.Controls.MaterialButton BTN_ModificarUsuario;
        private MaterialSkin.Controls.MaterialButton BTN_EliminarUsuario;
        private MaterialSkin.Controls.MaterialListView LISTV_ListaTurnos;
        private MaterialSkin.Controls.MaterialButton BTN_CrearUsuario;
        private MonthCalendar CANDELAR_Turno;
        private MaterialSkin.Controls.MaterialButton BTN_ModificarTurno;
        private MaterialSkin.Controls.MaterialButton BTN_EliminarTurno;
        private MaterialSkin.Controls.MaterialButton BTN_AsignarTurno;
        private TabPage TAB_Producto;
        private MaterialSkin.Controls.MaterialListView LIST_Producto;
        private MaterialSkin.Controls.MaterialButton BTN_AgregarProducto;
        private MaterialSkin.Controls.MaterialButton BTN_EliminarProducto;
        private MaterialSkin.Controls.MaterialButton BTN_ModificarProducto;
        private TabPage TAB_Mascota;
        private TabPage TAB_Reporte;
        private PictureBox PIC_Logo;
        private MaterialSkin.Controls.MaterialListView LIS_Usuario;
        private Panel PNL_Root;
        private Panel PNL_Contenido;
        private Panel PNL_DrawerHost;
        private Panel PNL_ListaUsuario;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel PNL_UsuarioBotones;
        private Panel PNL_BuscarUsuario;
        private TableLayoutPanel LAYPanel_BuscarUsuario;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_BuscarUsuario;
        private PictureBox PIC_Buscador;
        private MaterialSkin.Controls.MaterialFloatingActionButton BTN_LimpiarBusqueda;
        private TableLayoutPanel TBLAY_PanelLimpiar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Panel PNL_RootTurnos;
        private TableLayoutPanel TLP_TurnosBotones;
        private Panel PNL_TurnoCuerpo;
        private Panel PNL_TunosCabezera;
        private Panel PNL_Calendar;
        private Panel PNL_BuscarTurno;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel LBL_BuscarTurno;
        private Panel PNL_TurnoBotones;
        private Panel PNL_TurnoLista;
        private Panel PNL_ProductoCabezera;
        private TableLayoutPanel TLP_ProductoBuscador;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_ProductoBuscar;
        private PictureBox PIC_ProductoBuscar;
        private Panel PNL_ProductoContenido;
        private Panel PNL_ProductoBotones;
        private Panel PNL_ProductoLista;
        private TableLayoutPanel TLP_ProductoBotones;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialFloatingActionButton BTN_ProductoLimpiar;
        private MaterialSkin.Controls.MaterialLabel LBL_ProductoLimpiar;
    }
}