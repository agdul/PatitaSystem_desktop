namespace PatitaSystem.Presentacion.Forms
{
    partial class FormRegistrarUsuario
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
            CARD_Usuario = new MaterialSkin.Controls.MaterialCard();
            TXTB_Password = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Password = new MaterialSkin.Controls.MaterialLabel();
            LBL_Nacimiento = new MaterialSkin.Controls.MaterialLabel();
            DTP_Nacimiento = new DateTimePicker();
            TXTB_Mail = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Email = new MaterialSkin.Controls.MaterialLabel();
            LBL_Rol = new MaterialSkin.Controls.MaterialLabel();
            TXTB_Celular = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Celular = new MaterialSkin.Controls.MaterialLabel();
            TXTB_Dni = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Dni = new MaterialSkin.Controls.MaterialLabel();
            TXTB_Apellido = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Apellido = new MaterialSkin.Controls.MaterialLabel();
            LBL_Nombre = new MaterialSkin.Controls.MaterialLabel();
            MCB_Rol = new MaterialSkin.Controls.MaterialComboBox();
            TXTB_Nombre = new MaterialSkin.Controls.MaterialTextBox();
            BTN_GuardarUsuario = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            LBL_Opcional = new Label();
            TXTB_Dpto = new MaterialSkin.Controls.MaterialTextBox();
            TXTB_Piso = new MaterialSkin.Controls.MaterialTextBox();
            TXTB_Altura = new MaterialSkin.Controls.MaterialTextBox();
            TXTB_Calle = new MaterialSkin.Controls.MaterialTextBox();
            TXTB_CodigoPostal = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Direccion = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            CARD_Usuario.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // CARD_Usuario
            // 
            CARD_Usuario.BackColor = Color.FromArgb(255, 255, 255);
            CARD_Usuario.BorderStyle = BorderStyle.FixedSingle;
            CARD_Usuario.Controls.Add(TXTB_Password);
            CARD_Usuario.Controls.Add(LBL_Password);
            CARD_Usuario.Controls.Add(LBL_Nacimiento);
            CARD_Usuario.Controls.Add(DTP_Nacimiento);
            CARD_Usuario.Controls.Add(TXTB_Mail);
            CARD_Usuario.Controls.Add(LBL_Email);
            CARD_Usuario.Controls.Add(LBL_Rol);
            CARD_Usuario.Controls.Add(TXTB_Celular);
            CARD_Usuario.Controls.Add(LBL_Celular);
            CARD_Usuario.Controls.Add(TXTB_Dni);
            CARD_Usuario.Controls.Add(LBL_Dni);
            CARD_Usuario.Controls.Add(TXTB_Apellido);
            CARD_Usuario.Controls.Add(LBL_Apellido);
            CARD_Usuario.Controls.Add(LBL_Nombre);
            CARD_Usuario.Controls.Add(MCB_Rol);
            CARD_Usuario.Controls.Add(TXTB_Nombre);
            CARD_Usuario.Depth = 0;
            CARD_Usuario.Dock = DockStyle.Left;
            CARD_Usuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CARD_Usuario.Location = new Point(14, 14);
            CARD_Usuario.Margin = new Padding(12, 10, 12, 10);
            CARD_Usuario.MouseState = MaterialSkin.MouseState.HOVER;
            CARD_Usuario.Name = "CARD_Usuario";
            CARD_Usuario.Padding = new Padding(12, 10, 12, 10);
            CARD_Usuario.Size = new Size(355, 537);
            CARD_Usuario.TabIndex = 0;
            // 
            // TXTB_Password
            // 
            TXTB_Password.AnimateReadOnly = false;
            TXTB_Password.BorderStyle = BorderStyle.None;
            TXTB_Password.Depth = 0;
            TXTB_Password.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Password.LeadingIcon = null;
            TXTB_Password.Location = new Point(128, 380);
            TXTB_Password.Margin = new Padding(3, 2, 3, 2);
            TXTB_Password.MaxLength = 50;
            TXTB_Password.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Password.Multiline = false;
            TXTB_Password.Name = "TXTB_Password";
            TXTB_Password.Size = new Size(153, 50);
            TXTB_Password.TabIndex = 22;
            TXTB_Password.Text = "";
            TXTB_Password.TrailingIcon = null;
            // 
            // LBL_Password
            // 
            LBL_Password.AutoSize = true;
            LBL_Password.Depth = 0;
            LBL_Password.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Password.Location = new Point(32, 392);
            LBL_Password.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Password.Name = "LBL_Password";
            LBL_Password.Size = new Size(71, 19);
            LBL_Password.TabIndex = 21;
            LBL_Password.Text = "Password";
            // 
            // LBL_Nacimiento
            // 
            LBL_Nacimiento.AutoSize = true;
            LBL_Nacimiento.Depth = 0;
            LBL_Nacimiento.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Nacimiento.Location = new Point(90, 455);
            LBL_Nacimiento.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Nacimiento.Name = "LBL_Nacimiento";
            LBL_Nacimiento.Size = new Size(148, 19);
            LBL_Nacimiento.TabIndex = 11;
            LBL_Nacimiento.Text = "Fecha de nacimiento";
            // 
            // DTP_Nacimiento
            // 
            DTP_Nacimiento.Location = new Point(27, 481);
            DTP_Nacimiento.Margin = new Padding(3, 2, 3, 2);
            DTP_Nacimiento.MaxDate = new DateTime(2099, 12, 24, 0, 0, 0, 0);
            DTP_Nacimiento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DTP_Nacimiento.Name = "DTP_Nacimiento";
            DTP_Nacimiento.Size = new Size(268, 23);
            DTP_Nacimiento.TabIndex = 12;
            DTP_Nacimiento.Value = new DateTime(1998, 1, 1, 0, 0, 0, 0);
            // 
            // TXTB_Mail
            // 
            TXTB_Mail.AnimateReadOnly = false;
            TXTB_Mail.BorderStyle = BorderStyle.None;
            TXTB_Mail.Depth = 0;
            TXTB_Mail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Mail.LeadingIcon = null;
            TXTB_Mail.Location = new Point(128, 317);
            TXTB_Mail.Margin = new Padding(3, 2, 3, 2);
            TXTB_Mail.MaxLength = 50;
            TXTB_Mail.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Mail.Multiline = false;
            TXTB_Mail.Name = "TXTB_Mail";
            TXTB_Mail.Size = new Size(153, 50);
            TXTB_Mail.TabIndex = 19;
            TXTB_Mail.Text = "";
            TXTB_Mail.TrailingIcon = null;
            // 
            // LBL_Email
            // 
            LBL_Email.AutoSize = true;
            LBL_Email.Depth = 0;
            LBL_Email.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Email.Location = new Point(32, 328);
            LBL_Email.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Email.Name = "LBL_Email";
            LBL_Email.Size = new Size(41, 19);
            LBL_Email.TabIndex = 18;
            LBL_Email.Text = "Email";
            // 
            // LBL_Rol
            // 
            LBL_Rol.AutoSize = true;
            LBL_Rol.Depth = 0;
            LBL_Rol.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Rol.Location = new Point(32, 267);
            LBL_Rol.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Rol.Name = "LBL_Rol";
            LBL_Rol.Size = new Size(24, 19);
            LBL_Rol.TabIndex = 15;
            LBL_Rol.Text = "Rol";
            // 
            // TXTB_Celular
            // 
            TXTB_Celular.AnimateReadOnly = false;
            TXTB_Celular.BorderStyle = BorderStyle.None;
            TXTB_Celular.Depth = 0;
            TXTB_Celular.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Celular.LeadingIcon = null;
            TXTB_Celular.Location = new Point(128, 193);
            TXTB_Celular.Margin = new Padding(3, 2, 3, 2);
            TXTB_Celular.MaxLength = 50;
            TXTB_Celular.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Celular.Multiline = false;
            TXTB_Celular.Name = "TXTB_Celular";
            TXTB_Celular.Size = new Size(153, 50);
            TXTB_Celular.TabIndex = 14;
            TXTB_Celular.Text = "";
            TXTB_Celular.TrailingIcon = null;
            TXTB_Celular.KeyPress += TXTB_Celular_KeyPress;
            // 
            // LBL_Celular
            // 
            LBL_Celular.AutoSize = true;
            LBL_Celular.Depth = 0;
            LBL_Celular.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Celular.Location = new Point(32, 202);
            LBL_Celular.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Celular.Name = "LBL_Celular";
            LBL_Celular.Size = new Size(50, 19);
            LBL_Celular.TabIndex = 13;
            LBL_Celular.Text = "Celular";
            // 
            // TXTB_Dni
            // 
            TXTB_Dni.AnimateReadOnly = false;
            TXTB_Dni.BorderStyle = BorderStyle.None;
            TXTB_Dni.Depth = 0;
            TXTB_Dni.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Dni.LeadingIcon = null;
            TXTB_Dni.Location = new Point(128, 130);
            TXTB_Dni.Margin = new Padding(3, 2, 3, 2);
            TXTB_Dni.MaxLength = 50;
            TXTB_Dni.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Dni.Multiline = false;
            TXTB_Dni.Name = "TXTB_Dni";
            TXTB_Dni.Size = new Size(153, 50);
            TXTB_Dni.TabIndex = 10;
            TXTB_Dni.Text = "";
            TXTB_Dni.TrailingIcon = null;
            TXTB_Dni.KeyPress += TXTB_Dni_KeyPress;
            // 
            // LBL_Dni
            // 
            LBL_Dni.AutoSize = true;
            LBL_Dni.Depth = 0;
            LBL_Dni.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Dni.Location = new Point(32, 140);
            LBL_Dni.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Dni.Name = "LBL_Dni";
            LBL_Dni.Size = new Size(27, 19);
            LBL_Dni.TabIndex = 9;
            LBL_Dni.Text = "DNI";
            // 
            // TXTB_Apellido
            // 
            TXTB_Apellido.AnimateReadOnly = false;
            TXTB_Apellido.BorderStyle = BorderStyle.None;
            TXTB_Apellido.Depth = 0;
            TXTB_Apellido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Apellido.LeadingIcon = null;
            TXTB_Apellido.Location = new Point(128, 70);
            TXTB_Apellido.Margin = new Padding(3, 2, 3, 2);
            TXTB_Apellido.MaxLength = 50;
            TXTB_Apellido.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Apellido.Multiline = false;
            TXTB_Apellido.Name = "TXTB_Apellido";
            TXTB_Apellido.Size = new Size(153, 50);
            TXTB_Apellido.TabIndex = 8;
            TXTB_Apellido.Text = "";
            TXTB_Apellido.TrailingIcon = null;
            TXTB_Apellido.KeyPress += TXTB_Apellido_KeyPress;
            // 
            // LBL_Apellido
            // 
            LBL_Apellido.AutoSize = true;
            LBL_Apellido.Depth = 0;
            LBL_Apellido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Apellido.Location = new Point(32, 79);
            LBL_Apellido.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Apellido.Name = "LBL_Apellido";
            LBL_Apellido.Size = new Size(58, 19);
            LBL_Apellido.TabIndex = 7;
            LBL_Apellido.Text = "Apellido";
            // 
            // LBL_Nombre
            // 
            LBL_Nombre.AutoSize = true;
            LBL_Nombre.Depth = 0;
            LBL_Nombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Nombre.Location = new Point(32, 25);
            LBL_Nombre.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Nombre.Name = "LBL_Nombre";
            LBL_Nombre.Size = new Size(57, 19);
            LBL_Nombre.TabIndex = 6;
            LBL_Nombre.Text = "Nombre";
            // 
            // MCB_Rol
            // 
            MCB_Rol.AutoResize = false;
            MCB_Rol.BackColor = Color.FromArgb(255, 255, 255);
            MCB_Rol.Depth = 0;
            MCB_Rol.DrawMode = DrawMode.OwnerDrawVariable;
            MCB_Rol.DropDownHeight = 174;
            MCB_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            MCB_Rol.DropDownWidth = 121;
            MCB_Rol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            MCB_Rol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MCB_Rol.FormattingEnabled = true;
            MCB_Rol.IntegralHeight = false;
            MCB_Rol.ItemHeight = 43;
            MCB_Rol.Location = new Point(128, 256);
            MCB_Rol.Margin = new Padding(3, 2, 3, 2);
            MCB_Rol.MaxDropDownItems = 4;
            MCB_Rol.MouseState = MaterialSkin.MouseState.OUT;
            MCB_Rol.Name = "MCB_Rol";
            MCB_Rol.Size = new Size(154, 49);
            MCB_Rol.StartIndex = 0;
            MCB_Rol.TabIndex = 5;
            // 
            // TXTB_Nombre
            // 
            TXTB_Nombre.AnimateReadOnly = false;
            TXTB_Nombre.BorderStyle = BorderStyle.None;
            TXTB_Nombre.Depth = 0;
            TXTB_Nombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Nombre.LeadingIcon = null;
            TXTB_Nombre.Location = new Point(128, 15);
            TXTB_Nombre.Margin = new Padding(3, 2, 3, 2);
            TXTB_Nombre.MaxLength = 50;
            TXTB_Nombre.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Nombre.Multiline = false;
            TXTB_Nombre.Name = "TXTB_Nombre";
            TXTB_Nombre.Size = new Size(153, 50);
            TXTB_Nombre.TabIndex = 2;
            TXTB_Nombre.Text = "";
            TXTB_Nombre.TrailingIcon = null;
            TXTB_Nombre.KeyPress += TXTB_Nombre_KeyPress;
            // 
            // BTN_GuardarUsuario
            // 
            BTN_GuardarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_GuardarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_GuardarUsuario.Depth = 0;
            BTN_GuardarUsuario.HighEmphasis = true;
            BTN_GuardarUsuario.Icon = null;
            BTN_GuardarUsuario.Location = new Point(125, 331);
            BTN_GuardarUsuario.Margin = new Padding(4);
            BTN_GuardarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_GuardarUsuario.Name = "BTN_GuardarUsuario";
            BTN_GuardarUsuario.NoAccentTextColor = Color.Empty;
            BTN_GuardarUsuario.Size = new Size(132, 36);
            BTN_GuardarUsuario.TabIndex = 17;
            BTN_GuardarUsuario.Text = "Guardar Usuario";
            BTN_GuardarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_GuardarUsuario.UseAccentColor = false;
            BTN_GuardarUsuario.UseVisualStyleBackColor = true;
            BTN_GuardarUsuario.Click += BTN_Crear_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.BorderStyle = BorderStyle.FixedSingle;
            materialCard1.Controls.Add(LBL_Opcional);
            materialCard1.Controls.Add(TXTB_Dpto);
            materialCard1.Controls.Add(BTN_GuardarUsuario);
            materialCard1.Controls.Add(TXTB_Piso);
            materialCard1.Controls.Add(TXTB_Altura);
            materialCard1.Controls.Add(TXTB_Calle);
            materialCard1.Controls.Add(TXTB_CodigoPostal);
            materialCard1.Controls.Add(LBL_Direccion);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Right;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(399, 14);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(365, 537);
            materialCard1.TabIndex = 16;
            // 
            // LBL_Opcional
            // 
            LBL_Opcional.AutoSize = true;
            LBL_Opcional.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_Opcional.Location = new Point(147, 165);
            LBL_Opcional.Name = "LBL_Opcional";
            LBL_Opcional.Size = new Size(64, 15);
            LBL_Opcional.TabIndex = 22;
            LBL_Opcional.Text = "Opcional";
            // 
            // TXTB_Dpto
            // 
            TXTB_Dpto.AnimateReadOnly = false;
            TXTB_Dpto.BorderStyle = BorderStyle.None;
            TXTB_Dpto.Depth = 0;
            TXTB_Dpto.Font = new Font("Microsoft Sans Serif", 12F);
            TXTB_Dpto.LeadingIcon = null;
            TXTB_Dpto.Location = new Point(210, 199);
            TXTB_Dpto.Margin = new Padding(3, 2, 3, 2);
            TXTB_Dpto.MaxLength = 50;
            TXTB_Dpto.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Dpto.Multiline = false;
            TXTB_Dpto.Name = "TXTB_Dpto";
            TXTB_Dpto.Size = new Size(125, 50);
            TXTB_Dpto.TabIndex = 21;
            TXTB_Dpto.Text = "Dpto Nro";
            TXTB_Dpto.TrailingIcon = null;
            // 
            // TXTB_Piso
            // 
            TXTB_Piso.AnimateReadOnly = false;
            TXTB_Piso.BorderStyle = BorderStyle.None;
            TXTB_Piso.Depth = 0;
            TXTB_Piso.Font = new Font("Microsoft Sans Serif", 12F);
            TXTB_Piso.LeadingIcon = null;
            TXTB_Piso.Location = new Point(35, 199);
            TXTB_Piso.Margin = new Padding(3, 2, 3, 2);
            TXTB_Piso.MaxLength = 50;
            TXTB_Piso.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Piso.Multiline = false;
            TXTB_Piso.Name = "TXTB_Piso";
            TXTB_Piso.Size = new Size(125, 50);
            TXTB_Piso.TabIndex = 20;
            TXTB_Piso.Text = "Piso";
            TXTB_Piso.TrailingIcon = null;
            // 
            // TXTB_Altura
            // 
            TXTB_Altura.AnimateReadOnly = false;
            TXTB_Altura.BorderStyle = BorderStyle.None;
            TXTB_Altura.Depth = 0;
            TXTB_Altura.Font = new Font("Microsoft Sans Serif", 12F);
            TXTB_Altura.LeadingIcon = null;
            TXTB_Altura.Location = new Point(35, 94);
            TXTB_Altura.Margin = new Padding(3, 2, 3, 2);
            TXTB_Altura.MaxLength = 50;
            TXTB_Altura.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Altura.Multiline = false;
            TXTB_Altura.Name = "TXTB_Altura";
            TXTB_Altura.Size = new Size(125, 50);
            TXTB_Altura.TabIndex = 19;
            TXTB_Altura.Text = "Altura";
            TXTB_Altura.TrailingIcon = null;
            // 
            // TXTB_Calle
            // 
            TXTB_Calle.AnimateReadOnly = false;
            TXTB_Calle.BorderStyle = BorderStyle.None;
            TXTB_Calle.Depth = 0;
            TXTB_Calle.Font = new Font("Microsoft Sans Serif", 12F);
            TXTB_Calle.LeadingIcon = null;
            TXTB_Calle.Location = new Point(35, 27);
            TXTB_Calle.Margin = new Padding(3, 2, 3, 2);
            TXTB_Calle.MaxLength = 50;
            TXTB_Calle.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Calle.Multiline = false;
            TXTB_Calle.Name = "TXTB_Calle";
            TXTB_Calle.Size = new Size(300, 50);
            TXTB_Calle.TabIndex = 18;
            TXTB_Calle.Text = "Calle";
            TXTB_Calle.TrailingIcon = null;
            // 
            // TXTB_CodigoPostal
            // 
            TXTB_CodigoPostal.AnimateReadOnly = false;
            TXTB_CodigoPostal.BorderStyle = BorderStyle.None;
            TXTB_CodigoPostal.Depth = 0;
            TXTB_CodigoPostal.Font = new Font("Microsoft Sans Serif", 12F);
            TXTB_CodigoPostal.LeadingIcon = null;
            TXTB_CodigoPostal.Location = new Point(210, 94);
            TXTB_CodigoPostal.Margin = new Padding(3, 2, 3, 2);
            TXTB_CodigoPostal.MaxLength = 50;
            TXTB_CodigoPostal.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_CodigoPostal.Multiline = false;
            TXTB_CodigoPostal.Name = "TXTB_CodigoPostal";
            TXTB_CodigoPostal.Size = new Size(125, 50);
            TXTB_CodigoPostal.TabIndex = 17;
            TXTB_CodigoPostal.Text = "Codigo Postal";
            TXTB_CodigoPostal.TrailingIcon = null;
            // 
            // LBL_Direccion
            // 
            LBL_Direccion.AutoSize = true;
            LBL_Direccion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_Direccion.Location = new Point(147, 10);
            LBL_Direccion.Name = "LBL_Direccion";
            LBL_Direccion.Size = new Size(68, 15);
            LBL_Direccion.TabIndex = 0;
            LBL_Direccion.Text = "Dirección";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.BackgroundImageLayout = ImageLayout.None;
            materialCard2.Controls.Add(CARD_Usuario);
            materialCard2.Controls.Add(materialCard1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(64, 64);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(778, 565);
            materialCard2.TabIndex = 1;
            // 
            // FormRegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 684);
            Controls.Add(materialCard2);
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRegistrarUsuario";
            Padding = new Padding(50);
            Text = "Usuario";
            CARD_Usuario.ResumeLayout(false);
            CARD_Usuario.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard CARD_Usuario;
        private MaterialSkin.Controls.MaterialTextBox TXTB_Nombre;
        private MaterialSkin.Controls.MaterialComboBox MCB_Rol;
        private MaterialSkin.Controls.MaterialLabel LBL_Nombre;
        private MaterialSkin.Controls.MaterialLabel LBL_Apellido;
        private MaterialSkin.Controls.MaterialTextBox TXTB_Apellido;
        private MaterialSkin.Controls.MaterialLabel LBL_Dni;
        private MaterialSkin.Controls.MaterialLabel LBL_Nacimiento;
        private DateTimePicker DTP_Nacimiento;
        private MaterialSkin.Controls.MaterialLabel LBL_Celular;
        private MaterialSkin.Controls.MaterialTextBox TXTB_Celular;
        private MaterialSkin.Controls.MaterialLabel LBL_Rol;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label LBL_Direccion;
        private MaterialSkin.Controls.MaterialTextBox TXTB_Altura;
        private MaterialSkin.Controls.MaterialTextBox TXTB_Calle;
        private MaterialSkin.Controls.MaterialTextBox TXTB_CodigoPostal;
        private MaterialSkin.Controls.MaterialTextBox TXTB_Dpto;
        private MaterialSkin.Controls.MaterialTextBox TXTB_Piso;
        private MaterialSkin.Controls.MaterialButton BTN_GuardarUsuario;
        private MaterialSkin.Controls.MaterialLabel LBL_Email;
        private MaterialSkin.Controls.MaterialTextBox TXTB_Password;
        private MaterialSkin.Controls.MaterialLabel LBL_Password;
        private MaterialSkin.Controls.MaterialTextBox TXTB_Mail;
        private MaterialSkin.Controls.MaterialTextBox TXTB_Dni;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label LBL_Opcional;
    }
}