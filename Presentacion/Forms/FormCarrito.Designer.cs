namespace PatitaSystem.Presentacion.Forms
{
    partial class FormCarrito
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
            CARD_Header = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel2 = new TableLayoutPanel();
            TABS_Carrito = new MaterialSkin.Controls.MaterialTabSelector();
            TABC_Carrito = new MaterialSkin.Controls.MaterialTabControl();
            TAB_Producto = new TabPage();
            TLP_ProductoMain = new TableLayoutPanel();
            TLP_ProductoBuscador = new TableLayoutPanel();
            TXT_ProductoBuscar = new MaterialSkin.Controls.MaterialTextBox2();
            PIC_ProductoBuscar = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            LBL_ProductoLimpiar = new MaterialSkin.Controls.MaterialLabel();
            BTN_ProductoLimpiar = new MaterialSkin.Controls.MaterialFloatingActionButton();
            TLP_ProductoBotones = new TableLayoutPanel();
            BTN_Carrito = new MaterialSkin.Controls.MaterialButton();
            LIS_ProductoC = new MaterialSkin.Controls.MaterialListView();
            TAB_Carrito = new TabPage();
            TLP_CarritoMain = new TableLayoutPanel();
            TLP_CarritoBotones = new TableLayoutPanel();
            BTN_Eliminar = new MaterialSkin.Controls.MaterialButton();
            BTN_Vaciar = new MaterialSkin.Controls.MaterialButton();
            LIS_Carrito = new MaterialSkin.Controls.MaterialListView();
            TAB_Finalizar = new TabPage();
            PNL_FinalizarVentaMain = new Panel();
            PNL_DetalleDeCompra = new Panel();
            TLP_CarritoSubtotal = new TableLayoutPanel();
            CARD_CarritoDetalleCompra = new MaterialSkin.Controls.MaterialCard();
            TLP_CarritoDetalleCompra = new TableLayoutPanel();
            Total = new Label();
            LBL_Subtotal = new Label();
            LBL_Descuento = new Label();
            LBL_Total = new Label();
            Descuento = new Label();
            Subtotal = new Label();
            TLP_DetalleCompraBotones = new TableLayoutPanel();
            BTN_Confirmar = new MaterialSkin.Controls.MaterialButton();
            BTN_Volver = new MaterialSkin.Controls.MaterialButton();
            PNL_DetalleCompra = new Panel();
            TLP_DetalleDeCompra = new TableLayoutPanel();
            LIS_Compra = new MaterialSkin.Controls.MaterialListView();
            LBL_ListaCompra = new MaterialSkin.Controls.MaterialLabel();
            PNL_VentasNavbar = new MaterialSkin.Controls.MaterialDivider();
            TLP_CarritoVentas = new TableLayoutPanel();
            LBL_VentaTitulo = new MaterialSkin.Controls.MaterialLabel();
            PNL_RootVentas = new Panel();
            PNL_Contenido = new Panel();
            PNL_Cabezera = new Panel();
            CARD_Header.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            TABC_Carrito.SuspendLayout();
            TAB_Producto.SuspendLayout();
            TLP_ProductoMain.SuspendLayout();
            TLP_ProductoBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_ProductoBuscar).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            TLP_ProductoBotones.SuspendLayout();
            TAB_Carrito.SuspendLayout();
            TLP_CarritoMain.SuspendLayout();
            TLP_CarritoBotones.SuspendLayout();
            TAB_Finalizar.SuspendLayout();
            PNL_FinalizarVentaMain.SuspendLayout();
            PNL_DetalleDeCompra.SuspendLayout();
            TLP_CarritoSubtotal.SuspendLayout();
            CARD_CarritoDetalleCompra.SuspendLayout();
            TLP_CarritoDetalleCompra.SuspendLayout();
            TLP_DetalleCompraBotones.SuspendLayout();
            PNL_DetalleCompra.SuspendLayout();
            TLP_DetalleDeCompra.SuspendLayout();
            TLP_CarritoVentas.SuspendLayout();
            PNL_RootVentas.SuspendLayout();
            PNL_Contenido.SuspendLayout();
            PNL_Cabezera.SuspendLayout();
            SuspendLayout();
            // 
            // CARD_Header
            // 
            CARD_Header.BackColor = Color.FromArgb(255, 255, 255);
            CARD_Header.Controls.Add(tableLayoutPanel2);
            CARD_Header.Controls.Add(PNL_VentasNavbar);
            CARD_Header.Controls.Add(TLP_CarritoVentas);
            CARD_Header.Depth = 0;
            CARD_Header.Dock = DockStyle.Fill;
            CARD_Header.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CARD_Header.Location = new Point(0, 0);
            CARD_Header.Margin = new Padding(10);
            CARD_Header.MouseState = MaterialSkin.MouseState.HOVER;
            CARD_Header.Name = "CARD_Header";
            CARD_Header.Padding = new Padding(12, 10, 12, 10);
            CARD_Header.Size = new Size(910, 94);
            CARD_Header.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.25313F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.74687F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 204F));
            tableLayoutPanel2.Controls.Add(TABS_Carrito, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(12, 52);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(886, 32);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // TABS_Carrito
            // 
            TABS_Carrito.BaseTabControl = TABC_Carrito;
            TABS_Carrito.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            TABS_Carrito.Depth = 0;
            TABS_Carrito.Dock = DockStyle.Fill;
            TABS_Carrito.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TABS_Carrito.Location = new Point(151, 0);
            TABS_Carrito.Margin = new Padding(0);
            TABS_Carrito.MouseState = MaterialSkin.MouseState.HOVER;
            TABS_Carrito.Name = "TABS_Carrito";
            TABS_Carrito.Size = new Size(530, 32);
            TABS_Carrito.TabIndex = 1;
            // 
            // TABC_Carrito
            // 
            TABC_Carrito.Controls.Add(TAB_Producto);
            TABC_Carrito.Controls.Add(TAB_Carrito);
            TABC_Carrito.Controls.Add(TAB_Finalizar);
            TABC_Carrito.Depth = 0;
            TABC_Carrito.Dock = DockStyle.Fill;
            TABC_Carrito.Location = new Point(0, 0);
            TABC_Carrito.Margin = new Padding(3, 2, 3, 2);
            TABC_Carrito.MouseState = MaterialSkin.MouseState.HOVER;
            TABC_Carrito.Multiline = true;
            TABC_Carrito.Name = "TABC_Carrito";
            TABC_Carrito.SelectedIndex = 0;
            TABC_Carrito.Size = new Size(910, 452);
            TABC_Carrito.TabIndex = 2;
            // 
            // TAB_Producto
            // 
            TAB_Producto.Controls.Add(TLP_ProductoMain);
            TAB_Producto.Location = new Point(4, 24);
            TAB_Producto.Margin = new Padding(3, 2, 3, 2);
            TAB_Producto.Name = "TAB_Producto";
            TAB_Producto.Padding = new Padding(3, 2, 3, 2);
            TAB_Producto.Size = new Size(902, 424);
            TAB_Producto.TabIndex = 0;
            TAB_Producto.Text = "Productos";
            TAB_Producto.UseVisualStyleBackColor = true;
            // 
            // TLP_ProductoMain
            // 
            TLP_ProductoMain.ColumnCount = 1;
            TLP_ProductoMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_ProductoMain.Controls.Add(TLP_ProductoBuscador, 0, 0);
            TLP_ProductoMain.Controls.Add(TLP_ProductoBotones, 0, 2);
            TLP_ProductoMain.Controls.Add(LIS_ProductoC, 0, 1);
            TLP_ProductoMain.Dock = DockStyle.Fill;
            TLP_ProductoMain.Location = new Point(3, 2);
            TLP_ProductoMain.Name = "TLP_ProductoMain";
            TLP_ProductoMain.RowCount = 3;
            TLP_ProductoMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            TLP_ProductoMain.RowStyles.Add(new RowStyle(SizeType.Percent, 81.70731F));
            TLP_ProductoMain.RowStyles.Add(new RowStyle(SizeType.Percent, 18.2926826F));
            TLP_ProductoMain.Size = new Size(896, 420);
            TLP_ProductoMain.TabIndex = 1;
            // 
            // TLP_ProductoBuscador
            // 
            TLP_ProductoBuscador.ColumnCount = 5;
            TLP_ProductoBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.6199341F));
            TLP_ProductoBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3800621F));
            TLP_ProductoBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 263F));
            TLP_ProductoBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            TLP_ProductoBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 222F));
            TLP_ProductoBuscador.Controls.Add(TXT_ProductoBuscar, 2, 0);
            TLP_ProductoBuscador.Controls.Add(PIC_ProductoBuscar, 1, 0);
            TLP_ProductoBuscador.Controls.Add(tableLayoutPanel3, 3, 0);
            TLP_ProductoBuscador.Dock = DockStyle.Fill;
            TLP_ProductoBuscador.Location = new Point(3, 3);
            TLP_ProductoBuscador.Name = "TLP_ProductoBuscador";
            TLP_ProductoBuscador.RowCount = 1;
            TLP_ProductoBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 74F));
            TLP_ProductoBuscador.Size = new Size(890, 74);
            TLP_ProductoBuscador.TabIndex = 2;
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
            TXT_ProductoBuscar.Location = new Point(324, 3);
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
            PIC_ProductoBuscar.Location = new Point(265, 3);
            PIC_ProductoBuscar.Name = "PIC_ProductoBuscar";
            PIC_ProductoBuscar.Size = new Size(53, 64);
            PIC_ProductoBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_ProductoBuscar.TabIndex = 1;
            PIC_ProductoBuscar.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(LBL_ProductoLimpiar, 0, 1);
            tableLayoutPanel3.Controls.Add(BTN_ProductoLimpiar, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(587, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel3.Size = new Size(77, 68);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // LBL_ProductoLimpiar
            // 
            LBL_ProductoLimpiar.AutoSize = true;
            LBL_ProductoLimpiar.Depth = 0;
            LBL_ProductoLimpiar.Dock = DockStyle.Top;
            LBL_ProductoLimpiar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_ProductoLimpiar.Location = new Point(3, 46);
            LBL_ProductoLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_ProductoLimpiar.Name = "LBL_ProductoLimpiar";
            LBL_ProductoLimpiar.Size = new Size(71, 19);
            LBL_ProductoLimpiar.TabIndex = 7;
            LBL_ProductoLimpiar.Text = "Limpiar";
            // 
            // BTN_ProductoLimpiar
            // 
            BTN_ProductoLimpiar.Anchor = AnchorStyles.None;
            BTN_ProductoLimpiar.Depth = 0;
            BTN_ProductoLimpiar.Icon = Properties.Resources.cruz;
            BTN_ProductoLimpiar.Location = new Point(15, 3);
            BTN_ProductoLimpiar.Mini = true;
            BTN_ProductoLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_ProductoLimpiar.Name = "BTN_ProductoLimpiar";
            BTN_ProductoLimpiar.Size = new Size(46, 40);
            BTN_ProductoLimpiar.TabIndex = 6;
            BTN_ProductoLimpiar.UseVisualStyleBackColor = true;
            // 
            // TLP_ProductoBotones
            // 
            TLP_ProductoBotones.ColumnCount = 3;
            TLP_ProductoBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.55979F));
            TLP_ProductoBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3843651F));
            TLP_ProductoBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.0879478F));
            TLP_ProductoBotones.Controls.Add(BTN_Carrito, 1, 0);
            TLP_ProductoBotones.Dock = DockStyle.Fill;
            TLP_ProductoBotones.Location = new Point(3, 360);
            TLP_ProductoBotones.Name = "TLP_ProductoBotones";
            TLP_ProductoBotones.RowCount = 1;
            TLP_ProductoBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_ProductoBotones.Size = new Size(890, 57);
            TLP_ProductoBotones.TabIndex = 1;
            // 
            // BTN_Carrito
            // 
            BTN_Carrito.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Carrito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Carrito.Depth = 0;
            BTN_Carrito.Dock = DockStyle.Fill;
            BTN_Carrito.HighEmphasis = true;
            BTN_Carrito.Icon = null;
            BTN_Carrito.Location = new Point(311, 4);
            BTN_Carrito.Margin = new Padding(4);
            BTN_Carrito.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Carrito.Name = "BTN_Carrito";
            BTN_Carrito.NoAccentTextColor = Color.Empty;
            BTN_Carrito.Size = new Size(226, 49);
            BTN_Carrito.TabIndex = 3;
            BTN_Carrito.Text = "Agregar al carrito";
            BTN_Carrito.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Carrito.UseAccentColor = false;
            BTN_Carrito.UseVisualStyleBackColor = true;
            // 
            // LIS_ProductoC
            // 
            LIS_ProductoC.AutoSizeTable = false;
            LIS_ProductoC.BackColor = Color.FromArgb(255, 255, 255);
            LIS_ProductoC.BorderStyle = BorderStyle.None;
            LIS_ProductoC.Depth = 0;
            LIS_ProductoC.Dock = DockStyle.Fill;
            LIS_ProductoC.FullRowSelect = true;
            LIS_ProductoC.Location = new Point(3, 82);
            LIS_ProductoC.Margin = new Padding(3, 2, 3, 2);
            LIS_ProductoC.MinimumSize = new Size(175, 75);
            LIS_ProductoC.MouseLocation = new Point(-1, -1);
            LIS_ProductoC.MouseState = MaterialSkin.MouseState.OUT;
            LIS_ProductoC.Name = "LIS_ProductoC";
            LIS_ProductoC.OwnerDraw = true;
            LIS_ProductoC.Size = new Size(890, 273);
            LIS_ProductoC.TabIndex = 0;
            LIS_ProductoC.UseCompatibleStateImageBehavior = false;
            LIS_ProductoC.View = View.Details;
            // 
            // TAB_Carrito
            // 
            TAB_Carrito.Controls.Add(TLP_CarritoMain);
            TAB_Carrito.Location = new Point(4, 24);
            TAB_Carrito.Margin = new Padding(3, 2, 3, 2);
            TAB_Carrito.Name = "TAB_Carrito";
            TAB_Carrito.Padding = new Padding(3, 2, 3, 2);
            TAB_Carrito.Size = new Size(902, 424);
            TAB_Carrito.TabIndex = 1;
            TAB_Carrito.Text = "Carrito";
            TAB_Carrito.UseVisualStyleBackColor = true;
            // 
            // TLP_CarritoMain
            // 
            TLP_CarritoMain.ColumnCount = 1;
            TLP_CarritoMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLP_CarritoMain.Controls.Add(TLP_CarritoBotones, 0, 2);
            TLP_CarritoMain.Controls.Add(LIS_Carrito, 0, 1);
            TLP_CarritoMain.Dock = DockStyle.Fill;
            TLP_CarritoMain.Location = new Point(3, 2);
            TLP_CarritoMain.Name = "TLP_CarritoMain";
            TLP_CarritoMain.RowCount = 3;
            TLP_CarritoMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4705887F));
            TLP_CarritoMain.RowStyles.Add(new RowStyle(SizeType.Percent, 69.52381F));
            TLP_CarritoMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            TLP_CarritoMain.Size = new Size(896, 420);
            TLP_CarritoMain.TabIndex = 3;
            // 
            // TLP_CarritoBotones
            // 
            TLP_CarritoBotones.ColumnCount = 3;
            TLP_CarritoBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.9120865F));
            TLP_CarritoBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.0879135F));
            TLP_CarritoBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            TLP_CarritoBotones.Controls.Add(BTN_Eliminar, 0, 0);
            TLP_CarritoBotones.Controls.Add(BTN_Vaciar, 2, 0);
            TLP_CarritoBotones.Dock = DockStyle.Fill;
            TLP_CarritoBotones.Location = new Point(3, 362);
            TLP_CarritoBotones.Name = "TLP_CarritoBotones";
            TLP_CarritoBotones.RowCount = 1;
            TLP_CarritoBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_CarritoBotones.Size = new Size(890, 55);
            TLP_CarritoBotones.TabIndex = 1;
            // 
            // BTN_Eliminar
            // 
            BTN_Eliminar.Anchor = AnchorStyles.None;
            BTN_Eliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Eliminar.Depth = 0;
            BTN_Eliminar.HighEmphasis = true;
            BTN_Eliminar.Icon = null;
            BTN_Eliminar.Location = new Point(86, 9);
            BTN_Eliminar.Margin = new Padding(4);
            BTN_Eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Eliminar.Name = "BTN_Eliminar";
            BTN_Eliminar.NoAccentTextColor = Color.Empty;
            BTN_Eliminar.Size = new Size(88, 36);
            BTN_Eliminar.TabIndex = 1;
            BTN_Eliminar.Text = "Eliminar";
            BTN_Eliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Eliminar.UseAccentColor = false;
            BTN_Eliminar.UseVisualStyleBackColor = true;
            // 
            // BTN_Vaciar
            // 
            BTN_Vaciar.Anchor = AnchorStyles.None;
            BTN_Vaciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Vaciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Vaciar.Depth = 0;
            BTN_Vaciar.HighEmphasis = true;
            BTN_Vaciar.Icon = null;
            BTN_Vaciar.Location = new Point(721, 9);
            BTN_Vaciar.Margin = new Padding(4);
            BTN_Vaciar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Vaciar.Name = "BTN_Vaciar";
            BTN_Vaciar.NoAccentTextColor = Color.Empty;
            BTN_Vaciar.Size = new Size(138, 36);
            BTN_Vaciar.TabIndex = 2;
            BTN_Vaciar.Text = "Vaciar Carrito";
            BTN_Vaciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Vaciar.UseAccentColor = false;
            BTN_Vaciar.UseVisualStyleBackColor = true;
            // 
            // LIS_Carrito
            // 
            LIS_Carrito.AutoSizeTable = false;
            LIS_Carrito.BackColor = Color.FromArgb(255, 255, 255);
            LIS_Carrito.BorderStyle = BorderStyle.None;
            LIS_Carrito.Depth = 0;
            LIS_Carrito.Dock = DockStyle.Fill;
            LIS_Carrito.FullRowSelect = true;
            LIS_Carrito.Location = new Point(3, 70);
            LIS_Carrito.Margin = new Padding(3, 2, 3, 2);
            LIS_Carrito.MinimumSize = new Size(175, 75);
            LIS_Carrito.MouseLocation = new Point(-1, -1);
            LIS_Carrito.MouseState = MaterialSkin.MouseState.OUT;
            LIS_Carrito.Name = "LIS_Carrito";
            LIS_Carrito.OwnerDraw = true;
            LIS_Carrito.Size = new Size(890, 287);
            LIS_Carrito.TabIndex = 0;
            LIS_Carrito.UseCompatibleStateImageBehavior = false;
            LIS_Carrito.View = View.Details;
            // 
            // TAB_Finalizar
            // 
            TAB_Finalizar.Controls.Add(PNL_FinalizarVentaMain);
            TAB_Finalizar.Location = new Point(4, 24);
            TAB_Finalizar.Margin = new Padding(3, 2, 3, 2);
            TAB_Finalizar.Name = "TAB_Finalizar";
            TAB_Finalizar.Padding = new Padding(3, 2, 3, 2);
            TAB_Finalizar.Size = new Size(902, 424);
            TAB_Finalizar.TabIndex = 2;
            TAB_Finalizar.Text = "Finalizar";
            TAB_Finalizar.UseVisualStyleBackColor = true;
            // 
            // PNL_FinalizarVentaMain
            // 
            PNL_FinalizarVentaMain.Controls.Add(PNL_DetalleDeCompra);
            PNL_FinalizarVentaMain.Controls.Add(PNL_DetalleCompra);
            PNL_FinalizarVentaMain.Dock = DockStyle.Fill;
            PNL_FinalizarVentaMain.Location = new Point(3, 2);
            PNL_FinalizarVentaMain.Name = "PNL_FinalizarVentaMain";
            PNL_FinalizarVentaMain.Size = new Size(896, 420);
            PNL_FinalizarVentaMain.TabIndex = 3;
            // 
            // PNL_DetalleDeCompra
            // 
            PNL_DetalleDeCompra.Controls.Add(TLP_CarritoSubtotal);
            PNL_DetalleDeCompra.Dock = DockStyle.Fill;
            PNL_DetalleDeCompra.Location = new Point(568, 0);
            PNL_DetalleDeCompra.Name = "PNL_DetalleDeCompra";
            PNL_DetalleDeCompra.Size = new Size(328, 420);
            PNL_DetalleDeCompra.TabIndex = 4;
            // 
            // TLP_CarritoSubtotal
            // 
            TLP_CarritoSubtotal.ColumnCount = 1;
            TLP_CarritoSubtotal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLP_CarritoSubtotal.Controls.Add(CARD_CarritoDetalleCompra, 0, 1);
            TLP_CarritoSubtotal.Controls.Add(TLP_DetalleCompraBotones, 0, 2);
            TLP_CarritoSubtotal.Dock = DockStyle.Fill;
            TLP_CarritoSubtotal.Location = new Point(0, 0);
            TLP_CarritoSubtotal.Name = "TLP_CarritoSubtotal";
            TLP_CarritoSubtotal.RowCount = 3;
            TLP_CarritoSubtotal.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4285717F));
            TLP_CarritoSubtotal.RowStyles.Add(new RowStyle(SizeType.Percent, 55.95238F));
            TLP_CarritoSubtotal.RowStyles.Add(new RowStyle(SizeType.Percent, 32.464653F));
            TLP_CarritoSubtotal.Size = new Size(328, 420);
            TLP_CarritoSubtotal.TabIndex = 0;
            // 
            // CARD_CarritoDetalleCompra
            // 
            CARD_CarritoDetalleCompra.BackColor = Color.FromArgb(255, 255, 255);
            CARD_CarritoDetalleCompra.Controls.Add(TLP_CarritoDetalleCompra);
            CARD_CarritoDetalleCompra.Depth = 0;
            CARD_CarritoDetalleCompra.Dock = DockStyle.Fill;
            CARD_CarritoDetalleCompra.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CARD_CarritoDetalleCompra.Location = new Point(12, 58);
            CARD_CarritoDetalleCompra.Margin = new Padding(12, 10, 12, 10);
            CARD_CarritoDetalleCompra.MouseState = MaterialSkin.MouseState.HOVER;
            CARD_CarritoDetalleCompra.Name = "CARD_CarritoDetalleCompra";
            CARD_CarritoDetalleCompra.Padding = new Padding(12, 10, 12, 10);
            CARD_CarritoDetalleCompra.Size = new Size(304, 215);
            CARD_CarritoDetalleCompra.TabIndex = 0;
            // 
            // TLP_CarritoDetalleCompra
            // 
            TLP_CarritoDetalleCompra.ColumnCount = 2;
            TLP_CarritoDetalleCompra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_CarritoDetalleCompra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_CarritoDetalleCompra.Controls.Add(Total, 1, 2);
            TLP_CarritoDetalleCompra.Controls.Add(LBL_Subtotal, 0, 0);
            TLP_CarritoDetalleCompra.Controls.Add(LBL_Descuento, 0, 1);
            TLP_CarritoDetalleCompra.Controls.Add(LBL_Total, 0, 2);
            TLP_CarritoDetalleCompra.Controls.Add(Descuento, 1, 1);
            TLP_CarritoDetalleCompra.Controls.Add(Subtotal, 1, 0);
            TLP_CarritoDetalleCompra.Dock = DockStyle.Fill;
            TLP_CarritoDetalleCompra.Location = new Point(12, 10);
            TLP_CarritoDetalleCompra.Name = "TLP_CarritoDetalleCompra";
            TLP_CarritoDetalleCompra.RowCount = 3;
            TLP_CarritoDetalleCompra.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLP_CarritoDetalleCompra.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLP_CarritoDetalleCompra.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLP_CarritoDetalleCompra.Size = new Size(280, 195);
            TLP_CarritoDetalleCompra.TabIndex = 0;
            // 
            // Total
            // 
            Total.Anchor = AnchorStyles.None;
            Total.AutoSize = true;
            Total.Location = new Point(188, 154);
            Total.Name = "Total";
            Total.Size = new Size(43, 15);
            Total.TabIndex = 5;
            Total.Text = "$$$$$$";
            // 
            // LBL_Subtotal
            // 
            LBL_Subtotal.Anchor = AnchorStyles.None;
            LBL_Subtotal.AutoSize = true;
            LBL_Subtotal.Location = new Point(43, 24);
            LBL_Subtotal.Name = "LBL_Subtotal";
            LBL_Subtotal.Size = new Size(54, 15);
            LBL_Subtotal.TabIndex = 0;
            LBL_Subtotal.Text = "Subtotal:";
            LBL_Subtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBL_Descuento
            // 
            LBL_Descuento.Anchor = AnchorStyles.None;
            LBL_Descuento.AutoSize = true;
            LBL_Descuento.Location = new Point(37, 88);
            LBL_Descuento.Name = "LBL_Descuento";
            LBL_Descuento.Size = new Size(66, 15);
            LBL_Descuento.TabIndex = 2;
            LBL_Descuento.Text = "Descuento:";
            LBL_Descuento.Click += label1_Click;
            // 
            // LBL_Total
            // 
            LBL_Total.Anchor = AnchorStyles.None;
            LBL_Total.AutoSize = true;
            LBL_Total.Location = new Point(47, 154);
            LBL_Total.Name = "LBL_Total";
            LBL_Total.Size = new Size(45, 15);
            LBL_Total.TabIndex = 0;
            LBL_Total.Text = "TOTAL: ";
            // 
            // Descuento
            // 
            Descuento.Anchor = AnchorStyles.None;
            Descuento.AutoSize = true;
            Descuento.Location = new Point(188, 88);
            Descuento.Name = "Descuento";
            Descuento.Size = new Size(43, 15);
            Descuento.TabIndex = 3;
            Descuento.Text = "$$$$$$";
            // 
            // Subtotal
            // 
            Subtotal.Anchor = AnchorStyles.None;
            Subtotal.AutoSize = true;
            Subtotal.Location = new Point(188, 24);
            Subtotal.Name = "Subtotal";
            Subtotal.Size = new Size(43, 15);
            Subtotal.TabIndex = 1;
            Subtotal.Text = "$$$$$$";
            // 
            // TLP_DetalleCompraBotones
            // 
            TLP_DetalleCompraBotones.ColumnCount = 6;
            TLP_DetalleCompraBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.183406F));
            TLP_DetalleCompraBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1525421F));
            TLP_DetalleCompraBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.67558527F));
            TLP_DetalleCompraBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.67558527F));
            TLP_DetalleCompraBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.0677948F));
            TLP_DetalleCompraBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            TLP_DetalleCompraBotones.Controls.Add(BTN_Confirmar, 4, 0);
            TLP_DetalleCompraBotones.Controls.Add(BTN_Volver, 1, 0);
            TLP_DetalleCompraBotones.Dock = DockStyle.Fill;
            TLP_DetalleCompraBotones.Location = new Point(3, 286);
            TLP_DetalleCompraBotones.Name = "TLP_DetalleCompraBotones";
            TLP_DetalleCompraBotones.RowCount = 2;
            TLP_DetalleCompraBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 35.87786F));
            TLP_DetalleCompraBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 64.12214F));
            TLP_DetalleCompraBotones.Size = new Size(322, 131);
            TLP_DetalleCompraBotones.TabIndex = 1;
            // 
            // BTN_Confirmar
            // 
            BTN_Confirmar.Anchor = AnchorStyles.None;
            BTN_Confirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Confirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Confirmar.Depth = 0;
            BTN_Confirmar.HighEmphasis = true;
            BTN_Confirmar.Icon = null;
            BTN_Confirmar.Location = new Point(178, 5);
            BTN_Confirmar.Margin = new Padding(4);
            BTN_Confirmar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Confirmar.Name = "BTN_Confirmar";
            BTN_Confirmar.NoAccentTextColor = Color.Empty;
            BTN_Confirmar.Size = new Size(128, 36);
            BTN_Confirmar.TabIndex = 1;
            BTN_Confirmar.Text = "Confirmar Compra";
            BTN_Confirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Confirmar.UseAccentColor = false;
            BTN_Confirmar.UseVisualStyleBackColor = true;
            // 
            // BTN_Volver
            // 
            BTN_Volver.Anchor = AnchorStyles.None;
            BTN_Volver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Volver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Volver.Depth = 0;
            BTN_Volver.HighEmphasis = true;
            BTN_Volver.Icon = null;
            BTN_Volver.Location = new Point(10, 5);
            BTN_Volver.Margin = new Padding(4);
            BTN_Volver.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Volver.Name = "BTN_Volver";
            BTN_Volver.NoAccentTextColor = Color.Empty;
            BTN_Volver.Size = new Size(144, 36);
            BTN_Volver.TabIndex = 2;
            BTN_Volver.Text = "Volver al carrito";
            BTN_Volver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Volver.UseAccentColor = false;
            BTN_Volver.UseVisualStyleBackColor = true;
            // 
            // PNL_DetalleCompra
            // 
            PNL_DetalleCompra.Controls.Add(TLP_DetalleDeCompra);
            PNL_DetalleCompra.Dock = DockStyle.Left;
            PNL_DetalleCompra.Location = new Point(0, 0);
            PNL_DetalleCompra.Name = "PNL_DetalleCompra";
            PNL_DetalleCompra.Size = new Size(568, 420);
            PNL_DetalleCompra.TabIndex = 3;
            // 
            // TLP_DetalleDeCompra
            // 
            TLP_DetalleDeCompra.ColumnCount = 1;
            TLP_DetalleDeCompra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLP_DetalleDeCompra.Controls.Add(LIS_Compra, 0, 1);
            TLP_DetalleDeCompra.Controls.Add(LBL_ListaCompra, 0, 0);
            TLP_DetalleDeCompra.Dock = DockStyle.Top;
            TLP_DetalleDeCompra.Location = new Point(0, 0);
            TLP_DetalleDeCompra.Name = "TLP_DetalleDeCompra";
            TLP_DetalleDeCompra.RowCount = 2;
            TLP_DetalleDeCompra.RowStyles.Add(new RowStyle(SizeType.Percent, 14.1188583F));
            TLP_DetalleDeCompra.RowStyles.Add(new RowStyle(SizeType.Percent, 85.88115F));
            TLP_DetalleDeCompra.Size = new Size(568, 347);
            TLP_DetalleDeCompra.TabIndex = 0;
            // 
            // LIS_Compra
            // 
            LIS_Compra.AutoSizeTable = false;
            LIS_Compra.BackColor = Color.FromArgb(255, 255, 255);
            LIS_Compra.BorderStyle = BorderStyle.None;
            LIS_Compra.Depth = 0;
            LIS_Compra.Dock = DockStyle.Fill;
            LIS_Compra.FullRowSelect = true;
            LIS_Compra.Location = new Point(3, 50);
            LIS_Compra.Margin = new Padding(3, 2, 3, 2);
            LIS_Compra.MinimumSize = new Size(175, 75);
            LIS_Compra.MouseLocation = new Point(-1, -1);
            LIS_Compra.MouseState = MaterialSkin.MouseState.OUT;
            LIS_Compra.Name = "LIS_Compra";
            LIS_Compra.OwnerDraw = true;
            LIS_Compra.Size = new Size(562, 295);
            LIS_Compra.TabIndex = 0;
            LIS_Compra.UseCompatibleStateImageBehavior = false;
            LIS_Compra.View = View.Details;
            // 
            // LBL_ListaCompra
            // 
            LBL_ListaCompra.Anchor = AnchorStyles.None;
            LBL_ListaCompra.AutoSize = true;
            LBL_ListaCompra.BackColor = Color.Transparent;
            LBL_ListaCompra.Depth = 0;
            LBL_ListaCompra.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBL_ListaCompra.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBL_ListaCompra.ForeColor = SystemColors.ControlLightLight;
            LBL_ListaCompra.Location = new Point(212, 12);
            LBL_ListaCompra.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_ListaCompra.Name = "LBL_ListaCompra";
            LBL_ListaCompra.Size = new Size(144, 24);
            LBL_ListaCompra.TabIndex = 0;
            LBL_ListaCompra.Text = "Lista de compra";
            // 
            // PNL_VentasNavbar
            // 
            PNL_VentasNavbar.AccessibleRole = AccessibleRole.Graphic;
            PNL_VentasNavbar.BackColor = Color.FromArgb(30, 0, 0, 0);
            PNL_VentasNavbar.Depth = 0;
            PNL_VentasNavbar.Dock = DockStyle.Fill;
            PNL_VentasNavbar.Location = new Point(12, 52);
            PNL_VentasNavbar.MouseState = MaterialSkin.MouseState.HOVER;
            PNL_VentasNavbar.Name = "PNL_VentasNavbar";
            PNL_VentasNavbar.Size = new Size(886, 32);
            PNL_VentasNavbar.TabIndex = 3;
            // 
            // TLP_CarritoVentas
            // 
            TLP_CarritoVentas.ColumnCount = 3;
            TLP_CarritoVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TLP_CarritoVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_CarritoVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TLP_CarritoVentas.Controls.Add(LBL_VentaTitulo, 1, 0);
            TLP_CarritoVentas.Dock = DockStyle.Top;
            TLP_CarritoVentas.Location = new Point(12, 10);
            TLP_CarritoVentas.Name = "TLP_CarritoVentas";
            TLP_CarritoVentas.RowCount = 1;
            TLP_CarritoVentas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_CarritoVentas.Size = new Size(886, 42);
            TLP_CarritoVentas.TabIndex = 0;
            // 
            // LBL_VentaTitulo
            // 
            LBL_VentaTitulo.AutoSize = true;
            LBL_VentaTitulo.Depth = 0;
            LBL_VentaTitulo.Dock = DockStyle.Fill;
            LBL_VentaTitulo.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBL_VentaTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            LBL_VentaTitulo.Location = new Point(224, 0);
            LBL_VentaTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_VentaTitulo.Name = "LBL_VentaTitulo";
            LBL_VentaTitulo.Size = new Size(437, 42);
            LBL_VentaTitulo.TabIndex = 0;
            LBL_VentaTitulo.Text = "Carrito de compra";
            LBL_VentaTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PNL_RootVentas
            // 
            PNL_RootVentas.Controls.Add(PNL_Contenido);
            PNL_RootVentas.Controls.Add(PNL_Cabezera);
            PNL_RootVentas.Dock = DockStyle.Fill;
            PNL_RootVentas.Location = new Point(10, 35);
            PNL_RootVentas.Name = "PNL_RootVentas";
            PNL_RootVentas.Size = new Size(910, 546);
            PNL_RootVentas.TabIndex = 3;
            // 
            // PNL_Contenido
            // 
            PNL_Contenido.Controls.Add(TABC_Carrito);
            PNL_Contenido.Dock = DockStyle.Fill;
            PNL_Contenido.Location = new Point(0, 94);
            PNL_Contenido.Name = "PNL_Contenido";
            PNL_Contenido.Size = new Size(910, 452);
            PNL_Contenido.TabIndex = 4;
            // 
            // PNL_Cabezera
            // 
            PNL_Cabezera.Controls.Add(CARD_Header);
            PNL_Cabezera.Dock = DockStyle.Top;
            PNL_Cabezera.Location = new Point(0, 0);
            PNL_Cabezera.Name = "PNL_Cabezera";
            PNL_Cabezera.Size = new Size(910, 94);
            PNL_Cabezera.TabIndex = 3;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 583);
            Controls.Add(PNL_RootVentas);
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCarrito";
            Padding = new Padding(10, 35, 10, 2);
            Text = "FormCarrito";
            Load += FormCarrito_Load;
            CARD_Header.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            TABC_Carrito.ResumeLayout(false);
            TAB_Producto.ResumeLayout(false);
            TLP_ProductoMain.ResumeLayout(false);
            TLP_ProductoBuscador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PIC_ProductoBuscar).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            TLP_ProductoBotones.ResumeLayout(false);
            TLP_ProductoBotones.PerformLayout();
            TAB_Carrito.ResumeLayout(false);
            TLP_CarritoMain.ResumeLayout(false);
            TLP_CarritoBotones.ResumeLayout(false);
            TLP_CarritoBotones.PerformLayout();
            TAB_Finalizar.ResumeLayout(false);
            PNL_FinalizarVentaMain.ResumeLayout(false);
            PNL_DetalleDeCompra.ResumeLayout(false);
            TLP_CarritoSubtotal.ResumeLayout(false);
            CARD_CarritoDetalleCompra.ResumeLayout(false);
            TLP_CarritoDetalleCompra.ResumeLayout(false);
            TLP_CarritoDetalleCompra.PerformLayout();
            TLP_DetalleCompraBotones.ResumeLayout(false);
            TLP_DetalleCompraBotones.PerformLayout();
            PNL_DetalleCompra.ResumeLayout(false);
            TLP_DetalleDeCompra.ResumeLayout(false);
            TLP_DetalleDeCompra.PerformLayout();
            TLP_CarritoVentas.ResumeLayout(false);
            TLP_CarritoVentas.PerformLayout();
            PNL_RootVentas.ResumeLayout(false);
            PNL_Contenido.ResumeLayout(false);
            PNL_Cabezera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard CARD_Header;
        private MaterialSkin.Controls.MaterialTabSelector TABS_Carrito;
        private MaterialSkin.Controls.MaterialTabControl TABC_Carrito;
        private TabPage TAB_Producto;
        private TabPage TAB_Carrito;
        private TabPage TAB_Finalizar;
        private MaterialSkin.Controls.MaterialListView LIS_ProductoC;
        private MaterialSkin.Controls.MaterialButton BTN_Eliminar;
        private MaterialSkin.Controls.MaterialListView LIS_Carrito;
        private MaterialSkin.Controls.MaterialButton BTN_Vaciar;
        private MaterialSkin.Controls.MaterialButton BTN_Carrito;
        private MaterialSkin.Controls.MaterialCard CARD_CarritoDetalleCompra;
        private MaterialSkin.Controls.MaterialLabel LBL_ListaCompra;
        private MaterialSkin.Controls.MaterialListView LIS_Compra;
        private Label LBL_Subtotal;
        private Label Descuento;
        private Label LBL_Descuento;
        private Label Subtotal;
        private Label Total;
        private Label LBL_Total;
        private MaterialSkin.Controls.MaterialButton BTN_Volver;
        private MaterialSkin.Controls.MaterialButton BTN_Confirmar;
        private TableLayoutPanel TLP_CarritoVentas;
        private Panel PNL_RootVentas;
        private MaterialSkin.Controls.MaterialLabel LBL_VentaTitulo;
        private MaterialSkin.Controls.MaterialDivider PNL_VentasNavbar;
        private TableLayoutPanel TLP_ProductoMain;
        private TableLayoutPanel TLP_ProductoBotones;
        private Panel PNL_Cabezera;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel PNL_Contenido;
        private TableLayoutPanel TLP_ProductoBuscador;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialFloatingActionButton BTN_ProductoLimpiar;
        private MaterialSkin.Controls.MaterialLabel LBL_ProductoLimpiar;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_ProductoBuscar;
        private PictureBox PIC_ProductoBuscar;
        private TableLayoutPanel TLP_CarritoMain;
        private TableLayoutPanel TLP_CarritoBotones;
        private TableLayoutPanel TLP_CarritoDetalleCompra;
        private Panel PNL_FinalizarVentaMain;
        private Panel PNL_DetalleCompra;
        private Panel PNL_DetalleDeCompra;
        private TableLayoutPanel TLP_CarritoSubtotal;
        private TableLayoutPanel TLP_DetalleDeCompra;
        private TableLayoutPanel TLP_DetalleCompraBotones;
    }
}