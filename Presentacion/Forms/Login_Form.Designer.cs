namespace PatitaSystem;

partial class Login_Form
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

    // Controles que vayas a usar en WireEvents()

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        PictureBox PIC_Usuario;
        CARD_Login = new RoundedMaterialCard();
        BTN_Salir = new MaterialSkin.Controls.MaterialButton();
        CARD_FormLogin = new MaterialSkin.Controls.MaterialCard();
        tableLayoutPanel1 = new TableLayoutPanel();
        TXTB_Password = new MaterialSkin.Controls.MaterialTextBox();
        LBL_Password = new MaterialSkin.Controls.MaterialLabel();
        LBL_Usuario = new MaterialSkin.Controls.MaterialLabel();
        TXTB_Usuario = new MaterialSkin.Controls.MaterialTextBox();
        PIC_Password = new PictureBox();
        SWCH_Password = new MaterialSkin.Controls.MaterialSwitch();
        BTN_Ingresar = new MaterialSkin.Controls.MaterialButton();
        PIC_Logo = new PictureBox();
        PIC_Usuario = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)PIC_Usuario).BeginInit();
        CARD_Login.SuspendLayout();
        CARD_FormLogin.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PIC_Password).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PIC_Logo).BeginInit();
        SuspendLayout();
        // 
        // PIC_Usuario
        // 
        PIC_Usuario.Dock = DockStyle.Fill;
        PIC_Usuario.Image = Properties.Resources.member;
        PIC_Usuario.Location = new Point(3, 3);
        PIC_Usuario.Name = "PIC_Usuario";
        PIC_Usuario.Size = new Size(42, 54);
        PIC_Usuario.SizeMode = PictureBoxSizeMode.Zoom;
        PIC_Usuario.TabIndex = 0;
        PIC_Usuario.TabStop = false;
        // 
        // CARD_Login
        // 
        CARD_Login.BackColor = Color.FromArgb(255, 255, 255);
        CARD_Login.Controls.Add(BTN_Salir);
        CARD_Login.Controls.Add(CARD_FormLogin);
        CARD_Login.Controls.Add(BTN_Ingresar);
        CARD_Login.Depth = 0;
        CARD_Login.ForeColor = Color.FromArgb(222, 0, 0, 0);
        CARD_Login.Location = new Point(39, 217);
        CARD_Login.Margin = new Padding(14);
        CARD_Login.MouseState = MaterialSkin.MouseState.HOVER;
        CARD_Login.Name = "CARD_Login";
        CARD_Login.Padding = new Padding(14, 11, 11, 14);
        CARD_Login.Size = new Size(407, 293);
        CARD_Login.TabIndex = 0;
        // 
        // BTN_Salir
        // 
        BTN_Salir.AutoSize = false;
        BTN_Salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BTN_Salir.BackColor = Color.FromArgb(45, 45, 48);
        BTN_Salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        BTN_Salir.Depth = 0;
        BTN_Salir.FlatStyle = FlatStyle.Flat;
        BTN_Salir.ForeColor = Color.White;
        BTN_Salir.HighEmphasis = true;
        BTN_Salir.Icon = null;
        BTN_Salir.Location = new Point(252, 228);
        BTN_Salir.Margin = new Padding(4, 6, 4, 6);
        BTN_Salir.MouseState = MaterialSkin.MouseState.HOVER;
        BTN_Salir.Name = "BTN_Salir";
        BTN_Salir.NoAccentTextColor = Color.Empty;
        BTN_Salir.Size = new Size(91, 36);
        BTN_Salir.TabIndex = 2;
        BTN_Salir.Text = "Salir";
        BTN_Salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
        BTN_Salir.UseAccentColor = false;
        BTN_Salir.UseVisualStyleBackColor = false;
        // 
        // CARD_FormLogin
        // 
        CARD_FormLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        CARD_FormLogin.BackColor = Color.FromArgb(255, 255, 255);
        CARD_FormLogin.Controls.Add(tableLayoutPanel1);
        CARD_FormLogin.Controls.Add(SWCH_Password);
        CARD_FormLogin.Depth = 0;
        CARD_FormLogin.ForeColor = Color.FromArgb(222, 0, 0, 0);
        CARD_FormLogin.Location = new Point(28, 31);
        CARD_FormLogin.Margin = new Padding(14);
        CARD_FormLogin.MouseState = MaterialSkin.MouseState.HOVER;
        CARD_FormLogin.Name = "CARD_FormLogin";
        CARD_FormLogin.Padding = new Padding(14);
        CARD_FormLogin.Size = new Size(354, 189);
        CARD_FormLogin.TabIndex = 1;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.10853F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.89147F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 176F));
        tableLayoutPanel1.Controls.Add(TXTB_Password, 2, 1);
        tableLayoutPanel1.Controls.Add(LBL_Password, 1, 1);
        tableLayoutPanel1.Controls.Add(PIC_Usuario, 0, 0);
        tableLayoutPanel1.Controls.Add(LBL_Usuario, 1, 0);
        tableLayoutPanel1.Controls.Add(TXTB_Usuario, 2, 0);
        tableLayoutPanel1.Controls.Add(PIC_Password, 0, 1);
        tableLayoutPanel1.Location = new Point(17, 21);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.81818F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.18182F));
        tableLayoutPanel1.Size = new Size(318, 116);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // TXTB_Password
        // 
        TXTB_Password.AnimateReadOnly = false;
        TXTB_Password.BorderStyle = BorderStyle.None;
        TXTB_Password.Depth = 0;
        TXTB_Password.Dock = DockStyle.Fill;
        TXTB_Password.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        TXTB_Password.LeadingIcon = null;
        TXTB_Password.Location = new Point(144, 63);
        TXTB_Password.MaxLength = 50;
        TXTB_Password.MouseState = MaterialSkin.MouseState.OUT;
        TXTB_Password.Multiline = false;
        TXTB_Password.Name = "TXTB_Password";
        TXTB_Password.Size = new Size(171, 50);
        TXTB_Password.TabIndex = 5;
        TXTB_Password.Text = "";
        TXTB_Password.TrailingIcon = null;
        // 
        // LBL_Password
        // 
        LBL_Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LBL_Password.AutoSize = true;
        LBL_Password.Depth = 0;
        LBL_Password.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        LBL_Password.Location = new Point(51, 60);
        LBL_Password.MouseState = MaterialSkin.MouseState.HOVER;
        LBL_Password.Name = "LBL_Password";
        LBL_Password.RightToLeft = RightToLeft.No;
        LBL_Password.Size = new Size(87, 56);
        LBL_Password.TabIndex = 4;
        LBL_Password.Text = "Contraseña";
        LBL_Password.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LBL_Usuario
        // 
        LBL_Usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LBL_Usuario.AutoSize = true;
        LBL_Usuario.Depth = 0;
        LBL_Usuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        LBL_Usuario.Location = new Point(51, 0);
        LBL_Usuario.MouseState = MaterialSkin.MouseState.HOVER;
        LBL_Usuario.Name = "LBL_Usuario";
        LBL_Usuario.RightToLeft = RightToLeft.No;
        LBL_Usuario.Size = new Size(87, 60);
        LBL_Usuario.TabIndex = 1;
        LBL_Usuario.Text = "Usuario";
        LBL_Usuario.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TXTB_Usuario
        // 
        TXTB_Usuario.AnimateReadOnly = false;
        TXTB_Usuario.BorderStyle = BorderStyle.None;
        TXTB_Usuario.Depth = 0;
        TXTB_Usuario.Dock = DockStyle.Fill;
        TXTB_Usuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        TXTB_Usuario.LeadingIcon = null;
        TXTB_Usuario.Location = new Point(144, 3);
        TXTB_Usuario.MaxLength = 50;
        TXTB_Usuario.MouseState = MaterialSkin.MouseState.OUT;
        TXTB_Usuario.Multiline = false;
        TXTB_Usuario.Name = "TXTB_Usuario";
        TXTB_Usuario.Size = new Size(171, 50);
        TXTB_Usuario.TabIndex = 2;
        TXTB_Usuario.Text = "";
        TXTB_Usuario.TrailingIcon = null;
        // 
        // PIC_Password
        // 
        PIC_Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        PIC_Password.Image = Properties.Resources.key2;
        PIC_Password.Location = new Point(3, 63);
        PIC_Password.Name = "PIC_Password";
        PIC_Password.Size = new Size(42, 50);
        PIC_Password.SizeMode = PictureBoxSizeMode.Zoom;
        PIC_Password.TabIndex = 3;
        PIC_Password.TabStop = false;
        // 
        // SWCH_Password
        // 
        SWCH_Password.Anchor = AnchorStyles.None;
        SWCH_Password.Depth = 0;
        SWCH_Password.Location = new Point(20, 151);
        SWCH_Password.Margin = new Padding(0);
        SWCH_Password.MouseLocation = new Point(-1, -1);
        SWCH_Password.MouseState = MaterialSkin.MouseState.HOVER;
        SWCH_Password.Name = "SWCH_Password";
        SWCH_Password.Ripple = true;
        SWCH_Password.Size = new Size(210, 24);
        SWCH_Password.TabIndex = 6;
        SWCH_Password.Text = "Mostrar contraseña";
        SWCH_Password.TextAlign = ContentAlignment.MiddleCenter;
        SWCH_Password.UseVisualStyleBackColor = true;
        // 
        // BTN_Ingresar
        // 
        BTN_Ingresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BTN_Ingresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        BTN_Ingresar.Depth = 0;
        BTN_Ingresar.HighEmphasis = true;
        BTN_Ingresar.Icon = null;
        BTN_Ingresar.Location = new Point(63, 228);
        BTN_Ingresar.Margin = new Padding(4, 6, 4, 6);
        BTN_Ingresar.MouseState = MaterialSkin.MouseState.HOVER;
        BTN_Ingresar.Name = "BTN_Ingresar";
        BTN_Ingresar.NoAccentTextColor = Color.Empty;
        BTN_Ingresar.Size = new Size(91, 36);
        BTN_Ingresar.TabIndex = 1;
        BTN_Ingresar.Text = "Ingresar";
        BTN_Ingresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        BTN_Ingresar.UseAccentColor = false;
        BTN_Ingresar.UseVisualStyleBackColor = true;
        // 
        // PIC_Logo
        // 
        PIC_Logo.Image = Properties.Resources.logo2;
        PIC_Logo.Location = new Point(39, 27);
        PIC_Logo.Name = "PIC_Logo";
        PIC_Logo.Size = new Size(407, 236);
        PIC_Logo.SizeMode = PictureBoxSizeMode.Zoom;
        PIC_Logo.TabIndex = 3;
        PIC_Logo.TabStop = false;
        // 
        // Login_Form
        // 
        ClientSize = new Size(728, 1100);
        Controls.Add(CARD_Login);
        Controls.Add(PIC_Logo);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        FormStyle = FormStyles.ActionBar_None;
        MaximizeBox = false;
        Name = "Login_Form";
        Padding = new Padding(3, 24, 35, 5);
        RightToLeft = RightToLeft.No;
        SizeGripStyle = SizeGripStyle.Hide;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ((System.ComponentModel.ISupportInitialize)PIC_Usuario).EndInit();
        CARD_Login.ResumeLayout(false);
        CARD_Login.PerformLayout();
        CARD_FormLogin.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PIC_Password).EndInit();
        ((System.ComponentModel.ISupportInitialize)PIC_Logo).EndInit();
        ResumeLayout(false);

    }

    #endregion
    private TableLayoutPanel tableLayoutPanel1;
    private MaterialSkin.Controls.MaterialCard CARD_FormLogin;
    private PictureBox PIC_Usuario;
    private MaterialSkin.Controls.MaterialLabel LBL_Usuario;
    private MaterialSkin.Controls.MaterialTextBox TXTB_Usuario;
    private PictureBox PIC_Password;
    private MaterialSkin.Controls.MaterialTextBox TXTB_Password;
    private MaterialSkin.Controls.MaterialLabel LBL_Password;
    private MaterialSkin.Controls.MaterialSwitch SWCH_Password;
    private MaterialSkin.Controls.MaterialButton BTN_Ingresar;
    private MaterialSkin.Controls.MaterialButton BTN_Salir;
    private PictureBox PIC_Logo;
    private RoundedMaterialCard CARD_Login;
}