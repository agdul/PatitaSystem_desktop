namespace PatitaSystem.Presentacion.Forms
{
    partial class FormAgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarProducto));
            PNL_Principal = new TableLayoutPanel();
            PNL_Izq = new Panel();
            PNL_ImgLogo = new Panel();
            IMG_Logo = new PictureBox();
            PNL_Guardar = new Panel();
            BTN_AgregarProducto = new MaterialSkin.Controls.MaterialButton();
            CAR_AgregarProducto = new MaterialSkin.Controls.MaterialCard();
            CBX_Categoria = new MaterialSkin.Controls.MaterialComboBox();
            CBX_Linea = new MaterialSkin.Controls.MaterialComboBox();
            TXTB_NombreProducto = new MaterialSkin.Controls.MaterialTextBox2();
            PNL_Der = new Panel();
            CAR_ProductoDer = new MaterialSkin.Controls.MaterialCard();
            PNL_AgregarProducto = new Panel();
            BTN_AgregarPresentacion = new MaterialSkin.Controls.MaterialButton();
            TXTB_PorcentajeAumento = new MaterialSkin.Controls.MaterialTextBox2();
            TXTB_NombrePresentacion = new MaterialSkin.Controls.MaterialTextBox2();
            TXT_Descripcion = new MaterialSkin.Controls.MaterialTextBox2();
            CBX_Productos = new MaterialSkin.Controls.MaterialComboBox();
            TXT_Stock = new MaterialSkin.Controls.MaterialTextBox2();
            TXT_PrecioDeCompra = new MaterialSkin.Controls.MaterialTextBox2();
            PNL_CARproducto = new Panel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            LBL_AgregarPresentacion = new MaterialSkin.Controls.MaterialLabel();
            CAR_Producto = new MaterialSkin.Controls.MaterialCard();
            LBL_Producto = new MaterialSkin.Controls.MaterialLabel();
            PNL_Principal.SuspendLayout();
            PNL_Izq.SuspendLayout();
            PNL_ImgLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IMG_Logo).BeginInit();
            PNL_Guardar.SuspendLayout();
            CAR_AgregarProducto.SuspendLayout();
            PNL_Der.SuspendLayout();
            CAR_ProductoDer.SuspendLayout();
            PNL_AgregarProducto.SuspendLayout();
            PNL_CARproducto.SuspendLayout();
            materialCard1.SuspendLayout();
            CAR_Producto.SuspendLayout();
            SuspendLayout();
            // 
            // PNL_Principal
            // 
            PNL_Principal.ColumnCount = 2;
            PNL_Principal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PNL_Principal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 438F));
            PNL_Principal.Controls.Add(PNL_Izq, 0, 0);
            PNL_Principal.Controls.Add(PNL_Der, 1, 0);
            PNL_Principal.Dock = DockStyle.Fill;
            PNL_Principal.Location = new Point(3, 45);
            PNL_Principal.Margin = new Padding(3, 2, 3, 2);
            PNL_Principal.Name = "PNL_Principal";
            PNL_Principal.RowCount = 1;
            PNL_Principal.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PNL_Principal.Size = new Size(807, 620);
            PNL_Principal.TabIndex = 0;
            // 
            // PNL_Izq
            // 
            PNL_Izq.Controls.Add(PNL_ImgLogo);
            PNL_Izq.Controls.Add(PNL_Guardar);
            PNL_Izq.Controls.Add(CAR_AgregarProducto);
            PNL_Izq.Dock = DockStyle.Left;
            PNL_Izq.Location = new Point(3, 2);
            PNL_Izq.Margin = new Padding(3, 2, 3, 2);
            PNL_Izq.Name = "PNL_Izq";
            PNL_Izq.Size = new Size(338, 616);
            PNL_Izq.TabIndex = 0;
            // 
            // PNL_ImgLogo
            // 
            PNL_ImgLogo.Controls.Add(IMG_Logo);
            PNL_ImgLogo.Location = new Point(12, 435);
            PNL_ImgLogo.Margin = new Padding(3, 2, 3, 2);
            PNL_ImgLogo.Name = "PNL_ImgLogo";
            PNL_ImgLogo.Size = new Size(294, 132);
            PNL_ImgLogo.TabIndex = 3;
            // 
            // IMG_Logo
            // 
            IMG_Logo.Dock = DockStyle.Fill;
            IMG_Logo.Image = Properties.Resources.logo2;
            IMG_Logo.Location = new Point(0, 0);
            IMG_Logo.Margin = new Padding(3, 2, 3, 2);
            IMG_Logo.Name = "IMG_Logo";
            IMG_Logo.Size = new Size(294, 132);
            IMG_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            IMG_Logo.TabIndex = 0;
            IMG_Logo.TabStop = false;
            // 
            // PNL_Guardar
            // 
            PNL_Guardar.Controls.Add(BTN_AgregarProducto);
            PNL_Guardar.Location = new Point(55, 350);
            PNL_Guardar.Margin = new Padding(3, 2, 3, 2);
            PNL_Guardar.Name = "PNL_Guardar";
            PNL_Guardar.Size = new Size(200, 38);
            PNL_Guardar.TabIndex = 2;
            // 
            // BTN_AgregarProducto
            // 
            BTN_AgregarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_AgregarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_AgregarProducto.Depth = 0;
            BTN_AgregarProducto.Dock = DockStyle.Fill;
            BTN_AgregarProducto.HighEmphasis = true;
            BTN_AgregarProducto.Icon = null;
            BTN_AgregarProducto.Location = new Point(0, 0);
            BTN_AgregarProducto.Margin = new Padding(4);
            BTN_AgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_AgregarProducto.Name = "BTN_AgregarProducto";
            BTN_AgregarProducto.NoAccentTextColor = Color.Empty;
            BTN_AgregarProducto.Size = new Size(200, 38);
            BTN_AgregarProducto.TabIndex = 1;
            BTN_AgregarProducto.Text = "Agregar Producto";
            BTN_AgregarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_AgregarProducto.UseAccentColor = false;
            BTN_AgregarProducto.UseVisualStyleBackColor = true;
            // 
            // CAR_AgregarProducto
            // 
            CAR_AgregarProducto.BackColor = Color.FromArgb(255, 255, 255);
            CAR_AgregarProducto.Controls.Add(CBX_Categoria);
            CAR_AgregarProducto.Controls.Add(CBX_Linea);
            CAR_AgregarProducto.Controls.Add(TXTB_NombreProducto);
            CAR_AgregarProducto.Depth = 0;
            CAR_AgregarProducto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CAR_AgregarProducto.Location = new Point(12, 54);
            CAR_AgregarProducto.Margin = new Padding(12, 10, 12, 10);
            CAR_AgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            CAR_AgregarProducto.Name = "CAR_AgregarProducto";
            CAR_AgregarProducto.Padding = new Padding(12, 10, 12, 10);
            CAR_AgregarProducto.Size = new Size(294, 252);
            CAR_AgregarProducto.TabIndex = 0;
            // 
            // CBX_Categoria
            // 
            CBX_Categoria.AutoResize = false;
            CBX_Categoria.BackColor = Color.FromArgb(255, 255, 255);
            CBX_Categoria.Depth = 0;
            CBX_Categoria.DrawMode = DrawMode.OwnerDrawVariable;
            CBX_Categoria.DropDownHeight = 174;
            CBX_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_Categoria.DropDownWidth = 121;
            CBX_Categoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBX_Categoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBX_Categoria.FormattingEnabled = true;
            CBX_Categoria.Hint = "Categoria";
            CBX_Categoria.IntegralHeight = false;
            CBX_Categoria.ItemHeight = 43;
            CBX_Categoria.Location = new Point(14, 100);
            CBX_Categoria.Margin = new Padding(3, 2, 3, 2);
            CBX_Categoria.MaxDropDownItems = 4;
            CBX_Categoria.MouseState = MaterialSkin.MouseState.OUT;
            CBX_Categoria.Name = "CBX_Categoria";
            CBX_Categoria.Size = new Size(265, 49);
            CBX_Categoria.StartIndex = 0;
            CBX_Categoria.TabIndex = 4;
            // 
            // CBX_Linea
            // 
            CBX_Linea.AutoResize = false;
            CBX_Linea.BackColor = Color.FromArgb(255, 255, 255);
            CBX_Linea.Depth = 0;
            CBX_Linea.DrawMode = DrawMode.OwnerDrawVariable;
            CBX_Linea.DropDownHeight = 174;
            CBX_Linea.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_Linea.DropDownWidth = 121;
            CBX_Linea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBX_Linea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBX_Linea.FormattingEnabled = true;
            CBX_Linea.Hint = "Linea";
            CBX_Linea.IntegralHeight = false;
            CBX_Linea.ItemHeight = 43;
            CBX_Linea.Location = new Point(14, 23);
            CBX_Linea.Margin = new Padding(3, 2, 3, 2);
            CBX_Linea.MaxDropDownItems = 4;
            CBX_Linea.MouseState = MaterialSkin.MouseState.OUT;
            CBX_Linea.Name = "CBX_Linea";
            CBX_Linea.Size = new Size(265, 49);
            CBX_Linea.StartIndex = 0;
            CBX_Linea.TabIndex = 5;
            // 
            // TXTB_NombreProducto
            // 
            TXTB_NombreProducto.AnimateReadOnly = false;
            TXTB_NombreProducto.BackgroundImageLayout = ImageLayout.None;
            TXTB_NombreProducto.CharacterCasing = CharacterCasing.Normal;
            TXTB_NombreProducto.Depth = 0;
            TXTB_NombreProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_NombreProducto.HideSelection = true;
            TXTB_NombreProducto.Hint = "Nombre Producto";
            TXTB_NombreProducto.LeadingIcon = null;
            TXTB_NombreProducto.Location = new Point(14, 171);
            TXTB_NombreProducto.Margin = new Padding(3, 2, 3, 2);
            TXTB_NombreProducto.MaxLength = 32767;
            TXTB_NombreProducto.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_NombreProducto.Name = "TXTB_NombreProducto";
            TXTB_NombreProducto.PasswordChar = '\0';
            TXTB_NombreProducto.PrefixSuffixText = null;
            TXTB_NombreProducto.ReadOnly = false;
            TXTB_NombreProducto.RightToLeft = RightToLeft.No;
            TXTB_NombreProducto.SelectedText = "";
            TXTB_NombreProducto.SelectionLength = 0;
            TXTB_NombreProducto.SelectionStart = 0;
            TXTB_NombreProducto.ShortcutsEnabled = true;
            TXTB_NombreProducto.Size = new Size(264, 48);
            TXTB_NombreProducto.TabIndex = 1;
            TXTB_NombreProducto.TabStop = false;
            TXTB_NombreProducto.TextAlign = HorizontalAlignment.Left;
            TXTB_NombreProducto.TrailingIcon = null;
            TXTB_NombreProducto.UseSystemPasswordChar = false;
            // 
            // PNL_Der
            // 
            PNL_Der.Controls.Add(CAR_ProductoDer);
            PNL_Der.Dock = DockStyle.Fill;
            PNL_Der.Location = new Point(372, 2);
            PNL_Der.Margin = new Padding(3, 2, 3, 2);
            PNL_Der.Name = "PNL_Der";
            PNL_Der.Padding = new Padding(25, 50, 25, 25);
            PNL_Der.Size = new Size(432, 616);
            PNL_Der.TabIndex = 1;
            // 
            // CAR_ProductoDer
            // 
            CAR_ProductoDer.BackColor = Color.FromArgb(255, 255, 255);
            CAR_ProductoDer.Controls.Add(PNL_AgregarProducto);
            CAR_ProductoDer.Controls.Add(TXTB_PorcentajeAumento);
            CAR_ProductoDer.Controls.Add(TXTB_NombrePresentacion);
            CAR_ProductoDer.Controls.Add(TXT_Descripcion);
            CAR_ProductoDer.Controls.Add(CBX_Productos);
            CAR_ProductoDer.Controls.Add(TXT_Stock);
            CAR_ProductoDer.Controls.Add(TXT_PrecioDeCompra);
            CAR_ProductoDer.Depth = 0;
            CAR_ProductoDer.Dock = DockStyle.Fill;
            CAR_ProductoDer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CAR_ProductoDer.Location = new Point(25, 50);
            CAR_ProductoDer.Margin = new Padding(12, 10, 12, 10);
            CAR_ProductoDer.MouseState = MaterialSkin.MouseState.HOVER;
            CAR_ProductoDer.Name = "CAR_ProductoDer";
            CAR_ProductoDer.Padding = new Padding(12, 10, 12, 10);
            CAR_ProductoDer.Size = new Size(382, 541);
            CAR_ProductoDer.TabIndex = 1;
            // 
            // PNL_AgregarProducto
            // 
            PNL_AgregarProducto.Controls.Add(BTN_AgregarPresentacion);
            PNL_AgregarProducto.Location = new Point(75, 464);
            PNL_AgregarProducto.Margin = new Padding(3, 2, 3, 2);
            PNL_AgregarProducto.Name = "PNL_AgregarProducto";
            PNL_AgregarProducto.Size = new Size(200, 38);
            PNL_AgregarProducto.TabIndex = 7;
            // 
            // BTN_AgregarPresentacion
            // 
            BTN_AgregarPresentacion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_AgregarPresentacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_AgregarPresentacion.Depth = 0;
            BTN_AgregarPresentacion.Dock = DockStyle.Fill;
            BTN_AgregarPresentacion.HighEmphasis = true;
            BTN_AgregarPresentacion.Icon = null;
            BTN_AgregarPresentacion.Location = new Point(0, 0);
            BTN_AgregarPresentacion.Margin = new Padding(4);
            BTN_AgregarPresentacion.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_AgregarPresentacion.Name = "BTN_AgregarPresentacion";
            BTN_AgregarPresentacion.NoAccentTextColor = Color.Empty;
            BTN_AgregarPresentacion.Size = new Size(200, 38);
            BTN_AgregarPresentacion.TabIndex = 1;
            BTN_AgregarPresentacion.Text = "Agregar Presentacion";
            BTN_AgregarPresentacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_AgregarPresentacion.UseAccentColor = false;
            BTN_AgregarPresentacion.UseVisualStyleBackColor = true;
            // 
            // TXTB_PorcentajeAumento
            // 
            TXTB_PorcentajeAumento.AnimateReadOnly = false;
            TXTB_PorcentajeAumento.BackgroundImageLayout = ImageLayout.None;
            TXTB_PorcentajeAumento.CharacterCasing = CharacterCasing.Normal;
            TXTB_PorcentajeAumento.Depth = 0;
            TXTB_PorcentajeAumento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_PorcentajeAumento.HideSelection = true;
            TXTB_PorcentajeAumento.Hint = "Porcentaje de Aumento";
            TXTB_PorcentajeAumento.LeadingIcon = null;
            TXTB_PorcentajeAumento.Location = new Point(54, 385);
            TXTB_PorcentajeAumento.Margin = new Padding(3, 2, 3, 2);
            TXTB_PorcentajeAumento.MaxLength = 32767;
            TXTB_PorcentajeAumento.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_PorcentajeAumento.Name = "TXTB_PorcentajeAumento";
            TXTB_PorcentajeAumento.PasswordChar = '\0';
            TXTB_PorcentajeAumento.PrefixSuffixText = null;
            TXTB_PorcentajeAumento.ReadOnly = false;
            TXTB_PorcentajeAumento.RightToLeft = RightToLeft.No;
            TXTB_PorcentajeAumento.SelectedText = "";
            TXTB_PorcentajeAumento.SelectionLength = 0;
            TXTB_PorcentajeAumento.SelectionStart = 0;
            TXTB_PorcentajeAumento.ShortcutsEnabled = true;
            TXTB_PorcentajeAumento.Size = new Size(264, 48);
            TXTB_PorcentajeAumento.TabIndex = 6;
            TXTB_PorcentajeAumento.TabStop = false;
            TXTB_PorcentajeAumento.TextAlign = HorizontalAlignment.Left;
            TXTB_PorcentajeAumento.TrailingIcon = null;
            TXTB_PorcentajeAumento.UseSystemPasswordChar = false;
            // 
            // TXTB_NombrePresentacion
            // 
            TXTB_NombrePresentacion.AnimateReadOnly = false;
            TXTB_NombrePresentacion.BackgroundImageLayout = ImageLayout.None;
            TXTB_NombrePresentacion.CharacterCasing = CharacterCasing.Normal;
            TXTB_NombrePresentacion.Depth = 0;
            TXTB_NombrePresentacion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_NombrePresentacion.HideSelection = true;
            TXTB_NombrePresentacion.Hint = "Nombre Presentacion";
            TXTB_NombrePresentacion.LeadingIcon = null;
            TXTB_NombrePresentacion.Location = new Point(54, 109);
            TXTB_NombrePresentacion.Margin = new Padding(3, 2, 3, 2);
            TXTB_NombrePresentacion.MaxLength = 32767;
            TXTB_NombrePresentacion.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_NombrePresentacion.Name = "TXTB_NombrePresentacion";
            TXTB_NombrePresentacion.PasswordChar = '\0';
            TXTB_NombrePresentacion.PrefixSuffixText = null;
            TXTB_NombrePresentacion.ReadOnly = false;
            TXTB_NombrePresentacion.RightToLeft = RightToLeft.No;
            TXTB_NombrePresentacion.SelectedText = "";
            TXTB_NombrePresentacion.SelectionLength = 0;
            TXTB_NombrePresentacion.SelectionStart = 0;
            TXTB_NombrePresentacion.ShortcutsEnabled = true;
            TXTB_NombrePresentacion.Size = new Size(264, 48);
            TXTB_NombrePresentacion.TabIndex = 5;
            TXTB_NombrePresentacion.TabStop = false;
            TXTB_NombrePresentacion.TextAlign = HorizontalAlignment.Left;
            TXTB_NombrePresentacion.TrailingIcon = null;
            TXTB_NombrePresentacion.UseSystemPasswordChar = false;
            // 
            // TXT_Descripcion
            // 
            TXT_Descripcion.AnimateReadOnly = false;
            TXT_Descripcion.BackgroundImageLayout = ImageLayout.None;
            TXT_Descripcion.CharacterCasing = CharacterCasing.Normal;
            TXT_Descripcion.Depth = 0;
            TXT_Descripcion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_Descripcion.HideSelection = true;
            TXT_Descripcion.Hint = "Descripcion";
            TXT_Descripcion.LeadingIcon = null;
            TXT_Descripcion.Location = new Point(54, 178);
            TXT_Descripcion.Margin = new Padding(3, 2, 3, 2);
            TXT_Descripcion.MaxLength = 32767;
            TXT_Descripcion.MouseState = MaterialSkin.MouseState.OUT;
            TXT_Descripcion.Name = "TXT_Descripcion";
            TXT_Descripcion.PasswordChar = '\0';
            TXT_Descripcion.PrefixSuffixText = null;
            TXT_Descripcion.ReadOnly = false;
            TXT_Descripcion.RightToLeft = RightToLeft.No;
            TXT_Descripcion.SelectedText = "";
            TXT_Descripcion.SelectionLength = 0;
            TXT_Descripcion.SelectionStart = 0;
            TXT_Descripcion.ShortcutsEnabled = true;
            TXT_Descripcion.Size = new Size(264, 48);
            TXT_Descripcion.TabIndex = 4;
            TXT_Descripcion.TabStop = false;
            TXT_Descripcion.TextAlign = HorizontalAlignment.Left;
            TXT_Descripcion.TrailingIcon = null;
            TXT_Descripcion.UseSystemPasswordChar = false;
            // 
            // CBX_Productos
            // 
            CBX_Productos.AutoResize = false;
            CBX_Productos.BackColor = Color.FromArgb(255, 255, 255);
            CBX_Productos.Depth = 0;
            CBX_Productos.DrawMode = DrawMode.OwnerDrawVariable;
            CBX_Productos.DropDownHeight = 174;
            CBX_Productos.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_Productos.DropDownWidth = 121;
            CBX_Productos.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBX_Productos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBX_Productos.FormattingEnabled = true;
            CBX_Productos.Hint = "Producto";
            CBX_Productos.IntegralHeight = false;
            CBX_Productos.ItemHeight = 43;
            CBX_Productos.Location = new Point(54, 39);
            CBX_Productos.Margin = new Padding(3, 2, 3, 2);
            CBX_Productos.MaxDropDownItems = 4;
            CBX_Productos.MouseState = MaterialSkin.MouseState.OUT;
            CBX_Productos.Name = "CBX_Productos";
            CBX_Productos.Size = new Size(264, 49);
            CBX_Productos.StartIndex = 0;
            CBX_Productos.TabIndex = 3;
            // 
            // TXT_Stock
            // 
            TXT_Stock.AnimateReadOnly = false;
            TXT_Stock.BackgroundImageLayout = ImageLayout.None;
            TXT_Stock.CharacterCasing = CharacterCasing.Normal;
            TXT_Stock.Depth = 0;
            TXT_Stock.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_Stock.HideSelection = true;
            TXT_Stock.Hint = "Stock";
            TXT_Stock.LeadingIcon = null;
            TXT_Stock.Location = new Point(54, 247);
            TXT_Stock.Margin = new Padding(3, 2, 3, 2);
            TXT_Stock.MaxLength = 32767;
            TXT_Stock.MouseState = MaterialSkin.MouseState.OUT;
            TXT_Stock.Name = "TXT_Stock";
            TXT_Stock.PasswordChar = '\0';
            TXT_Stock.PrefixSuffixText = null;
            TXT_Stock.ReadOnly = false;
            TXT_Stock.RightToLeft = RightToLeft.No;
            TXT_Stock.SelectedText = "";
            TXT_Stock.SelectionLength = 0;
            TXT_Stock.SelectionStart = 0;
            TXT_Stock.ShortcutsEnabled = true;
            TXT_Stock.Size = new Size(264, 48);
            TXT_Stock.TabIndex = 2;
            TXT_Stock.TabStop = false;
            TXT_Stock.TextAlign = HorizontalAlignment.Left;
            TXT_Stock.TrailingIcon = null;
            TXT_Stock.UseSystemPasswordChar = false;
            // 
            // TXT_PrecioDeCompra
            // 
            TXT_PrecioDeCompra.AnimateReadOnly = false;
            TXT_PrecioDeCompra.BackgroundImageLayout = ImageLayout.None;
            TXT_PrecioDeCompra.CharacterCasing = CharacterCasing.Normal;
            TXT_PrecioDeCompra.Depth = 0;
            TXT_PrecioDeCompra.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_PrecioDeCompra.HideSelection = true;
            TXT_PrecioDeCompra.Hint = "Precio de compra";
            TXT_PrecioDeCompra.LeadingIcon = null;
            TXT_PrecioDeCompra.Location = new Point(54, 316);
            TXT_PrecioDeCompra.Margin = new Padding(3, 2, 3, 2);
            TXT_PrecioDeCompra.MaxLength = 32767;
            TXT_PrecioDeCompra.MouseState = MaterialSkin.MouseState.OUT;
            TXT_PrecioDeCompra.Name = "TXT_PrecioDeCompra";
            TXT_PrecioDeCompra.PasswordChar = '\0';
            TXT_PrecioDeCompra.PrefixSuffixText = null;
            TXT_PrecioDeCompra.ReadOnly = false;
            TXT_PrecioDeCompra.RightToLeft = RightToLeft.No;
            TXT_PrecioDeCompra.SelectedText = "";
            TXT_PrecioDeCompra.SelectionLength = 0;
            TXT_PrecioDeCompra.SelectionStart = 0;
            TXT_PrecioDeCompra.ShortcutsEnabled = true;
            TXT_PrecioDeCompra.Size = new Size(264, 48);
            TXT_PrecioDeCompra.TabIndex = 3;
            TXT_PrecioDeCompra.TabStop = false;
            TXT_PrecioDeCompra.TextAlign = HorizontalAlignment.Left;
            TXT_PrecioDeCompra.TrailingIcon = null;
            TXT_PrecioDeCompra.UseSystemPasswordChar = false;
            // 
            // PNL_CARproducto
            // 
            PNL_CARproducto.Anchor = AnchorStyles.None;
            PNL_CARproducto.Controls.Add(materialCard1);
            PNL_CARproducto.Controls.Add(CAR_Producto);
            PNL_CARproducto.Location = new Point(3, 45);
            PNL_CARproducto.Margin = new Padding(3, 2, 3, 12);
            PNL_CARproducto.Name = "PNL_CARproducto";
            PNL_CARproducto.Size = new Size(864, 42);
            PNL_CARproducto.TabIndex = 1;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(LBL_AgregarPresentacion);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(451, 0);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(264, 37);
            materialCard1.TabIndex = 1;
            // 
            // LBL_AgregarPresentacion
            // 
            LBL_AgregarPresentacion.Anchor = AnchorStyles.None;
            LBL_AgregarPresentacion.AutoSize = true;
            LBL_AgregarPresentacion.Depth = 0;
            LBL_AgregarPresentacion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_AgregarPresentacion.Location = new Point(35, 8);
            LBL_AgregarPresentacion.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_AgregarPresentacion.Name = "LBL_AgregarPresentacion";
            LBL_AgregarPresentacion.Size = new Size(191, 19);
            LBL_AgregarPresentacion.TabIndex = 0;
            LBL_AgregarPresentacion.Text = "AGREGAR PRESENTACION";
            LBL_AgregarPresentacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CAR_Producto
            // 
            CAR_Producto.BackColor = Color.FromArgb(255, 255, 255);
            CAR_Producto.Controls.Add(LBL_Producto);
            CAR_Producto.Depth = 0;
            CAR_Producto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CAR_Producto.Location = new Point(29, 0);
            CAR_Producto.Margin = new Padding(12, 10, 12, 10);
            CAR_Producto.MouseState = MaterialSkin.MouseState.HOVER;
            CAR_Producto.Name = "CAR_Producto";
            CAR_Producto.Padding = new Padding(12, 10, 12, 10);
            CAR_Producto.Size = new Size(264, 37);
            CAR_Producto.TabIndex = 0;
            // 
            // LBL_Producto
            // 
            LBL_Producto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LBL_Producto.AutoSize = true;
            LBL_Producto.Depth = 0;
            LBL_Producto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Producto.Location = new Point(48, 8);
            LBL_Producto.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Producto.Name = "LBL_Producto";
            LBL_Producto.Size = new Size(159, 19);
            LBL_Producto.TabIndex = 0;
            LBL_Producto.Text = "AGREGAR PRODUCTO";
            LBL_Producto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 667);
            Controls.Add(PNL_CARproducto);
            Controls.Add(PNL_Principal);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(900, 900);
            MinimumSize = new Size(788, 518);
            Name = "FormAgregarProducto";
            Padding = new Padding(3, 45, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarProducto";
            PNL_Principal.ResumeLayout(false);
            PNL_Izq.ResumeLayout(false);
            PNL_ImgLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IMG_Logo).EndInit();
            PNL_Guardar.ResumeLayout(false);
            PNL_Guardar.PerformLayout();
            CAR_AgregarProducto.ResumeLayout(false);
            PNL_Der.ResumeLayout(false);
            CAR_ProductoDer.ResumeLayout(false);
            PNL_AgregarProducto.ResumeLayout(false);
            PNL_AgregarProducto.PerformLayout();
            PNL_CARproducto.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            CAR_Producto.ResumeLayout(false);
            CAR_Producto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PNL_Principal;
        private Panel PNL_CARproducto;
        private MaterialSkin.Controls.MaterialCard CAR_Producto;
        private MaterialSkin.Controls.MaterialLabel LBL_AgregarProducto;
        private MaterialSkin.Controls.MaterialComboBox CBX_Categoria;
        private MaterialSkin.Controls.MaterialComboBox CBX_Productos;
        private MaterialSkin.Controls.MaterialComboBox CBX_Linea;
        private MaterialSkin.Controls.MaterialCard CAR_ProductoDer;
        private Panel PNL_Izq;
        private MaterialSkin.Controls.MaterialCard CAR_AgregarProducto;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_Descripcion;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_PrecioDeCompra;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_Stock;
        private MaterialSkin.Controls.MaterialTextBox2 TXTB_NombreProducto;
        private Panel PNL_Der;
        private MaterialSkin.Controls.MaterialLabel LBL_Producto;
        private Panel PNL_Guardar;
        private MaterialSkin.Controls.MaterialButton BTN_AgregarProducto;
        private Panel PNL_ImgLogo;
        private PictureBox IMG_Logo;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel LBL_AgregarPresentacion;
        private MaterialSkin.Controls.MaterialTextBox2 TXTB_NombrePresentacion;
        private MaterialSkin.Controls.MaterialTextBox2 TXTB_PorcentajeAumento;
        private Panel PNL_AgregarProducto;
        private MaterialSkin.Controls.MaterialButton BTN_AgregarPresentacion;
    }
}