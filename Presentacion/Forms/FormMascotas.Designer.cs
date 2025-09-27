namespace PatitaSystem.Presentacion.Forms
{
    partial class FormMascotas
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
            LBL_Mascotas = new MaterialSkin.Controls.MaterialLabel();
            LIS_mascotas = new MaterialSkin.Controls.MaterialListView();
            CAR_Mascotas = new MaterialSkin.Controls.MaterialCard();
            BTN_Eliminar = new MaterialSkin.Controls.MaterialButton();
            BTN_Modificar = new MaterialSkin.Controls.MaterialButton();
            BTN_Agregar = new MaterialSkin.Controls.MaterialButton();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pictureBox1 = new PictureBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            CAR_Mascotas.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LBL_Mascotas
            // 
            LBL_Mascotas.AutoSize = true;
            LBL_Mascotas.Depth = 0;
            LBL_Mascotas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Mascotas.Location = new Point(342, 49);
            LBL_Mascotas.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Mascotas.Name = "LBL_Mascotas";
            LBL_Mascotas.Size = new Size(195, 19);
            LBL_Mascotas.TabIndex = 1;
            LBL_Mascotas.Text = "MASCOTAS REGISTRADAS";
            // 
            // LIS_mascotas
            // 
            LIS_mascotas.AutoSizeTable = false;
            LIS_mascotas.BackColor = Color.FromArgb(255, 255, 255);
            LIS_mascotas.BorderStyle = BorderStyle.None;
            LIS_mascotas.Depth = 0;
            LIS_mascotas.FullRowSelect = true;
            LIS_mascotas.Location = new Point(12, 39);
            LIS_mascotas.MinimumSize = new Size(200, 100);
            LIS_mascotas.MouseLocation = new Point(-1, -1);
            LIS_mascotas.MouseState = MaterialSkin.MouseState.OUT;
            LIS_mascotas.Name = "LIS_mascotas";
            LIS_mascotas.OwnerDraw = true;
            LIS_mascotas.Size = new Size(391, 230);
            LIS_mascotas.TabIndex = 2;
            LIS_mascotas.UseCompatibleStateImageBehavior = false;
            LIS_mascotas.View = View.Details;
            // 
            // CAR_Mascotas
            // 
            CAR_Mascotas.BackColor = Color.FromArgb(255, 255, 255);
            CAR_Mascotas.Controls.Add(BTN_Eliminar);
            CAR_Mascotas.Controls.Add(BTN_Modificar);
            CAR_Mascotas.Controls.Add(BTN_Agregar);
            CAR_Mascotas.Controls.Add(LIS_mascotas);
            CAR_Mascotas.Controls.Add(materialDivider1);
            CAR_Mascotas.Depth = 0;
            CAR_Mascotas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CAR_Mascotas.Location = new Point(17, 82);
            CAR_Mascotas.Margin = new Padding(14);
            CAR_Mascotas.MouseState = MaterialSkin.MouseState.HOVER;
            CAR_Mascotas.Name = "CAR_Mascotas";
            CAR_Mascotas.Padding = new Padding(14);
            CAR_Mascotas.Size = new Size(420, 394);
            CAR_Mascotas.TabIndex = 3;
            // 
            // BTN_Eliminar
            // 
            BTN_Eliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Eliminar.Depth = 0;
            BTN_Eliminar.HighEmphasis = true;
            BTN_Eliminar.Icon = null;
            BTN_Eliminar.Location = new Point(302, 338);
            BTN_Eliminar.Margin = new Padding(4, 6, 4, 6);
            BTN_Eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Eliminar.Name = "BTN_Eliminar";
            BTN_Eliminar.NoAccentTextColor = Color.Empty;
            BTN_Eliminar.Size = new Size(88, 36);
            BTN_Eliminar.TabIndex = 5;
            BTN_Eliminar.Text = "Eliminar";
            BTN_Eliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Eliminar.UseAccentColor = false;
            BTN_Eliminar.UseVisualStyleBackColor = true;
            // 
            // BTN_Modificar
            // 
            BTN_Modificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Modificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Modificar.Depth = 0;
            BTN_Modificar.HighEmphasis = true;
            BTN_Modificar.Icon = null;
            BTN_Modificar.Location = new Point(157, 338);
            BTN_Modificar.Margin = new Padding(4, 6, 4, 6);
            BTN_Modificar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Modificar.Name = "BTN_Modificar";
            BTN_Modificar.NoAccentTextColor = Color.Empty;
            BTN_Modificar.Size = new Size(99, 36);
            BTN_Modificar.TabIndex = 4;
            BTN_Modificar.Text = "Modificar";
            BTN_Modificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Modificar.UseAccentColor = false;
            BTN_Modificar.UseVisualStyleBackColor = true;
            // 
            // BTN_Agregar
            // 
            BTN_Agregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Agregar.Depth = 0;
            BTN_Agregar.HighEmphasis = true;
            BTN_Agregar.Icon = null;
            BTN_Agregar.Location = new Point(27, 338);
            BTN_Agregar.Margin = new Padding(4, 6, 4, 6);
            BTN_Agregar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Agregar.Name = "BTN_Agregar";
            BTN_Agregar.NoAccentTextColor = Color.Empty;
            BTN_Agregar.Size = new Size(88, 36);
            BTN_Agregar.TabIndex = 3;
            BTN_Agregar.Text = "Agregar";
            BTN_Agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Agregar.UseAccentColor = false;
            BTN_Agregar.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(0, 316);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(420, 78);
            materialDivider1.TabIndex = 1;
            materialDivider1.Text = "materialDivider1";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(materialLabel5);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(materialDivider2);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(447, 82);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(408, 394);
            materialCard1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.perro;
            pictureBox1.Location = new Point(97, 269);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(67, 233);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(75, 19);
            materialLabel5.TabIndex = 5;
            materialLabel5.Text = "Mascotas:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(67, 183);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(41, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Edad:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(67, 138);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(59, 19);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Especie:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(67, 92);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(61, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Nombre:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(126, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(171, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "DETALLE DE MASCOTA";
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(43, 56);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(324, 321);
            materialDivider2.TabIndex = 2;
            materialDivider2.Text = "materialDivider2";
            // 
            // FormMascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 501);
            Controls.Add(materialCard1);
            Controls.Add(CAR_Mascotas);
            Controls.Add(LBL_Mascotas);
            FormStyle = FormStyles.ActionBar_None;
            Name = "FormMascotas";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Form2";
            Load += Form2_Load;
            CAR_Mascotas.ResumeLayout(false);
            CAR_Mascotas.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LBL_Mascotas;
        private MaterialSkin.Controls.MaterialListView LIS_mascotas;
        private MaterialSkin.Controls.MaterialCard CAR_Mascotas;
        private MaterialSkin.Controls.MaterialButton BTN_Eliminar;
        private MaterialSkin.Controls.MaterialButton BTN_Modificar;
        private MaterialSkin.Controls.MaterialButton BTN_Agregar;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}