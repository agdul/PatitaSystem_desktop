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
            TLP_FormUsuario = new TableLayoutPanel();
            TXTB_Usuario = new MaterialSkin.Controls.MaterialTextBox();
            TXTB_Password = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Nombre = new MaterialSkin.Controls.MaterialLabel();
            LBL_Password = new MaterialSkin.Controls.MaterialLabel();
            TXTB_Nombre = new MaterialSkin.Controls.MaterialTextBox();
            TXTB_Mail = new MaterialSkin.Controls.MaterialTextBox();
            MCB_Rol = new MaterialSkin.Controls.MaterialComboBox();
            LBL_Email = new MaterialSkin.Controls.MaterialLabel();
            LBL_Usuario = new MaterialSkin.Controls.MaterialLabel();
            LBL_Apellido = new MaterialSkin.Controls.MaterialLabel();
            TXTB_Apellido = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Rol = new MaterialSkin.Controls.MaterialLabel();
            LBL_Dni = new MaterialSkin.Controls.MaterialLabel();
            TXTB_Celular = new MaterialSkin.Controls.MaterialTextBox();
            TXTB_Dni = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Celular = new MaterialSkin.Controls.MaterialLabel();
            LBL_Nacimiento = new MaterialSkin.Controls.MaterialLabel();
            DTP_Nacimiento = new DateTimePicker();
            BTN_GuardarUsuario = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            TLP_UsuarioDireccion = new TableLayoutPanel();
            LBL_Genero = new MaterialSkin.Controls.MaterialLabel();
            MCB_Genero = new MaterialSkin.Controls.MaterialComboBox();
            TXTB_Dpto = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Calle = new MaterialSkin.Controls.MaterialLabel();
            TXTB_CodigoPostal = new MaterialSkin.Controls.MaterialTextBox();
            TXTB_Piso = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Direccion = new Label();
            TXTB_Calle = new MaterialSkin.Controls.MaterialTextBox();
            LBL_Altura = new MaterialSkin.Controls.MaterialLabel();
            TXTB_Altura = new MaterialSkin.Controls.MaterialTextBox();
            LBL_CodigoPostal = new MaterialSkin.Controls.MaterialLabel();
            LBL_Piso = new MaterialSkin.Controls.MaterialLabel();
            LBL_Departamento = new MaterialSkin.Controls.MaterialLabel();
            TLP_FormUsuario2 = new TableLayoutPanel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            CARD_Usuario.SuspendLayout();
            TLP_FormUsuario.SuspendLayout();
            materialCard1.SuspendLayout();
            TLP_UsuarioDireccion.SuspendLayout();
            TLP_FormUsuario2.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // CARD_Usuario
            // 
            CARD_Usuario.BackColor = Color.FromArgb(255, 255, 255);
            CARD_Usuario.BorderStyle = BorderStyle.FixedSingle;
            CARD_Usuario.Controls.Add(TLP_FormUsuario);
            CARD_Usuario.Depth = 0;
            CARD_Usuario.Dock = DockStyle.Left;
            CARD_Usuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CARD_Usuario.Location = new Point(14, 14);
            CARD_Usuario.Margin = new Padding(12, 10, 12, 10);
            CARD_Usuario.MouseState = MaterialSkin.MouseState.HOVER;
            CARD_Usuario.Name = "CARD_Usuario";
            CARD_Usuario.Padding = new Padding(20);
            CARD_Usuario.Size = new Size(355, 537);
            CARD_Usuario.TabIndex = 0;
            // 
            // TLP_FormUsuario
            // 
            TLP_FormUsuario.ColumnCount = 2;
            TLP_FormUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_FormUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_FormUsuario.Controls.Add(TXTB_Usuario, 1, 2);
            TLP_FormUsuario.Controls.Add(TXTB_Password, 1, 7);
            TLP_FormUsuario.Controls.Add(LBL_Nombre, 0, 0);
            TLP_FormUsuario.Controls.Add(LBL_Password, 0, 7);
            TLP_FormUsuario.Controls.Add(TXTB_Nombre, 1, 0);
            TLP_FormUsuario.Controls.Add(TXTB_Mail, 1, 6);
            TLP_FormUsuario.Controls.Add(MCB_Rol, 1, 5);
            TLP_FormUsuario.Controls.Add(LBL_Email, 0, 6);
            TLP_FormUsuario.Controls.Add(LBL_Usuario, 0, 2);
            TLP_FormUsuario.Controls.Add(LBL_Apellido, 0, 1);
            TLP_FormUsuario.Controls.Add(TXTB_Apellido, 1, 1);
            TLP_FormUsuario.Controls.Add(LBL_Rol, 0, 5);
            TLP_FormUsuario.Controls.Add(LBL_Dni, 0, 3);
            TLP_FormUsuario.Controls.Add(TXTB_Celular, 1, 4);
            TLP_FormUsuario.Controls.Add(TXTB_Dni, 1, 3);
            TLP_FormUsuario.Controls.Add(LBL_Celular, 0, 4);
            TLP_FormUsuario.Dock = DockStyle.Fill;
            TLP_FormUsuario.Location = new Point(20, 20);
            TLP_FormUsuario.Name = "TLP_FormUsuario";
            TLP_FormUsuario.RowCount = 8;
            TLP_FormUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            TLP_FormUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            TLP_FormUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            TLP_FormUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            TLP_FormUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            TLP_FormUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            TLP_FormUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            TLP_FormUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            TLP_FormUsuario.Size = new Size(313, 495);
            TLP_FormUsuario.TabIndex = 0;
            // 
            // TXTB_Usuario
            // 
            TXTB_Usuario.AnimateReadOnly = false;
            TXTB_Usuario.BorderStyle = BorderStyle.None;
            TXTB_Usuario.Depth = 0;
            TXTB_Usuario.Dock = DockStyle.Fill;
            TXTB_Usuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Usuario.Hint = "Usuario";
            TXTB_Usuario.LeadingIcon = null;
            TXTB_Usuario.Location = new Point(159, 125);
            TXTB_Usuario.MaxLength = 50;
            TXTB_Usuario.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Usuario.Multiline = false;
            TXTB_Usuario.Name = "TXTB_Usuario";
            TXTB_Usuario.Size = new Size(151, 50);
            TXTB_Usuario.TabIndex = 3;
            TXTB_Usuario.Text = "";
            TXTB_Usuario.TrailingIcon = null;
            // 
            // TXTB_Password
            // 
            TXTB_Password.AnimateReadOnly = false;
            TXTB_Password.BorderStyle = BorderStyle.None;
            TXTB_Password.Depth = 0;
            TXTB_Password.Dock = DockStyle.Fill;
            TXTB_Password.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Password.Hint = "Password";
            TXTB_Password.LeadingIcon = null;
            TXTB_Password.Location = new Point(159, 429);
            TXTB_Password.Margin = new Padding(3, 2, 3, 2);
            TXTB_Password.MaxLength = 50;
            TXTB_Password.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Password.Multiline = false;
            TXTB_Password.Name = "TXTB_Password";
            TXTB_Password.Password = true;
            TXTB_Password.Size = new Size(151, 50);
            TXTB_Password.TabIndex = 8;
            TXTB_Password.Text = "";
            TXTB_Password.TrailingIcon = null;
            // 
            // LBL_Nombre
            // 
            LBL_Nombre.AutoSize = true;
            LBL_Nombre.Depth = 0;
            LBL_Nombre.Dock = DockStyle.Fill;
            LBL_Nombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Nombre.Location = new Point(3, 0);
            LBL_Nombre.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Nombre.Name = "LBL_Nombre";
            LBL_Nombre.Size = new Size(150, 61);
            LBL_Nombre.TabIndex = 6;
            LBL_Nombre.Text = "Nombre";
            LBL_Nombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBL_Password
            // 
            LBL_Password.AutoSize = true;
            LBL_Password.Depth = 0;
            LBL_Password.Dock = DockStyle.Fill;
            LBL_Password.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Password.Location = new Point(3, 427);
            LBL_Password.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Password.Name = "LBL_Password";
            LBL_Password.Size = new Size(150, 68);
            LBL_Password.TabIndex = 21;
            LBL_Password.Text = "Password";
            LBL_Password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TXTB_Nombre
            // 
            TXTB_Nombre.AnimateReadOnly = false;
            TXTB_Nombre.BorderStyle = BorderStyle.None;
            TXTB_Nombre.Depth = 0;
            TXTB_Nombre.Dock = DockStyle.Fill;
            TXTB_Nombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Nombre.Hint = "Nombre";
            TXTB_Nombre.LeadingIcon = null;
            TXTB_Nombre.Location = new Point(159, 2);
            TXTB_Nombre.Margin = new Padding(3, 2, 3, 2);
            TXTB_Nombre.MaxLength = 50;
            TXTB_Nombre.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Nombre.Multiline = false;
            TXTB_Nombre.Name = "TXTB_Nombre";
            TXTB_Nombre.Size = new Size(151, 50);
            TXTB_Nombre.TabIndex = 1;
            TXTB_Nombre.Text = "";
            TXTB_Nombre.TrailingIcon = null;
            TXTB_Nombre.KeyPress += TXTB_Nombre_KeyPress;
            // 
            // TXTB_Mail
            // 
            TXTB_Mail.AnimateReadOnly = false;
            TXTB_Mail.BorderStyle = BorderStyle.None;
            TXTB_Mail.Depth = 0;
            TXTB_Mail.Dock = DockStyle.Fill;
            TXTB_Mail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Mail.Hint = "Email";
            TXTB_Mail.LeadingIcon = null;
            TXTB_Mail.Location = new Point(159, 368);
            TXTB_Mail.Margin = new Padding(3, 2, 3, 2);
            TXTB_Mail.MaxLength = 50;
            TXTB_Mail.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Mail.Multiline = false;
            TXTB_Mail.Name = "TXTB_Mail";
            TXTB_Mail.Size = new Size(151, 50);
            TXTB_Mail.TabIndex = 7;
            TXTB_Mail.Text = "";
            TXTB_Mail.TrailingIcon = null;
            // 
            // MCB_Rol
            // 
            MCB_Rol.AutoResize = false;
            MCB_Rol.BackColor = Color.FromArgb(255, 255, 255);
            MCB_Rol.Depth = 0;
            MCB_Rol.Dock = DockStyle.Fill;
            MCB_Rol.DrawMode = DrawMode.OwnerDrawVariable;
            MCB_Rol.DropDownHeight = 174;
            MCB_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            MCB_Rol.DropDownWidth = 121;
            MCB_Rol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            MCB_Rol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MCB_Rol.FormattingEnabled = true;
            MCB_Rol.IntegralHeight = false;
            MCB_Rol.ItemHeight = 43;
            MCB_Rol.Location = new Point(159, 307);
            MCB_Rol.Margin = new Padding(3, 2, 3, 2);
            MCB_Rol.MaxDropDownItems = 4;
            MCB_Rol.MouseState = MaterialSkin.MouseState.OUT;
            MCB_Rol.Name = "MCB_Rol";
            MCB_Rol.Size = new Size(151, 49);
            MCB_Rol.StartIndex = 0;
            MCB_Rol.TabIndex = 6;
            // 
            // LBL_Email
            // 
            LBL_Email.AutoSize = true;
            LBL_Email.Depth = 0;
            LBL_Email.Dock = DockStyle.Fill;
            LBL_Email.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Email.Location = new Point(3, 366);
            LBL_Email.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Email.Name = "LBL_Email";
            LBL_Email.Size = new Size(150, 61);
            LBL_Email.TabIndex = 18;
            LBL_Email.Text = "Email";
            LBL_Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBL_Usuario
            // 
            LBL_Usuario.AutoSize = true;
            LBL_Usuario.Depth = 0;
            LBL_Usuario.Dock = DockStyle.Fill;
            LBL_Usuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Usuario.Location = new Point(3, 122);
            LBL_Usuario.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Usuario.Name = "LBL_Usuario";
            LBL_Usuario.Size = new Size(150, 61);
            LBL_Usuario.TabIndex = 23;
            LBL_Usuario.Text = "Usuario";
            LBL_Usuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBL_Apellido
            // 
            LBL_Apellido.AutoSize = true;
            LBL_Apellido.Depth = 0;
            LBL_Apellido.Dock = DockStyle.Fill;
            LBL_Apellido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Apellido.Location = new Point(3, 61);
            LBL_Apellido.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Apellido.Name = "LBL_Apellido";
            LBL_Apellido.Size = new Size(150, 61);
            LBL_Apellido.TabIndex = 7;
            LBL_Apellido.Text = "Apellido";
            LBL_Apellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TXTB_Apellido
            // 
            TXTB_Apellido.AnimateReadOnly = false;
            TXTB_Apellido.BorderStyle = BorderStyle.None;
            TXTB_Apellido.Depth = 0;
            TXTB_Apellido.Dock = DockStyle.Fill;
            TXTB_Apellido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Apellido.Hint = "Apellido";
            TXTB_Apellido.LeadingIcon = null;
            TXTB_Apellido.Location = new Point(159, 63);
            TXTB_Apellido.Margin = new Padding(3, 2, 3, 2);
            TXTB_Apellido.MaxLength = 50;
            TXTB_Apellido.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Apellido.Multiline = false;
            TXTB_Apellido.Name = "TXTB_Apellido";
            TXTB_Apellido.Size = new Size(151, 50);
            TXTB_Apellido.TabIndex = 2;
            TXTB_Apellido.Text = "";
            TXTB_Apellido.TrailingIcon = null;
            TXTB_Apellido.KeyPress += TXTB_Apellido_KeyPress;
            // 
            // LBL_Rol
            // 
            LBL_Rol.AutoSize = true;
            LBL_Rol.Depth = 0;
            LBL_Rol.Dock = DockStyle.Fill;
            LBL_Rol.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Rol.Location = new Point(3, 305);
            LBL_Rol.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Rol.Name = "LBL_Rol";
            LBL_Rol.Size = new Size(150, 61);
            LBL_Rol.TabIndex = 15;
            LBL_Rol.Text = "Rol";
            LBL_Rol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBL_Dni
            // 
            LBL_Dni.AutoSize = true;
            LBL_Dni.Depth = 0;
            LBL_Dni.Dock = DockStyle.Fill;
            LBL_Dni.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Dni.Location = new Point(3, 183);
            LBL_Dni.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Dni.Name = "LBL_Dni";
            LBL_Dni.Size = new Size(150, 61);
            LBL_Dni.TabIndex = 9;
            LBL_Dni.Text = "DNI";
            LBL_Dni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TXTB_Celular
            // 
            TXTB_Celular.AnimateReadOnly = false;
            TXTB_Celular.BorderStyle = BorderStyle.None;
            TXTB_Celular.Depth = 0;
            TXTB_Celular.Dock = DockStyle.Fill;
            TXTB_Celular.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Celular.Hint = "Celular";
            TXTB_Celular.LeadingIcon = null;
            TXTB_Celular.Location = new Point(159, 246);
            TXTB_Celular.Margin = new Padding(3, 2, 3, 2);
            TXTB_Celular.MaxLength = 50;
            TXTB_Celular.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Celular.Multiline = false;
            TXTB_Celular.Name = "TXTB_Celular";
            TXTB_Celular.Size = new Size(151, 50);
            TXTB_Celular.TabIndex = 5;
            TXTB_Celular.Text = "";
            TXTB_Celular.TrailingIcon = null;
            TXTB_Celular.KeyPress += TXTB_Celular_KeyPress;
            // 
            // TXTB_Dni
            // 
            TXTB_Dni.AnimateReadOnly = false;
            TXTB_Dni.BorderStyle = BorderStyle.None;
            TXTB_Dni.Depth = 0;
            TXTB_Dni.Dock = DockStyle.Fill;
            TXTB_Dni.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Dni.Hint = "DNI";
            TXTB_Dni.LeadingIcon = null;
            TXTB_Dni.Location = new Point(159, 185);
            TXTB_Dni.Margin = new Padding(3, 2, 3, 2);
            TXTB_Dni.MaxLength = 50;
            TXTB_Dni.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Dni.Multiline = false;
            TXTB_Dni.Name = "TXTB_Dni";
            TXTB_Dni.Size = new Size(151, 50);
            TXTB_Dni.TabIndex = 4;
            TXTB_Dni.Text = "";
            TXTB_Dni.TrailingIcon = null;
            TXTB_Dni.KeyPress += TXTB_Dni_KeyPress;
            // 
            // LBL_Celular
            // 
            LBL_Celular.AutoSize = true;
            LBL_Celular.Depth = 0;
            LBL_Celular.Dock = DockStyle.Fill;
            LBL_Celular.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Celular.Location = new Point(3, 244);
            LBL_Celular.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Celular.Name = "LBL_Celular";
            LBL_Celular.Size = new Size(150, 61);
            LBL_Celular.TabIndex = 13;
            LBL_Celular.Text = "Celular";
            LBL_Celular.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBL_Nacimiento
            // 
            LBL_Nacimiento.AutoSize = true;
            LBL_Nacimiento.Depth = 0;
            LBL_Nacimiento.Dock = DockStyle.Fill;
            LBL_Nacimiento.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Nacimiento.Location = new Point(52, 0);
            LBL_Nacimiento.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Nacimiento.Name = "LBL_Nacimiento";
            LBL_Nacimiento.Size = new Size(217, 50);
            LBL_Nacimiento.TabIndex = 11;
            LBL_Nacimiento.Text = "Fecha de nacimiento";
            LBL_Nacimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTP_Nacimiento
            // 
            DTP_Nacimiento.Dock = DockStyle.Fill;
            DTP_Nacimiento.Location = new Point(52, 52);
            DTP_Nacimiento.Margin = new Padding(3, 2, 3, 2);
            DTP_Nacimiento.MaxDate = new DateTime(2099, 12, 24, 0, 0, 0, 0);
            DTP_Nacimiento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DTP_Nacimiento.Name = "DTP_Nacimiento";
            DTP_Nacimiento.Size = new Size(217, 23);
            DTP_Nacimiento.TabIndex = 9;
            DTP_Nacimiento.Value = new DateTime(1998, 1, 1, 0, 0, 0, 0);
            // 
            // BTN_GuardarUsuario
            // 
            BTN_GuardarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_GuardarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_GuardarUsuario.Depth = 0;
            BTN_GuardarUsuario.HighEmphasis = true;
            BTN_GuardarUsuario.Icon = null;
            BTN_GuardarUsuario.Location = new Point(136, 479);
            BTN_GuardarUsuario.Margin = new Padding(4);
            BTN_GuardarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_GuardarUsuario.Name = "BTN_GuardarUsuario";
            BTN_GuardarUsuario.NoAccentTextColor = Color.Empty;
            BTN_GuardarUsuario.Size = new Size(153, 36);
            BTN_GuardarUsuario.TabIndex = 16;
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
            materialCard1.Controls.Add(TLP_UsuarioDireccion);
            materialCard1.Controls.Add(TLP_FormUsuario2);
            materialCard1.Controls.Add(BTN_GuardarUsuario);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Right;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(399, 14);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(20);
            materialCard1.Size = new Size(365, 537);
            materialCard1.TabIndex = 16;
            // 
            // TLP_UsuarioDireccion
            // 
            TLP_UsuarioDireccion.ColumnCount = 2;
            TLP_UsuarioDireccion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_UsuarioDireccion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_UsuarioDireccion.Controls.Add(LBL_Genero, 0, 0);
            TLP_UsuarioDireccion.Controls.Add(MCB_Genero, 1, 0);
            TLP_UsuarioDireccion.Controls.Add(TXTB_Dpto, 1, 6);
            TLP_UsuarioDireccion.Controls.Add(LBL_Calle, 0, 2);
            TLP_UsuarioDireccion.Controls.Add(TXTB_CodigoPostal, 1, 4);
            TLP_UsuarioDireccion.Controls.Add(TXTB_Piso, 1, 5);
            TLP_UsuarioDireccion.Controls.Add(LBL_Direccion, 0, 1);
            TLP_UsuarioDireccion.Controls.Add(TXTB_Calle, 1, 2);
            TLP_UsuarioDireccion.Controls.Add(LBL_Altura, 0, 3);
            TLP_UsuarioDireccion.Controls.Add(TXTB_Altura, 1, 3);
            TLP_UsuarioDireccion.Controls.Add(LBL_CodigoPostal, 0, 4);
            TLP_UsuarioDireccion.Controls.Add(LBL_Piso, 0, 5);
            TLP_UsuarioDireccion.Controls.Add(LBL_Departamento, 0, 6);
            TLP_UsuarioDireccion.Location = new Point(21, 136);
            TLP_UsuarioDireccion.Margin = new Padding(3, 0, 3, 3);
            TLP_UsuarioDireccion.Name = "TLP_UsuarioDireccion";
            TLP_UsuarioDireccion.RowCount = 7;
            TLP_UsuarioDireccion.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4564648F));
            TLP_UsuarioDireccion.RowStyles.Add(new RowStyle(SizeType.Percent, 6.06860161F));
            TLP_UsuarioDireccion.RowStyles.Add(new RowStyle(SizeType.Percent, 15.0395775F));
            TLP_UsuarioDireccion.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7757254F));
            TLP_UsuarioDireccion.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5672827F));
            TLP_UsuarioDireccion.RowStyles.Add(new RowStyle(SizeType.Percent, 15.0395775F));
            TLP_UsuarioDireccion.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4564648F));
            TLP_UsuarioDireccion.Size = new Size(323, 333);
            TLP_UsuarioDireccion.TabIndex = 1;
            // 
            // LBL_Genero
            // 
            LBL_Genero.AutoSize = true;
            LBL_Genero.Depth = 0;
            LBL_Genero.Dock = DockStyle.Fill;
            LBL_Genero.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Genero.Location = new Point(3, 0);
            LBL_Genero.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Genero.Name = "LBL_Genero";
            LBL_Genero.Size = new Size(155, 47);
            LBL_Genero.TabIndex = 0;
            LBL_Genero.Text = "Genero";
            LBL_Genero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MCB_Genero
            // 
            MCB_Genero.AutoResize = false;
            MCB_Genero.BackColor = Color.FromArgb(255, 255, 255);
            MCB_Genero.Depth = 0;
            MCB_Genero.Dock = DockStyle.Fill;
            MCB_Genero.DrawMode = DrawMode.OwnerDrawVariable;
            MCB_Genero.DropDownHeight = 174;
            MCB_Genero.DropDownStyle = ComboBoxStyle.DropDownList;
            MCB_Genero.DropDownWidth = 121;
            MCB_Genero.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            MCB_Genero.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MCB_Genero.FormattingEnabled = true;
            MCB_Genero.IntegralHeight = false;
            MCB_Genero.ItemHeight = 43;
            MCB_Genero.Location = new Point(164, 3);
            MCB_Genero.MaxDropDownItems = 4;
            MCB_Genero.MouseState = MaterialSkin.MouseState.OUT;
            MCB_Genero.Name = "MCB_Genero";
            MCB_Genero.Size = new Size(156, 49);
            MCB_Genero.StartIndex = 0;
            MCB_Genero.TabIndex = 10;
            // 
            // TXTB_Dpto
            // 
            TXTB_Dpto.AnimateReadOnly = false;
            TXTB_Dpto.BorderStyle = BorderStyle.None;
            TXTB_Dpto.Depth = 0;
            TXTB_Dpto.Dock = DockStyle.Fill;
            TXTB_Dpto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Dpto.Hint = "Dpto";
            TXTB_Dpto.LeadingIcon = null;
            TXTB_Dpto.Location = new Point(164, 283);
            TXTB_Dpto.Margin = new Padding(3, 2, 3, 2);
            TXTB_Dpto.MaxLength = 50;
            TXTB_Dpto.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Dpto.Multiline = false;
            TXTB_Dpto.Name = "TXTB_Dpto";
            TXTB_Dpto.Size = new Size(156, 50);
            TXTB_Dpto.TabIndex = 15;
            TXTB_Dpto.Text = "";
            TXTB_Dpto.TrailingIcon = null;
            // 
            // LBL_Calle
            // 
            LBL_Calle.AutoSize = true;
            LBL_Calle.Depth = 0;
            LBL_Calle.Dock = DockStyle.Fill;
            LBL_Calle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Calle.Location = new Point(3, 68);
            LBL_Calle.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Calle.Name = "LBL_Calle";
            LBL_Calle.Size = new Size(155, 53);
            LBL_Calle.TabIndex = 2;
            LBL_Calle.Text = "Calle";
            LBL_Calle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TXTB_CodigoPostal
            // 
            TXTB_CodigoPostal.AnimateReadOnly = false;
            TXTB_CodigoPostal.BorderStyle = BorderStyle.None;
            TXTB_CodigoPostal.Depth = 0;
            TXTB_CodigoPostal.Dock = DockStyle.Fill;
            TXTB_CodigoPostal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_CodigoPostal.Hint = "Codigo Postal";
            TXTB_CodigoPostal.LeadingIcon = null;
            TXTB_CodigoPostal.Location = new Point(164, 175);
            TXTB_CodigoPostal.Margin = new Padding(3, 2, 3, 2);
            TXTB_CodigoPostal.MaxLength = 50;
            TXTB_CodigoPostal.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_CodigoPostal.Multiline = false;
            TXTB_CodigoPostal.Name = "TXTB_CodigoPostal";
            TXTB_CodigoPostal.Size = new Size(156, 50);
            TXTB_CodigoPostal.TabIndex = 13;
            TXTB_CodigoPostal.Text = "";
            TXTB_CodigoPostal.TrailingIcon = null;
            // 
            // TXTB_Piso
            // 
            TXTB_Piso.AnimateReadOnly = false;
            TXTB_Piso.BorderStyle = BorderStyle.None;
            TXTB_Piso.Depth = 0;
            TXTB_Piso.Dock = DockStyle.Fill;
            TXTB_Piso.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Piso.Hint = "Piso";
            TXTB_Piso.LeadingIcon = null;
            TXTB_Piso.Location = new Point(164, 230);
            TXTB_Piso.Margin = new Padding(3, 2, 3, 2);
            TXTB_Piso.MaxLength = 50;
            TXTB_Piso.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Piso.Multiline = false;
            TXTB_Piso.Name = "TXTB_Piso";
            TXTB_Piso.Size = new Size(156, 50);
            TXTB_Piso.TabIndex = 14;
            TXTB_Piso.Text = "";
            TXTB_Piso.TrailingIcon = null;
            // 
            // LBL_Direccion
            // 
            LBL_Direccion.AutoSize = true;
            LBL_Direccion.Dock = DockStyle.Fill;
            LBL_Direccion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_Direccion.Location = new Point(3, 47);
            LBL_Direccion.Name = "LBL_Direccion";
            LBL_Direccion.Size = new Size(155, 21);
            LBL_Direccion.TabIndex = 0;
            LBL_Direccion.Text = "Dirección";
            // 
            // TXTB_Calle
            // 
            TXTB_Calle.AnimateReadOnly = false;
            TXTB_Calle.BorderStyle = BorderStyle.None;
            TXTB_Calle.Depth = 0;
            TXTB_Calle.Dock = DockStyle.Fill;
            TXTB_Calle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Calle.Hint = "Calle";
            TXTB_Calle.LeadingIcon = null;
            TXTB_Calle.LeaveOnEnterKey = true;
            TXTB_Calle.Location = new Point(164, 70);
            TXTB_Calle.Margin = new Padding(3, 2, 3, 2);
            TXTB_Calle.MaxLength = 50;
            TXTB_Calle.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Calle.Multiline = false;
            TXTB_Calle.Name = "TXTB_Calle";
            TXTB_Calle.Size = new Size(156, 50);
            TXTB_Calle.TabIndex = 11;
            TXTB_Calle.Text = "";
            TXTB_Calle.TrailingIcon = null;
            // 
            // LBL_Altura
            // 
            LBL_Altura.AutoSize = true;
            LBL_Altura.Depth = 0;
            LBL_Altura.Dock = DockStyle.Fill;
            LBL_Altura.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Altura.Location = new Point(3, 121);
            LBL_Altura.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Altura.Name = "LBL_Altura";
            LBL_Altura.Size = new Size(155, 52);
            LBL_Altura.TabIndex = 11;
            LBL_Altura.Text = "Altura";
            LBL_Altura.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TXTB_Altura
            // 
            TXTB_Altura.AnimateReadOnly = false;
            TXTB_Altura.BorderStyle = BorderStyle.None;
            TXTB_Altura.Depth = 0;
            TXTB_Altura.Dock = DockStyle.Fill;
            TXTB_Altura.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTB_Altura.Hint = "Altura";
            TXTB_Altura.LeadingIcon = null;
            TXTB_Altura.Location = new Point(164, 123);
            TXTB_Altura.Margin = new Padding(3, 2, 3, 2);
            TXTB_Altura.MaxLength = 50;
            TXTB_Altura.MouseState = MaterialSkin.MouseState.OUT;
            TXTB_Altura.Multiline = false;
            TXTB_Altura.Name = "TXTB_Altura";
            TXTB_Altura.Size = new Size(156, 50);
            TXTB_Altura.TabIndex = 12;
            TXTB_Altura.Text = "";
            TXTB_Altura.TrailingIcon = null;
            // 
            // LBL_CodigoPostal
            // 
            LBL_CodigoPostal.AutoSize = true;
            LBL_CodigoPostal.Depth = 0;
            LBL_CodigoPostal.Dock = DockStyle.Fill;
            LBL_CodigoPostal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CodigoPostal.Location = new Point(3, 173);
            LBL_CodigoPostal.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CodigoPostal.Name = "LBL_CodigoPostal";
            LBL_CodigoPostal.Size = new Size(155, 55);
            LBL_CodigoPostal.TabIndex = 12;
            LBL_CodigoPostal.Text = "Codigo Postal";
            LBL_CodigoPostal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBL_Piso
            // 
            LBL_Piso.AutoSize = true;
            LBL_Piso.Depth = 0;
            LBL_Piso.Dock = DockStyle.Fill;
            LBL_Piso.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Piso.Location = new Point(3, 228);
            LBL_Piso.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Piso.Name = "LBL_Piso";
            LBL_Piso.Size = new Size(155, 53);
            LBL_Piso.TabIndex = 13;
            LBL_Piso.Text = "Piso";
            LBL_Piso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBL_Departamento
            // 
            LBL_Departamento.AutoSize = true;
            LBL_Departamento.Depth = 0;
            LBL_Departamento.Dock = DockStyle.Fill;
            LBL_Departamento.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Departamento.Location = new Point(3, 281);
            LBL_Departamento.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Departamento.Name = "LBL_Departamento";
            LBL_Departamento.Size = new Size(155, 52);
            LBL_Departamento.TabIndex = 14;
            LBL_Departamento.Text = "Departamento";
            LBL_Departamento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TLP_FormUsuario2
            // 
            TLP_FormUsuario2.ColumnCount = 3;
            TLP_FormUsuario2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4088507F));
            TLP_FormUsuario2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.18259F));
            TLP_FormUsuario2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4085655F));
            TLP_FormUsuario2.Controls.Add(LBL_Nacimiento, 1, 0);
            TLP_FormUsuario2.Controls.Add(DTP_Nacimiento, 1, 1);
            TLP_FormUsuario2.Dock = DockStyle.Top;
            TLP_FormUsuario2.Location = new Point(20, 20);
            TLP_FormUsuario2.Margin = new Padding(3, 3, 3, 15);
            TLP_FormUsuario2.Name = "TLP_FormUsuario2";
            TLP_FormUsuario2.RowCount = 2;
            TLP_FormUsuario2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_FormUsuario2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_FormUsuario2.Size = new Size(323, 100);
            TLP_FormUsuario2.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.BackgroundImageLayout = ImageLayout.None;
            materialCard2.Controls.Add(CARD_Usuario);
            materialCard2.Controls.Add(materialCard1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(70, 55);
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
            ClientSize = new Size(912, 684);
            Controls.Add(materialCard2);
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRegistrarUsuario";
            Padding = new Padding(50);
            Text = "Usuario";
            CARD_Usuario.ResumeLayout(false);
            TLP_FormUsuario.ResumeLayout(false);
            TLP_FormUsuario.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            TLP_UsuarioDireccion.ResumeLayout(false);
            TLP_UsuarioDireccion.PerformLayout();
            TLP_FormUsuario2.ResumeLayout(false);
            TLP_FormUsuario2.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTextBox TXTB_Usuario;
        private MaterialSkin.Controls.MaterialLabel LBL_Usuario;
        private TableLayoutPanel TLP_FormUsuario;
        private TableLayoutPanel TLP_FormUsuario2;
        private TableLayoutPanel TLP_UsuarioDireccion;
        private MaterialSkin.Controls.MaterialLabel LBL_Genero;
        private MaterialSkin.Controls.MaterialComboBox MCB_Genero;
        private MaterialSkin.Controls.MaterialLabel LBL_Calle;
        private MaterialSkin.Controls.MaterialLabel LBL_Altura;
        private MaterialSkin.Controls.MaterialLabel LBL_CodigoPostal;
        private MaterialSkin.Controls.MaterialLabel LBL_Piso;
        private MaterialSkin.Controls.MaterialLabel LBL_Departamento;
    }
}