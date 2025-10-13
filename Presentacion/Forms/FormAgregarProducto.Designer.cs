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
            BTN_Guardar = new MaterialSkin.Controls.MaterialButton();
            CAR_AgregarProducto = new MaterialSkin.Controls.MaterialCard();
            TXT_Descripcion = new MaterialSkin.Controls.MaterialTextBox2();
            TXT_PrecioDeCompra = new MaterialSkin.Controls.MaterialTextBox2();
            TXT_Stock = new MaterialSkin.Controls.MaterialTextBox2();
            TXTB_NombreProducto = new MaterialSkin.Controls.MaterialTextBox2();
            PNL_Der = new Panel();
            PNL_Imagen = new Panel();
            CAR_Imagen = new MaterialSkin.Controls.MaterialCard();
            BTN_Buscar = new MaterialSkin.Controls.MaterialButton();
            IMG_Producto = new PictureBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            CAR_ProductoDer = new MaterialSkin.Controls.MaterialCard();
            CBX_Estado = new MaterialSkin.Controls.MaterialComboBox();
            CBX_Linea = new MaterialSkin.Controls.MaterialComboBox();
            CBX_Categoria = new MaterialSkin.Controls.MaterialComboBox();
            PNL_CARproducto = new Panel();
            CAR_Producto = new MaterialSkin.Controls.MaterialCard();
            LBL_Producto = new MaterialSkin.Controls.MaterialLabel();
            PNL_Principal.SuspendLayout();
            PNL_Izq.SuspendLayout();
            PNL_ImgLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IMG_Logo).BeginInit();
            PNL_Guardar.SuspendLayout();
            CAR_AgregarProducto.SuspendLayout();
            PNL_Der.SuspendLayout();
            PNL_Imagen.SuspendLayout();
            CAR_Imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IMG_Producto).BeginInit();
            CAR_ProductoDer.SuspendLayout();
            PNL_CARproducto.SuspendLayout();
            CAR_Producto.SuspendLayout();
            SuspendLayout();
            // 
            // PNL_Principal
            // 
            PNL_Principal.ColumnCount = 2;
            PNL_Principal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PNL_Principal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330F));
            PNL_Principal.Controls.Add(PNL_Izq, 0, 0);
            PNL_Principal.Controls.Add(PNL_Der, 1, 0);
            PNL_Principal.Location = new Point(64, 71);
            PNL_Principal.Margin = new Padding(3, 2, 3, 2);
            PNL_Principal.Name = "PNL_Principal";
            PNL_Principal.RowCount = 1;
            PNL_Principal.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PNL_Principal.Size = new Size(662, 442);
            PNL_Principal.TabIndex = 0;
            // 
            // PNL_Izq
            // 
            PNL_Izq.Controls.Add(PNL_ImgLogo);
            PNL_Izq.Controls.Add(PNL_Guardar);
            PNL_Izq.Controls.Add(CAR_AgregarProducto);
            PNL_Izq.Location = new Point(3, 2);
            PNL_Izq.Margin = new Padding(3, 2, 3, 2);
            PNL_Izq.Name = "PNL_Izq";
            PNL_Izq.Size = new Size(323, 437);
            PNL_Izq.TabIndex = 0;
            // 
            // PNL_ImgLogo
            // 
            PNL_ImgLogo.Controls.Add(IMG_Logo);
            PNL_ImgLogo.Location = new Point(45, 331);
            PNL_ImgLogo.Margin = new Padding(3, 2, 3, 2);
            PNL_ImgLogo.Name = "PNL_ImgLogo";
            PNL_ImgLogo.Size = new Size(219, 94);
            PNL_ImgLogo.TabIndex = 3;
            // 
            // IMG_Logo
            // 
            IMG_Logo.Image = Properties.Resources.logo2;
            IMG_Logo.Location = new Point(3, 2);
            IMG_Logo.Margin = new Padding(3, 2, 3, 2);
            IMG_Logo.Name = "IMG_Logo";
            IMG_Logo.Size = new Size(214, 89);
            IMG_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            IMG_Logo.TabIndex = 0;
            IMG_Logo.TabStop = false;
            // 
            // PNL_Guardar
            // 
            PNL_Guardar.Controls.Add(BTN_Guardar);
            PNL_Guardar.Location = new Point(101, 289);
            PNL_Guardar.Margin = new Padding(3, 2, 3, 2);
            PNL_Guardar.Name = "PNL_Guardar";
            PNL_Guardar.Size = new Size(104, 38);
            PNL_Guardar.TabIndex = 2;
            // 
            // BTN_Guardar
            // 
            BTN_Guardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Guardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Guardar.Depth = 0;
            BTN_Guardar.HighEmphasis = true;
            BTN_Guardar.Icon = null;
            BTN_Guardar.Location = new Point(14, 4);
            BTN_Guardar.Margin = new Padding(4, 4, 4, 4);
            BTN_Guardar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Guardar.Name = "BTN_Guardar";
            BTN_Guardar.NoAccentTextColor = Color.Empty;
            BTN_Guardar.Size = new Size(88, 36);
            BTN_Guardar.TabIndex = 1;
            BTN_Guardar.Text = "GUARDAR";
            BTN_Guardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Guardar.UseAccentColor = false;
            BTN_Guardar.UseVisualStyleBackColor = true;
            // 
            // CAR_AgregarProducto
            // 
            CAR_AgregarProducto.BackColor = Color.FromArgb(255, 255, 255);
            CAR_AgregarProducto.Controls.Add(TXT_Descripcion);
            CAR_AgregarProducto.Controls.Add(TXT_PrecioDeCompra);
            CAR_AgregarProducto.Controls.Add(TXT_Stock);
            CAR_AgregarProducto.Controls.Add(TXTB_NombreProducto);
            CAR_AgregarProducto.Depth = 0;
            CAR_AgregarProducto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CAR_AgregarProducto.Location = new Point(17, 10);
            CAR_AgregarProducto.Margin = new Padding(12, 10, 12, 10);
            CAR_AgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            CAR_AgregarProducto.Name = "CAR_AgregarProducto";
            CAR_AgregarProducto.Padding = new Padding(12, 10, 12, 10);
            CAR_AgregarProducto.Size = new Size(294, 266);
            CAR_AgregarProducto.TabIndex = 0;
            // 
            // TXT_Descripcion
            // 
            TXT_Descripcion.AnimateReadOnly = false;
            TXT_Descripcion.BackgroundImageLayout = ImageLayout.None;
            TXT_Descripcion.CharacterCasing = CharacterCasing.Normal;
            TXT_Descripcion.Depth = 0;
            TXT_Descripcion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_Descripcion.HideSelection = true;
            TXT_Descripcion.LeadingIcon = null;
            TXT_Descripcion.Location = new Point(15, 212);
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
            // TXT_PrecioDeCompra
            // 
            TXT_PrecioDeCompra.AnimateReadOnly = false;
            TXT_PrecioDeCompra.BackgroundImageLayout = ImageLayout.None;
            TXT_PrecioDeCompra.CharacterCasing = CharacterCasing.Normal;
            TXT_PrecioDeCompra.Depth = 0;
            TXT_PrecioDeCompra.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_PrecioDeCompra.HideSelection = true;
            TXT_PrecioDeCompra.LeadingIcon = null;
            TXT_PrecioDeCompra.Location = new Point(15, 142);
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
            // TXT_Stock
            // 
            TXT_Stock.AnimateReadOnly = false;
            TXT_Stock.BackgroundImageLayout = ImageLayout.None;
            TXT_Stock.CharacterCasing = CharacterCasing.Normal;
            TXT_Stock.Depth = 0;
            TXT_Stock.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_Stock.HideSelection = true;
            TXT_Stock.LeadingIcon = null;
            TXT_Stock.Location = new Point(15, 76);
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
            // TXTB_NombreProducto
            // 
            TXTB_NombreProducto.AnimateReadOnly = false;
            TXTB_NombreProducto.BackgroundImageLayout = ImageLayout.None;
            TXTB_NombreProducto.CharacterCasing = CharacterCasing.Normal;
            TXTB_NombreProducto.Depth = 0;
            TXTB_NombreProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_NombreProducto.HideSelection = true;
            TXTB_NombreProducto.LeadingIcon = null;
            TXTB_NombreProducto.Location = new Point(15, 13);
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
            PNL_Der.Controls.Add(PNL_Imagen);
            PNL_Der.Controls.Add(CAR_ProductoDer);
            PNL_Der.Location = new Point(335, 2);
            PNL_Der.Margin = new Padding(3, 2, 3, 2);
            PNL_Der.Name = "PNL_Der";
            PNL_Der.Size = new Size(323, 402);
            PNL_Der.TabIndex = 1;
            // 
            // PNL_Imagen
            // 
            PNL_Imagen.Controls.Add(CAR_Imagen);
            PNL_Imagen.Location = new Point(12, 222);
            PNL_Imagen.Margin = new Padding(3, 2, 3, 2);
            PNL_Imagen.Name = "PNL_Imagen";
            PNL_Imagen.Size = new Size(294, 178);
            PNL_Imagen.TabIndex = 2;
            // 
            // CAR_Imagen
            // 
            CAR_Imagen.BackColor = Color.FromArgb(255, 255, 255);
            CAR_Imagen.Controls.Add(BTN_Buscar);
            CAR_Imagen.Controls.Add(IMG_Producto);
            CAR_Imagen.Controls.Add(materialLabel1);
            CAR_Imagen.Depth = 0;
            CAR_Imagen.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CAR_Imagen.Location = new Point(12, 0);
            CAR_Imagen.Margin = new Padding(12, 10, 12, 10);
            CAR_Imagen.MouseState = MaterialSkin.MouseState.HOVER;
            CAR_Imagen.Name = "CAR_Imagen";
            CAR_Imagen.Padding = new Padding(12, 10, 12, 10);
            CAR_Imagen.Size = new Size(270, 178);
            CAR_Imagen.TabIndex = 0;
            // 
            // BTN_Buscar
            // 
            BTN_Buscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Buscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Buscar.Depth = 0;
            BTN_Buscar.HighEmphasis = true;
            BTN_Buscar.Icon = null;
            BTN_Buscar.Image = Properties.Resources.buscador;
            BTN_Buscar.Location = new Point(106, 136);
            BTN_Buscar.Margin = new Padding(4, 4, 4, 4);
            BTN_Buscar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Buscar.Name = "BTN_Buscar";
            BTN_Buscar.NoAccentTextColor = Color.Empty;
            BTN_Buscar.Size = new Size(77, 36);
            BTN_Buscar.TabIndex = 2;
            BTN_Buscar.Text = "BUSCAR";
            BTN_Buscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Buscar.UseAccentColor = false;
            BTN_Buscar.UseVisualStyleBackColor = true;
            // 
            // IMG_Producto
            // 
            IMG_Producto.BackColor = Color.Transparent;
            IMG_Producto.Location = new Point(46, 38);
            IMG_Producto.Margin = new Padding(3, 2, 3, 2);
            IMG_Producto.Name = "IMG_Producto";
            IMG_Producto.Size = new Size(183, 90);
            IMG_Producto.SizeMode = PictureBoxSizeMode.Zoom;
            IMG_Producto.TabIndex = 1;
            IMG_Producto.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(61, 10);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(167, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "SELECCIONAR IMAGEN";
            // 
            // CAR_ProductoDer
            // 
            CAR_ProductoDer.BackColor = Color.FromArgb(255, 255, 255);
            CAR_ProductoDer.Controls.Add(CBX_Estado);
            CAR_ProductoDer.Controls.Add(CBX_Linea);
            CAR_ProductoDer.Controls.Add(CBX_Categoria);
            CAR_ProductoDer.Depth = 0;
            CAR_ProductoDer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CAR_ProductoDer.Location = new Point(12, 10);
            CAR_ProductoDer.Margin = new Padding(12, 10, 12, 10);
            CAR_ProductoDer.MouseState = MaterialSkin.MouseState.HOVER;
            CAR_ProductoDer.Name = "CAR_ProductoDer";
            CAR_ProductoDer.Padding = new Padding(12, 10, 12, 10);
            CAR_ProductoDer.Size = new Size(294, 199);
            CAR_ProductoDer.TabIndex = 1;
            // 
            // CBX_Estado
            // 
            CBX_Estado.AutoResize = false;
            CBX_Estado.BackColor = Color.FromArgb(255, 255, 255);
            CBX_Estado.Depth = 0;
            CBX_Estado.DrawMode = DrawMode.OwnerDrawVariable;
            CBX_Estado.DropDownHeight = 174;
            CBX_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_Estado.DropDownWidth = 121;
            CBX_Estado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBX_Estado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBX_Estado.FormattingEnabled = true;
            CBX_Estado.IntegralHeight = false;
            CBX_Estado.ItemHeight = 43;
            CBX_Estado.Location = new Point(15, 12);
            CBX_Estado.Margin = new Padding(3, 2, 3, 2);
            CBX_Estado.MaxDropDownItems = 4;
            CBX_Estado.MouseState = MaterialSkin.MouseState.OUT;
            CBX_Estado.Name = "CBX_Estado";
            CBX_Estado.Size = new Size(265, 49);
            CBX_Estado.StartIndex = 0;
            CBX_Estado.TabIndex = 3;
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
            CBX_Linea.IntegralHeight = false;
            CBX_Linea.ItemHeight = 43;
            CBX_Linea.Location = new Point(15, 142);
            CBX_Linea.Margin = new Padding(3, 2, 3, 2);
            CBX_Linea.MaxDropDownItems = 4;
            CBX_Linea.MouseState = MaterialSkin.MouseState.OUT;
            CBX_Linea.Name = "CBX_Linea";
            CBX_Linea.Size = new Size(265, 49);
            CBX_Linea.StartIndex = 0;
            CBX_Linea.TabIndex = 5;
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
            CBX_Categoria.IntegralHeight = false;
            CBX_Categoria.ItemHeight = 43;
            CBX_Categoria.Location = new Point(15, 76);
            CBX_Categoria.Margin = new Padding(3, 2, 3, 2);
            CBX_Categoria.MaxDropDownItems = 4;
            CBX_Categoria.MouseState = MaterialSkin.MouseState.OUT;
            CBX_Categoria.Name = "CBX_Categoria";
            CBX_Categoria.Size = new Size(265, 49);
            CBX_Categoria.StartIndex = 0;
            CBX_Categoria.TabIndex = 4;
            // 
            // PNL_CARproducto
            // 
            PNL_CARproducto.Controls.Add(CAR_Producto);
            PNL_CARproducto.Location = new Point(64, 30);
            PNL_CARproducto.Margin = new Padding(3, 2, 3, 2);
            PNL_CARproducto.Name = "PNL_CARproducto";
            PNL_CARproducto.Size = new Size(662, 37);
            PNL_CARproducto.TabIndex = 1;
            // 
            // CAR_Producto
            // 
            CAR_Producto.BackColor = Color.FromArgb(255, 255, 255);
            CAR_Producto.Controls.Add(LBL_Producto);
            CAR_Producto.Depth = 0;
            CAR_Producto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CAR_Producto.Location = new Point(12, 0);
            CAR_Producto.Margin = new Padding(12, 10, 12, 10);
            CAR_Producto.MouseState = MaterialSkin.MouseState.HOVER;
            CAR_Producto.Name = "CAR_Producto";
            CAR_Producto.Padding = new Padding(12, 10, 12, 10);
            CAR_Producto.Size = new Size(637, 37);
            CAR_Producto.TabIndex = 0;
            // 
            // LBL_Producto
            // 
            LBL_Producto.AutoSize = true;
            LBL_Producto.Depth = 0;
            LBL_Producto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Producto.Location = new Point(248, 10);
            LBL_Producto.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Producto.Name = "LBL_Producto";
            LBL_Producto.Size = new Size(159, 19);
            LBL_Producto.TabIndex = 0;
            LBL_Producto.Text = "AGREGAR PRODUCTO";
            // 
            // FormAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 518);
            Controls.Add(PNL_CARproducto);
            Controls.Add(PNL_Principal);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(788, 518);
            MinimumSize = new Size(788, 518);
            Name = "FormAgregarProducto";
            Padding = new Padding(3, 18, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarProducto";
            Load += FormAgregarProducto_Load;
            PNL_Principal.ResumeLayout(false);
            PNL_Izq.ResumeLayout(false);
            PNL_ImgLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IMG_Logo).EndInit();
            PNL_Guardar.ResumeLayout(false);
            PNL_Guardar.PerformLayout();
            CAR_AgregarProducto.ResumeLayout(false);
            PNL_Der.ResumeLayout(false);
            PNL_Imagen.ResumeLayout(false);
            CAR_Imagen.ResumeLayout(false);
            CAR_Imagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IMG_Producto).EndInit();
            CAR_ProductoDer.ResumeLayout(false);
            PNL_CARproducto.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialComboBox CBX_Estado;
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
        private Panel PNL_Imagen;
        private MaterialSkin.Controls.MaterialCard CAR_Imagen;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox IMG_Producto;
        private MaterialSkin.Controls.MaterialButton BTN_Buscar;
        private Panel PNL_Guardar;
        private MaterialSkin.Controls.MaterialButton BTN_Guardar;
        private Panel PNL_ImgLogo;
        private PictureBox IMG_Logo;
    }
}