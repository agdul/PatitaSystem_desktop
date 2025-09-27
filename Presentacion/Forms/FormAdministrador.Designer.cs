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
            BTN_CrearUsuario = new MaterialSkin.Controls.MaterialButton();
            BTN_ModificarUsuario = new MaterialSkin.Controls.MaterialButton();
            BTN_EliminarUsuario = new MaterialSkin.Controls.MaterialButton();
            LIS_Usuario = new MaterialSkin.Controls.MaterialListView();
            TAB_Turno = new TabPage();
            BTN_ModificarTurno = new MaterialSkin.Controls.MaterialButton();
            BTN_EliminarTurno = new MaterialSkin.Controls.MaterialButton();
            BTN_AsignarTurno = new MaterialSkin.Controls.MaterialButton();
            CANDELAR_Turno = new MonthCalendar();
            LISTV_ListaTurnos = new MaterialSkin.Controls.MaterialListView();
            TAB_Producto = new TabPage();
            BTN_ModificarProducto = new MaterialSkin.Controls.MaterialButton();
            BTN_AgregarProducto = new MaterialSkin.Controls.MaterialButton();
            BTN_EliminarProducto = new MaterialSkin.Controls.MaterialButton();
            ListViewProducto = new MaterialSkin.Controls.MaterialListView();
            TAB_Mascota = new TabPage();
            TAB_Reporte = new TabPage();
            drawerMenu = new MaterialSkin.Controls.MaterialDrawer();
            PIC_Logo = new PictureBox();
            TABS_MenuAdmin.SuspendLayout();
            TAB_Usuario.SuspendLayout();
            TAB_Turno.SuspendLayout();
            TAB_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_Logo).BeginInit();
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
            TABS_MenuAdmin.Location = new Point(307, 34);
            TABS_MenuAdmin.Margin = new Padding(3, 2, 3, 2);
            TABS_MenuAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            TABS_MenuAdmin.Multiline = true;
            TABS_MenuAdmin.Name = "TABS_MenuAdmin";
            TABS_MenuAdmin.SelectedIndex = 0;
            TABS_MenuAdmin.Size = new Size(519, 429);
            TABS_MenuAdmin.TabIndex = 2;
            // 
            // TAB_Usuario
            // 
            TAB_Usuario.BackColor = Color.DarkGray;
            TAB_Usuario.Controls.Add(BTN_CrearUsuario);
            TAB_Usuario.Controls.Add(BTN_ModificarUsuario);
            TAB_Usuario.Controls.Add(BTN_EliminarUsuario);
            TAB_Usuario.Controls.Add(LIS_Usuario);
            TAB_Usuario.Location = new Point(4, 24);
            TAB_Usuario.Margin = new Padding(3, 2, 3, 2);
            TAB_Usuario.Name = "TAB_Usuario";
            TAB_Usuario.Padding = new Padding(3, 2, 3, 2);
            TAB_Usuario.Size = new Size(511, 401);
            TAB_Usuario.TabIndex = 0;
            TAB_Usuario.Text = "Usuarios";
            // 
            // BTN_CrearUsuario
            // 
            BTN_CrearUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_CrearUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_CrearUsuario.Depth = 0;
            BTN_CrearUsuario.HighEmphasis = true;
            BTN_CrearUsuario.Icon = null;
            BTN_CrearUsuario.Location = new Point(65, 233);
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
            BTN_ModificarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_ModificarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_ModificarUsuario.Depth = 0;
            BTN_ModificarUsuario.HighEmphasis = true;
            BTN_ModificarUsuario.Icon = null;
            BTN_ModificarUsuario.Location = new Point(207, 233);
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
            BTN_EliminarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_EliminarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_EliminarUsuario.Depth = 0;
            BTN_EliminarUsuario.ForeColor = SystemColors.ControlDarkDark;
            BTN_EliminarUsuario.HighEmphasis = true;
            BTN_EliminarUsuario.Icon = null;
            BTN_EliminarUsuario.Location = new Point(375, 233);
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
            // LIS_Usuario
            // 
            LIS_Usuario.AutoSizeTable = false;
            LIS_Usuario.BackColor = Color.FromArgb(255, 255, 255);
            LIS_Usuario.BorderStyle = BorderStyle.None;
            LIS_Usuario.Depth = 0;
            LIS_Usuario.FullRowSelect = true;
            LIS_Usuario.Location = new Point(35, 19);
            LIS_Usuario.Margin = new Padding(3, 2, 3, 2);
            LIS_Usuario.MinimumSize = new Size(175, 75);
            LIS_Usuario.MouseLocation = new Point(-1, -1);
            LIS_Usuario.MouseState = MaterialSkin.MouseState.OUT;
            LIS_Usuario.Name = "LIS_Usuario";
            LIS_Usuario.OwnerDraw = true;
            LIS_Usuario.Size = new Size(451, 191);
            LIS_Usuario.TabIndex = 3;
            LIS_Usuario.UseCompatibleStateImageBehavior = false;
            LIS_Usuario.View = View.Details;
            // 
            // TAB_Turno
            // 
            TAB_Turno.BackColor = Color.RosyBrown;
            TAB_Turno.Controls.Add(BTN_ModificarTurno);
            TAB_Turno.Controls.Add(BTN_EliminarTurno);
            TAB_Turno.Controls.Add(BTN_AsignarTurno);
            TAB_Turno.Controls.Add(CANDELAR_Turno);
            TAB_Turno.Controls.Add(LISTV_ListaTurnos);
            TAB_Turno.Location = new Point(4, 24);
            TAB_Turno.Margin = new Padding(3, 2, 3, 2);
            TAB_Turno.Name = "TAB_Turno";
            TAB_Turno.Padding = new Padding(3, 2, 3, 2);
            TAB_Turno.Size = new Size(511, 401);
            TAB_Turno.TabIndex = 1;
            TAB_Turno.Text = "Turnos";

            // 
            // BTN_ModificarTurno
            // 
            BTN_ModificarTurno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_ModificarTurno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_ModificarTurno.Depth = 0;
            BTN_ModificarTurno.HighEmphasis = true;
            BTN_ModificarTurno.Icon = null;
            BTN_ModificarTurno.Location = new Point(331, 328);
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
            BTN_EliminarTurno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_EliminarTurno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_EliminarTurno.Depth = 0;
            BTN_EliminarTurno.HighEmphasis = true;
            BTN_EliminarTurno.Icon = null;
            BTN_EliminarTurno.Location = new Point(177, 328);
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
            // BTN_AsignarTurno
            // 
            BTN_AsignarTurno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_AsignarTurno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_AsignarTurno.Depth = 0;
            BTN_AsignarTurno.HighEmphasis = true;
            BTN_AsignarTurno.Icon = null;
            BTN_AsignarTurno.Location = new Point(19, 328);
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
            // CANDELAR_Turno
            // 
            CANDELAR_Turno.Location = new Point(120, 7);
            CANDELAR_Turno.Margin = new Padding(8, 7, 8, 7);
            CANDELAR_Turno.Name = "CANDELAR_Turno";
            CANDELAR_Turno.TabIndex = 1;
            // 
            // LISTV_ListaTurnos
            // 
            LISTV_ListaTurnos.AutoSizeTable = false;
            LISTV_ListaTurnos.BackColor = Color.FromArgb(255, 255, 255);
            LISTV_ListaTurnos.BorderStyle = BorderStyle.None;
            LISTV_ListaTurnos.Depth = 0;
            LISTV_ListaTurnos.FullRowSelect = true;
            LISTV_ListaTurnos.Location = new Point(42, 171);
            LISTV_ListaTurnos.Margin = new Padding(3, 2, 3, 2);
            LISTV_ListaTurnos.MinimumSize = new Size(175, 75);
            LISTV_ListaTurnos.MouseLocation = new Point(-1, -1);
            LISTV_ListaTurnos.MouseState = MaterialSkin.MouseState.OUT;
            LISTV_ListaTurnos.Name = "LISTV_ListaTurnos";
            LISTV_ListaTurnos.OwnerDraw = true;
            LISTV_ListaTurnos.Size = new Size(390, 146);
            LISTV_ListaTurnos.TabIndex = 0;
            LISTV_ListaTurnos.UseCompatibleStateImageBehavior = false;
            LISTV_ListaTurnos.View = View.Details;
            // 
            // TAB_Producto
            // 
            TAB_Producto.Controls.Add(BTN_ModificarProducto);
            TAB_Producto.Controls.Add(BTN_AgregarProducto);
            TAB_Producto.Controls.Add(BTN_EliminarProducto);
            TAB_Producto.Controls.Add(ListViewProducto);
            TAB_Producto.Location = new Point(4, 24);
            TAB_Producto.Margin = new Padding(3, 2, 3, 2);
            TAB_Producto.Name = "TAB_Producto";
            TAB_Producto.Padding = new Padding(3, 2, 3, 2);
            TAB_Producto.Size = new Size(511, 401);
            TAB_Producto.TabIndex = 2;
            TAB_Producto.Text = "Productos";
            TAB_Producto.UseVisualStyleBackColor = true;

            // 
            // BTN_ModificarProducto
            // 
            BTN_ModificarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_ModificarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_ModificarProducto.Depth = 0;
            BTN_ModificarProducto.HighEmphasis = true;
            BTN_ModificarProducto.Icon = null;
            BTN_ModificarProducto.Location = new Point(176, 239);
            BTN_ModificarProducto.Margin = new Padding(4);
            BTN_ModificarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_ModificarProducto.Name = "BTN_ModificarProducto";
            BTN_ModificarProducto.NoAccentTextColor = Color.Empty;
            BTN_ModificarProducto.Size = new Size(180, 36);
            BTN_ModificarProducto.TabIndex = 3;
            BTN_ModificarProducto.Text = "Modificar Producto";
            BTN_ModificarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_ModificarProducto.UseAccentColor = false;
            BTN_ModificarProducto.UseVisualStyleBackColor = true;
            BTN_ModificarProducto.Click += materialButton9_Click;
            // 
            // BTN_AgregarProducto
            // 
            BTN_AgregarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_AgregarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_AgregarProducto.Depth = 0;
            BTN_AgregarProducto.HighEmphasis = true;
            BTN_AgregarProducto.Icon = null;
            BTN_AgregarProducto.Location = new Point(259, 195);
            BTN_AgregarProducto.Margin = new Padding(4);
            BTN_AgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_AgregarProducto.Name = "BTN_AgregarProducto";
            BTN_AgregarProducto.NoAccentTextColor = Color.Empty;
            BTN_AgregarProducto.Size = new Size(168, 36);
            BTN_AgregarProducto.TabIndex = 2;
            BTN_AgregarProducto.Text = "Agregar Producto";
            BTN_AgregarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_AgregarProducto.UseAccentColor = false;
            BTN_AgregarProducto.UseVisualStyleBackColor = true;
            // 
            // BTN_EliminarProducto
            // 
            BTN_EliminarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_EliminarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_EliminarProducto.Depth = 0;
            BTN_EliminarProducto.HighEmphasis = true;
            BTN_EliminarProducto.Icon = null;
            BTN_EliminarProducto.Location = new Point(77, 195);
            BTN_EliminarProducto.Margin = new Padding(4);
            BTN_EliminarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_EliminarProducto.Name = "BTN_EliminarProducto";
            BTN_EliminarProducto.NoAccentTextColor = Color.Empty;
            BTN_EliminarProducto.Size = new Size(169, 36);
            BTN_EliminarProducto.TabIndex = 1;
            BTN_EliminarProducto.Text = "Eliminar producto";
            BTN_EliminarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_EliminarProducto.UseAccentColor = false;
            BTN_EliminarProducto.UseVisualStyleBackColor = true;
            BTN_EliminarProducto.Click += materialButton7_Click;
            // 
            // ListViewProducto
            // 
            ListViewProducto.AutoSizeTable = false;
            ListViewProducto.BackColor = Color.FromArgb(255, 255, 255);
            ListViewProducto.BorderStyle = BorderStyle.None;
            ListViewProducto.Depth = 0;
            ListViewProducto.FullRowSelect = true;
            ListViewProducto.Location = new Point(35, 38);
            ListViewProducto.Margin = new Padding(3, 2, 3, 2);
            ListViewProducto.MinimumSize = new Size(175, 75);
            ListViewProducto.MouseLocation = new Point(-1, -1);
            ListViewProducto.MouseState = MaterialSkin.MouseState.OUT;
            ListViewProducto.Name = "ListViewProducto";
            ListViewProducto.OwnerDraw = true;
            ListViewProducto.Size = new Size(402, 100);
            ListViewProducto.TabIndex = 0;
            ListViewProducto.UseCompatibleStateImageBehavior = false;
            ListViewProducto.View = View.Details;

            // 
            // TAB_Mascota
            // 
            TAB_Mascota.Location = new Point(4, 24);
            TAB_Mascota.Margin = new Padding(3, 2, 3, 2);
            TAB_Mascota.Name = "TAB_Mascota";
            TAB_Mascota.Padding = new Padding(3, 2, 3, 2);
            TAB_Mascota.Size = new Size(511, 401);
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
            TAB_Reporte.Size = new Size(511, 401);
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
            drawerMenu.HighlightWithAccent = true;
            drawerMenu.IndicatorWidth = 0;
            drawerMenu.IsOpen = true;
            drawerMenu.Location = new Point(0, 34);
            drawerMenu.Margin = new Padding(3, 2, 3, 2);
            drawerMenu.MouseState = MaterialSkin.MouseState.HOVER;
            drawerMenu.Name = "drawerMenu";
            drawerMenu.ShowIconsWhenHidden = false;
            drawerMenu.Size = new Size(273, 429);
            drawerMenu.TabIndex = 4;
            drawerMenu.Text = "materialDrawer1";
            drawerMenu.UseColors = false;

            // 
            // PIC_Logo
            // 
            PIC_Logo.Image = Properties.Resources.logo2;
            PIC_Logo.Location = new Point(27, 348);
            PIC_Logo.Margin = new Padding(3, 2, 3, 2);
            PIC_Logo.Name = "PIC_Logo";
            PIC_Logo.Size = new Size(228, 99);
            PIC_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_Logo.TabIndex = 5;
            PIC_Logo.TabStop = false;

            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 509);
            Controls.Add(PIC_Logo);
            Controls.Add(drawerMenu);
            Controls.Add(TABS_MenuAdmin);
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAdministrador";
            Padding = new Padding(3, 18, 3, 2);
            TABS_MenuAdmin.ResumeLayout(false);
            TAB_Usuario.ResumeLayout(false);
            TAB_Usuario.PerformLayout();
            TAB_Turno.ResumeLayout(false);
            TAB_Turno.PerformLayout();
            TAB_Producto.ResumeLayout(false);
            TAB_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_Logo).EndInit();
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
        private MaterialSkin.Controls.MaterialListView ListViewProducto;
        private MaterialSkin.Controls.MaterialButton BTN_AgregarProducto;
        private MaterialSkin.Controls.MaterialButton BTN_EliminarProducto;
        private MaterialSkin.Controls.MaterialButton BTN_ModificarProducto;
        private TabPage TAB_Mascota;
        private TabPage TAB_Reporte;
        private PictureBox PIC_Logo;
        private MaterialSkin.Controls.MaterialListView LIS_Usuario;
    }
}