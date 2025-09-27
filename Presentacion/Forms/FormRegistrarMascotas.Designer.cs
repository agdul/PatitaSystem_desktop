namespace PatitaSystem.Presentacion.Forms
{
    partial class FormRegistrarMascotas
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pictureBox1 = new PictureBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            TXTB_EspecieAnimal = new MaterialSkin.Controls.MaterialTextBox2();
            TXTB_Raza = new MaterialSkin.Controls.MaterialTextBox2();
            TXTB_Dueño = new MaterialSkin.Controls.MaterialTextBox2();
            TXT_Edad = new MaterialSkin.Controls.MaterialTextBox2();
            CBX_Especie = new MaterialSkin.Controls.MaterialComboBox();
            TXTB_Nombre = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(materialButton1);
            materialCard1.Controls.Add(TXTB_EspecieAnimal);
            materialCard1.Controls.Add(TXTB_Raza);
            materialCard1.Controls.Add(TXTB_Dueño);
            materialCard1.Controls.Add(TXT_Edad);
            materialCard1.Controls.Add(CBX_Especie);
            materialCard1.Controls.Add(TXTB_Nombre);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(89, 38);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(482, 422);
            materialCard1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(266, 314);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(67, 340);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(88, 36);
            materialButton1.TabIndex = 6;
            materialButton1.Text = "Guardar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // TXTB_EspecieAnimal
            // 
            TXTB_EspecieAnimal.AnimateReadOnly = false;
            TXTB_EspecieAnimal.BackgroundImageLayout = ImageLayout.None;
            TXTB_EspecieAnimal.CharacterCasing = CharacterCasing.Normal;
            TXTB_EspecieAnimal.Depth = 0;
            TXTB_EspecieAnimal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_EspecieAnimal.HideSelection = true;
            TXTB_EspecieAnimal.LeadingIcon = null;
            TXTB_EspecieAnimal.Location = new Point(255, 248);
            TXTB_EspecieAnimal.MaxLength = 32767;
            TXTB_EspecieAnimal.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_EspecieAnimal.Name = "TXTB_EspecieAnimal";
            TXTB_EspecieAnimal.PasswordChar = '\0';
            TXTB_EspecieAnimal.PrefixSuffixText = null;
            TXTB_EspecieAnimal.ReadOnly = false;
            TXTB_EspecieAnimal.RightToLeft = RightToLeft.No;
            TXTB_EspecieAnimal.SelectedText = "";
            TXTB_EspecieAnimal.SelectionLength = 0;
            TXTB_EspecieAnimal.SelectionStart = 0;
            TXTB_EspecieAnimal.ShortcutsEnabled = true;
            TXTB_EspecieAnimal.Size = new Size(210, 48);
            TXTB_EspecieAnimal.TabIndex = 5;
            TXTB_EspecieAnimal.TabStop = false;
            TXTB_EspecieAnimal.TextAlign = HorizontalAlignment.Left;
            TXTB_EspecieAnimal.TrailingIcon = null;
            TXTB_EspecieAnimal.UseSystemPasswordChar = false;
            // 
            // TXTB_Raza
            // 
            TXTB_Raza.AnimateReadOnly = false;
            TXTB_Raza.BackgroundImageLayout = ImageLayout.None;
            TXTB_Raza.CharacterCasing = CharacterCasing.Normal;
            TXTB_Raza.Depth = 0;
            TXTB_Raza.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Raza.HideSelection = true;
            TXTB_Raza.LeadingIcon = null;
            TXTB_Raza.Location = new Point(255, 167);
            TXTB_Raza.MaxLength = 32767;
            TXTB_Raza.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Raza.Name = "TXTB_Raza";
            TXTB_Raza.PasswordChar = '\0';
            TXTB_Raza.PrefixSuffixText = null;
            TXTB_Raza.ReadOnly = false;
            TXTB_Raza.RightToLeft = RightToLeft.No;
            TXTB_Raza.SelectedText = "";
            TXTB_Raza.SelectionLength = 0;
            TXTB_Raza.SelectionStart = 0;
            TXTB_Raza.ShortcutsEnabled = true;
            TXTB_Raza.Size = new Size(210, 48);
            TXTB_Raza.TabIndex = 4;
            TXTB_Raza.TabStop = false;
            TXTB_Raza.TextAlign = HorizontalAlignment.Left;
            TXTB_Raza.TrailingIcon = null;
            TXTB_Raza.UseSystemPasswordChar = false;
            // 
            // TXTB_Dueño
            // 
            TXTB_Dueño.AnimateReadOnly = false;
            TXTB_Dueño.BackgroundImageLayout = ImageLayout.None;
            TXTB_Dueño.CharacterCasing = CharacterCasing.Normal;
            TXTB_Dueño.Depth = 0;
            TXTB_Dueño.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Dueño.HideSelection = true;
            TXTB_Dueño.LeadingIcon = null;
            TXTB_Dueño.Location = new Point(255, 88);
            TXTB_Dueño.MaxLength = 32767;
            TXTB_Dueño.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Dueño.Name = "TXTB_Dueño";
            TXTB_Dueño.PasswordChar = '\0';
            TXTB_Dueño.PrefixSuffixText = null;
            TXTB_Dueño.ReadOnly = false;
            TXTB_Dueño.RightToLeft = RightToLeft.No;
            TXTB_Dueño.SelectedText = "";
            TXTB_Dueño.SelectionLength = 0;
            TXTB_Dueño.SelectionStart = 0;
            TXTB_Dueño.ShortcutsEnabled = true;
            TXTB_Dueño.Size = new Size(210, 48);
            TXTB_Dueño.TabIndex = 3;
            TXTB_Dueño.TabStop = false;
            TXTB_Dueño.TextAlign = HorizontalAlignment.Left;
            TXTB_Dueño.TrailingIcon = null;
            TXTB_Dueño.UseSystemPasswordChar = false;
            // 
            // TXT_Edad
            // 
            TXT_Edad.AnimateReadOnly = false;
            TXT_Edad.BackgroundImageLayout = ImageLayout.None;
            TXT_Edad.CharacterCasing = CharacterCasing.Normal;
            TXT_Edad.Depth = 0;
            TXT_Edad.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_Edad.HideSelection = true;
            TXT_Edad.LeadingIcon = null;
            TXT_Edad.Location = new Point(17, 248);
            TXT_Edad.MaxLength = 32767;
            TXT_Edad.MouseState = MaterialSkin.MouseState.OUT;
            TXT_Edad.Name = "TXT_Edad";
            TXT_Edad.PasswordChar = '\0';
            TXT_Edad.PrefixSuffixText = null;
            TXT_Edad.ReadOnly = false;
            TXT_Edad.RightToLeft = RightToLeft.No;
            TXT_Edad.SelectedText = "";
            TXT_Edad.SelectionLength = 0;
            TXT_Edad.SelectionStart = 0;
            TXT_Edad.ShortcutsEnabled = true;
            TXT_Edad.Size = new Size(210, 48);
            TXT_Edad.TabIndex = 2;
            TXT_Edad.TabStop = false;
            TXT_Edad.TextAlign = HorizontalAlignment.Left;
            TXT_Edad.TrailingIcon = null;
            TXT_Edad.UseSystemPasswordChar = false;
            // 
            // CBX_Especie
            // 
            CBX_Especie.AutoResize = false;
            CBX_Especie.BackColor = Color.FromArgb(255, 255, 255);
            CBX_Especie.Depth = 0;
            CBX_Especie.DrawMode = DrawMode.OwnerDrawVariable;
            CBX_Especie.DropDownHeight = 174;
            CBX_Especie.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_Especie.DropDownWidth = 121;
            CBX_Especie.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBX_Especie.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBX_Especie.FormattingEnabled = true;
            CBX_Especie.IntegralHeight = false;
            CBX_Especie.ItemHeight = 43;
            CBX_Especie.Location = new Point(17, 167);
            CBX_Especie.MaxDropDownItems = 4;
            CBX_Especie.MouseState = MaterialSkin.MouseState.OUT;
            CBX_Especie.Name = "CBX_Especie";
            CBX_Especie.Size = new Size(210, 49);
            CBX_Especie.StartIndex = 0;
            CBX_Especie.TabIndex = 1;
            // 
            // TXTB_Nombre
            // 
            TXTB_Nombre.AnimateReadOnly = false;
            TXTB_Nombre.BackgroundImageLayout = ImageLayout.None;
            TXTB_Nombre.CharacterCasing = CharacterCasing.Normal;
            TXTB_Nombre.Depth = 0;
            TXTB_Nombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Nombre.HideSelection = true;
            TXTB_Nombre.LeadingIcon = null;
            TXTB_Nombre.Location = new Point(17, 88);
            TXTB_Nombre.MaxLength = 32767;
            TXTB_Nombre.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Nombre.Name = "TXTB_Nombre";
            TXTB_Nombre.PasswordChar = '\0';
            TXTB_Nombre.PrefixSuffixText = null;
            TXTB_Nombre.ReadOnly = false;
            TXTB_Nombre.RightToLeft = RightToLeft.No;
            TXTB_Nombre.SelectedText = "";
            TXTB_Nombre.SelectionLength = 0;
            TXTB_Nombre.SelectionStart = 0;
            TXTB_Nombre.ShortcutsEnabled = true;
            TXTB_Nombre.Size = new Size(210, 48);
            TXTB_Nombre.TabIndex = 0;
            TXTB_Nombre.TabStop = false;
            TXTB_Nombre.TextAlign = HorizontalAlignment.Left;
            TXTB_Nombre.TrailingIcon = null;
            TXTB_Nombre.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialLabel1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(89, 38);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(482, 52);
            materialCard2.TabIndex = 1;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(158, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(161, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "AGREGAR MASCOTAS";
            // 
            // FormRegistrarMascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 535);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "FormRegistrarMascotas";
            Padding = new Padding(3, 24, 3, 3);
            Text = "FormRegistrarMascotas";
            Load += FormRegistrarMascotas_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 TXTB_Nombre;
        private MaterialSkin.Controls.MaterialComboBox CBX_Especie;
        private MaterialSkin.Controls.MaterialTextBox2 TXTB_Dueño;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_Edad;
        private MaterialSkin.Controls.MaterialTextBox2 TXTB_Raza;
        private MaterialSkin.Controls.MaterialTextBox2 TXTB_EspecieAnimal;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}