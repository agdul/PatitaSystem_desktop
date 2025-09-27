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
            CAR_Carrito = new MaterialSkin.Controls.MaterialCard();
            LBL_Carrito = new Label();
            TABS_Carrito = new MaterialSkin.Controls.MaterialTabSelector();
            TABC_Carrito = new MaterialSkin.Controls.MaterialTabControl();
            TAB_Producto = new TabPage();
            BTN_Carrito = new MaterialSkin.Controls.MaterialButton();
            LIS_ProductoC = new MaterialSkin.Controls.MaterialListView();
            TAB_Carrito = new TabPage();
            BTN_Vaciar = new MaterialSkin.Controls.MaterialButton();
            BTN_Eliminar = new MaterialSkin.Controls.MaterialButton();
            LIS_Carrito = new MaterialSkin.Controls.MaterialListView();
            TAB_Finalizar = new TabPage();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            LIS_Compra = new MaterialSkin.Controls.MaterialListView();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            Total = new Label();
            LBL_Total = new Label();
            Descuento = new Label();
            label1 = new Label();
            Subtotal = new Label();
            LBL_Subtotal = new Label();
            BTN_Confirmar = new MaterialSkin.Controls.MaterialButton();
            BTN_Volver = new MaterialSkin.Controls.MaterialButton();
            CAR_Carrito.SuspendLayout();
            TABC_Carrito.SuspendLayout();
            TAB_Producto.SuspendLayout();
            TAB_Carrito.SuspendLayout();
            TAB_Finalizar.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // CAR_Carrito
            // 
            CAR_Carrito.BackColor = Color.FromArgb(255, 255, 255);
            CAR_Carrito.Controls.Add(LBL_Carrito);
            CAR_Carrito.Depth = 0;
            CAR_Carrito.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CAR_Carrito.Location = new Point(116, 38);
            CAR_Carrito.Margin = new Padding(14);
            CAR_Carrito.MouseState = MaterialSkin.MouseState.HOVER;
            CAR_Carrito.Name = "CAR_Carrito";
            CAR_Carrito.Padding = new Padding(14);
            CAR_Carrito.Size = new Size(579, 58);
            CAR_Carrito.TabIndex = 0;
            // 
            // LBL_Carrito
            // 
            LBL_Carrito.AutoSize = true;
            LBL_Carrito.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LBL_Carrito.Location = new Point(208, 16);
            LBL_Carrito.Name = "LBL_Carrito";
            LBL_Carrito.Size = new Size(192, 28);
            LBL_Carrito.TabIndex = 0;
            LBL_Carrito.Text = "Carrito de compras";
            // 
            // TABS_Carrito
            // 
            TABS_Carrito.BaseTabControl = null;
            //TABS_Carrito.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            TABS_Carrito.Depth = 0;
            TABS_Carrito.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TABS_Carrito.Location = new Point(109, 124);
            TABS_Carrito.MouseState = MaterialSkin.MouseState.HOVER;
            TABS_Carrito.Name = "TABS_Carrito";
            TABS_Carrito.Size = new Size(591, 60);
            TABS_Carrito.TabIndex = 1;
            TABS_Carrito.Text = "materialTabSelector1";
            // 
            // TABC_Carrito
            // 
            TABC_Carrito.Controls.Add(TAB_Producto);
            TABC_Carrito.Controls.Add(TAB_Carrito);
            TABC_Carrito.Controls.Add(TAB_Finalizar);
            TABC_Carrito.Depth = 0;
            TABC_Carrito.Location = new Point(104, 190);
            TABC_Carrito.MouseState = MaterialSkin.MouseState.HOVER;
            TABC_Carrito.Multiline = true;
            TABC_Carrito.Name = "TABC_Carrito";
            TABC_Carrito.SelectedIndex = 0;
            TABC_Carrito.Size = new Size(600, 308);
            TABC_Carrito.TabIndex = 2;
            // 
            // TAB_Producto
            // 
            TAB_Producto.Controls.Add(BTN_Carrito);
            TAB_Producto.Controls.Add(LIS_ProductoC);
            TAB_Producto.Location = new Point(4, 29);
            TAB_Producto.Name = "TAB_Producto";
            TAB_Producto.Padding = new Padding(3);
            TAB_Producto.Size = new Size(592, 275);
            TAB_Producto.TabIndex = 0;
            TAB_Producto.Text = "Productos";
            TAB_Producto.UseVisualStyleBackColor = true;
            // 
            // BTN_Carrito
            // 
            BTN_Carrito.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Carrito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Carrito.Depth = 0;
            BTN_Carrito.HighEmphasis = true;
            BTN_Carrito.Icon = null;
            BTN_Carrito.Location = new Point(216, 230);
            BTN_Carrito.Margin = new Padding(4, 6, 4, 6);
            BTN_Carrito.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Carrito.Name = "BTN_Carrito";
            BTN_Carrito.NoAccentTextColor = Color.Empty;
            BTN_Carrito.Size = new Size(173, 36);
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
            LIS_ProductoC.Location = new Point(3, 3);
            LIS_ProductoC.MinimumSize = new Size(200, 100);
            LIS_ProductoC.MouseLocation = new Point(-1, -1);
            LIS_ProductoC.MouseState = MaterialSkin.MouseState.OUT;
            LIS_ProductoC.Name = "LIS_ProductoC";
            LIS_ProductoC.OwnerDraw = true;
            LIS_ProductoC.Size = new Size(586, 269);
            LIS_ProductoC.TabIndex = 0;
            LIS_ProductoC.UseCompatibleStateImageBehavior = false;
            LIS_ProductoC.View = View.Details;
            // 
            // TAB_Carrito
            // 
            TAB_Carrito.Controls.Add(BTN_Vaciar);
            TAB_Carrito.Controls.Add(BTN_Eliminar);
            TAB_Carrito.Controls.Add(LIS_Carrito);
            TAB_Carrito.Location = new Point(4, 29);
            TAB_Carrito.Name = "TAB_Carrito";
            TAB_Carrito.Padding = new Padding(3);
            TAB_Carrito.Size = new Size(592, 275);
            TAB_Carrito.TabIndex = 1;
            TAB_Carrito.Text = "Carrito";
            TAB_Carrito.UseVisualStyleBackColor = true;
            // 
            // BTN_Vaciar
            // 
            BTN_Vaciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Vaciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Vaciar.Depth = 0;
            BTN_Vaciar.HighEmphasis = true;
            BTN_Vaciar.Icon = null;
            BTN_Vaciar.Location = new Point(229, 230);
            BTN_Vaciar.Margin = new Padding(4, 6, 4, 6);
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
            // BTN_Eliminar
            // 
            BTN_Eliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Eliminar.Depth = 0;
            BTN_Eliminar.HighEmphasis = true;
            BTN_Eliminar.Icon = null;
            BTN_Eliminar.Location = new Point(74, 230);
            BTN_Eliminar.Margin = new Padding(4, 6, 4, 6);
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
            // LIS_Carrito
            // 
            LIS_Carrito.AutoSizeTable = false;
            LIS_Carrito.BackColor = Color.FromArgb(255, 255, 255);
            LIS_Carrito.BorderStyle = BorderStyle.None;
            LIS_Carrito.Depth = 0;
            LIS_Carrito.Dock = DockStyle.Fill;
            LIS_Carrito.FullRowSelect = true;
            LIS_Carrito.Location = new Point(3, 3);
            LIS_Carrito.MinimumSize = new Size(200, 100);
            LIS_Carrito.MouseLocation = new Point(-1, -1);
            LIS_Carrito.MouseState = MaterialSkin.MouseState.OUT;
            LIS_Carrito.Name = "LIS_Carrito";
            LIS_Carrito.OwnerDraw = true;
            LIS_Carrito.Size = new Size(586, 269);
            LIS_Carrito.TabIndex = 0;
            LIS_Carrito.UseCompatibleStateImageBehavior = false;
            LIS_Carrito.View = View.Details;
            // 
            // TAB_Finalizar
            // 
            TAB_Finalizar.Controls.Add(BTN_Volver);
            TAB_Finalizar.Controls.Add(BTN_Confirmar);
            TAB_Finalizar.Controls.Add(materialLabel1);
            TAB_Finalizar.Controls.Add(LIS_Compra);
            TAB_Finalizar.Controls.Add(materialCard1);
            TAB_Finalizar.Location = new Point(4, 29);
            TAB_Finalizar.Name = "TAB_Finalizar";
            TAB_Finalizar.Padding = new Padding(3);
            TAB_Finalizar.Size = new Size(592, 275);
            TAB_Finalizar.TabIndex = 2;
            TAB_Finalizar.Text = "Finalizar";
            TAB_Finalizar.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = SystemColors.ControlLightLight;
            materialLabel1.Location = new Point(187, 4);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(115, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Lista de compra";
            // 
            // LIS_Compra
            // 
            LIS_Compra.AutoSizeTable = false;
            LIS_Compra.BackColor = Color.FromArgb(255, 255, 255);
            LIS_Compra.BorderStyle = BorderStyle.None;
            LIS_Compra.Depth = 0;
            LIS_Compra.FullRowSelect = true;
            LIS_Compra.Location = new Point(1, 26);
            LIS_Compra.MinimumSize = new Size(200, 100);
            LIS_Compra.MouseLocation = new Point(-1, -1);
            LIS_Compra.MouseState = MaterialSkin.MouseState.OUT;
            LIS_Compra.Name = "LIS_Compra";
            LIS_Compra.OwnerDraw = true;
            LIS_Compra.Size = new Size(588, 110);
            LIS_Compra.TabIndex = 0;
            LIS_Compra.UseCompatibleStateImageBehavior = false;
            LIS_Compra.View = View.Details;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(Total);
            materialCard1.Controls.Add(LBL_Total);
            materialCard1.Controls.Add(Descuento);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(Subtotal);
            materialCard1.Controls.Add(LBL_Subtotal);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(328, 138);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(250, 137);
            materialCard1.TabIndex = 0;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(141, 92);
            Total.Name = "Total";
            Total.Size = new Size(57, 20);
            Total.TabIndex = 5;
            Total.Text = "$$$$$$";
            // 
            // LBL_Total
            // 
            LBL_Total.AutoSize = true;
            LBL_Total.Location = new Point(51, 92);
            LBL_Total.Name = "LBL_Total";
            LBL_Total.Size = new Size(57, 20);
            LBL_Total.TabIndex = 0;
            LBL_Total.Text = "TOTAL: ";
            // 
            // Descuento
            // 
            Descuento.AutoSize = true;
            Descuento.Location = new Point(143, 59);
            Descuento.Name = "Descuento";
            Descuento.Size = new Size(57, 20);
            Descuento.TabIndex = 3;
            Descuento.Text = "$$$$$$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 59);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "Descuento:";
            label1.Click += label1_Click;
            // 
            // Subtotal
            // 
            Subtotal.AutoSize = true;
            Subtotal.Location = new Point(141, 23);
            Subtotal.Name = "Subtotal";
            Subtotal.Size = new Size(57, 20);
            Subtotal.TabIndex = 1;
            Subtotal.Text = "$$$$$$";
            // 
            // LBL_Subtotal
            // 
            LBL_Subtotal.AutoSize = true;
            LBL_Subtotal.Location = new Point(51, 23);
            LBL_Subtotal.Name = "LBL_Subtotal";
            LBL_Subtotal.Size = new Size(68, 20);
            LBL_Subtotal.TabIndex = 0;
            LBL_Subtotal.Text = "Subtotal:";
            // 
            // BTN_Confirmar
            // 
            BTN_Confirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Confirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Confirmar.Depth = 0;
            BTN_Confirmar.HighEmphasis = true;
            BTN_Confirmar.Icon = null;
            BTN_Confirmar.Location = new Point(74, 214);
            BTN_Confirmar.Margin = new Padding(4, 6, 4, 6);
            BTN_Confirmar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Confirmar.Name = "BTN_Confirmar";
            BTN_Confirmar.NoAccentTextColor = Color.Empty;
            BTN_Confirmar.Size = new Size(170, 36);
            BTN_Confirmar.TabIndex = 1;
            BTN_Confirmar.Text = "Confirmar Compra";
            BTN_Confirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Confirmar.UseAccentColor = false;
            BTN_Confirmar.UseVisualStyleBackColor = true;
            // 
            // BTN_Volver
            // 
            BTN_Volver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Volver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Volver.Depth = 0;
            BTN_Volver.HighEmphasis = true;
            BTN_Volver.Icon = null;
            BTN_Volver.Location = new Point(74, 166);
            BTN_Volver.Margin = new Padding(4, 6, 4, 6);
            BTN_Volver.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Volver.Name = "BTN_Volver";
            BTN_Volver.NoAccentTextColor = Color.Empty;
            BTN_Volver.Size = new Size(162, 36);
            BTN_Volver.TabIndex = 2;
            BTN_Volver.Text = "Volver al carrito";
            BTN_Volver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Volver.UseAccentColor = false;
            BTN_Volver.UseVisualStyleBackColor = true;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 535);
            Controls.Add(TABC_Carrito);
            Controls.Add(TABS_Carrito);
            Controls.Add(CAR_Carrito);
            FormStyle = FormStyles.ActionBar_None;
            Name = "FormCarrito";
            Padding = new Padding(3, 24, 3, 3);
            Text = "FormCarrito";
            Load += FormCarrito_Load;
            CAR_Carrito.ResumeLayout(false);
            CAR_Carrito.PerformLayout();
            TABC_Carrito.ResumeLayout(false);
            TAB_Producto.ResumeLayout(false);
            TAB_Producto.PerformLayout();
            TAB_Carrito.ResumeLayout(false);
            TAB_Carrito.PerformLayout();
            TAB_Finalizar.ResumeLayout(false);
            TAB_Finalizar.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard CAR_Carrito;
        private Label LBL_Carrito;
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView LIS_Compra;
        private Label LBL_Subtotal;
        private Label Descuento;
        private Label label1;
        private Label Subtotal;
        private Label Total;
        private Label LBL_Total;
        private MaterialSkin.Controls.MaterialButton BTN_Volver;
        private MaterialSkin.Controls.MaterialButton BTN_Confirmar;
    }
}