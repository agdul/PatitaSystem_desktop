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
        PictureBox pictureBox1;
        materialCard1 = new RoundedMaterialCard();
        materialButton2 = new MaterialSkin.Controls.MaterialButton();
        materialCard2 = new MaterialSkin.Controls.MaterialCard();
        tableLayoutPanel1 = new TableLayoutPanel();
        materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
        materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
        materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
        pictureBox2 = new PictureBox();
        materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
        materialButton1 = new MaterialSkin.Controls.MaterialButton();
        pictureBox3 = new PictureBox();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        materialCard1.SuspendLayout();
        materialCard2.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Image = Properties.Resources.member;
        pictureBox1.Location = new Point(3, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(42, 54);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // materialCard1
        // 
        materialCard1.BackColor = Color.FromArgb(255, 255, 255);
        materialCard1.Controls.Add(materialButton2);
        materialCard1.Controls.Add(materialCard2);
        materialCard1.Controls.Add(materialButton1);
        materialCard1.Depth = 0;
        materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
        materialCard1.Location = new Point(39, 217);
        materialCard1.Margin = new Padding(14);
        materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
        materialCard1.Name = "materialCard1";
        materialCard1.Padding = new Padding(14, 11, 11, 14);
        materialCard1.Size = new Size(407, 293);
        materialCard1.TabIndex = 0;
        // 
        // materialButton2
        // 
        materialButton2.AutoSize = false;
        materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        materialButton2.BackColor = Color.FromArgb(45, 45, 48);
        materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        materialButton2.Depth = 0;
        materialButton2.FlatStyle = FlatStyle.Flat;
        materialButton2.ForeColor = Color.White;
        materialButton2.HighEmphasis = true;
        materialButton2.Icon = null;
        materialButton2.Location = new Point(252, 228);
        materialButton2.Margin = new Padding(4, 6, 4, 6);
        materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
        materialButton2.Name = "materialButton2";
        materialButton2.NoAccentTextColor = Color.Empty;
        materialButton2.Size = new Size(91, 36);
        materialButton2.TabIndex = 2;
        materialButton2.Text = "Salir";
        materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
        materialButton2.UseAccentColor = false;
        materialButton2.UseVisualStyleBackColor = false;
        // 
        // materialCard2
        // 
        materialCard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        materialCard2.BackColor = Color.FromArgb(255, 255, 255);
        materialCard2.Controls.Add(tableLayoutPanel1);
        materialCard2.Controls.Add(materialSwitch1);
        materialCard2.Depth = 0;
        materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
        materialCard2.Location = new Point(28, 31);
        materialCard2.Margin = new Padding(14);
        materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
        materialCard2.Name = "materialCard2";
        materialCard2.Padding = new Padding(14);
        materialCard2.Size = new Size(354, 189);
        materialCard2.TabIndex = 1;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.10853F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.89147F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 176F));
        tableLayoutPanel1.Controls.Add(materialTextBox2, 2, 1);
        tableLayoutPanel1.Controls.Add(materialLabel2, 1, 1);
        tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
        tableLayoutPanel1.Controls.Add(materialLabel1, 1, 0);
        tableLayoutPanel1.Controls.Add(materialTextBox1, 2, 0);
        tableLayoutPanel1.Controls.Add(pictureBox2, 0, 1);
        tableLayoutPanel1.Location = new Point(17, 21);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.81818F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.18182F));
        tableLayoutPanel1.Size = new Size(318, 116);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // materialTextBox2
        // 
        materialTextBox2.AnimateReadOnly = false;
        materialTextBox2.BorderStyle = BorderStyle.None;
        materialTextBox2.Depth = 0;
        materialTextBox2.Dock = DockStyle.Fill;
        materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        materialTextBox2.LeadingIcon = null;
        materialTextBox2.Location = new Point(144, 63);
        materialTextBox2.MaxLength = 50;
        materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
        materialTextBox2.Multiline = false;
        materialTextBox2.Name = "materialTextBox2";
        materialTextBox2.Size = new Size(171, 50);
        materialTextBox2.TabIndex = 5;
        materialTextBox2.Text = "";
        materialTextBox2.TrailingIcon = null;
        // 
        // materialLabel2
        // 
        materialLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        materialLabel2.AutoSize = true;
        materialLabel2.Depth = 0;
        materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        materialLabel2.Location = new Point(51, 60);
        materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
        materialLabel2.Name = "materialLabel2";
        materialLabel2.RightToLeft = RightToLeft.No;
        materialLabel2.Size = new Size(87, 56);
        materialLabel2.TabIndex = 4;
        materialLabel2.Text = "Contraseña";
        materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // materialLabel1
        // 
        materialLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        materialLabel1.AutoSize = true;
        materialLabel1.Depth = 0;
        materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        materialLabel1.Location = new Point(51, 0);
        materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        materialLabel1.Name = "materialLabel1";
        materialLabel1.RightToLeft = RightToLeft.No;
        materialLabel1.Size = new Size(87, 60);
        materialLabel1.TabIndex = 1;
        materialLabel1.Text = "Usuario";
        materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // materialTextBox1
        // 
        materialTextBox1.AnimateReadOnly = false;
        materialTextBox1.BorderStyle = BorderStyle.None;
        materialTextBox1.Depth = 0;
        materialTextBox1.Dock = DockStyle.Fill;
        materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        materialTextBox1.LeadingIcon = null;
        materialTextBox1.Location = new Point(144, 3);
        materialTextBox1.MaxLength = 50;
        materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
        materialTextBox1.Multiline = false;
        materialTextBox1.Name = "materialTextBox1";
        materialTextBox1.Size = new Size(171, 50);
        materialTextBox1.TabIndex = 2;
        materialTextBox1.Text = "";
        materialTextBox1.TrailingIcon = null;
        // 
        // pictureBox2
        // 
        pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pictureBox2.Image = Properties.Resources.key2;
        pictureBox2.Location = new Point(3, 63);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(42, 50);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // materialSwitch1
        // 
        materialSwitch1.Anchor = AnchorStyles.None;
        materialSwitch1.Depth = 0;
        materialSwitch1.Location = new Point(20, 151);
        materialSwitch1.Margin = new Padding(0);
        materialSwitch1.MouseLocation = new Point(-1, -1);
        materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
        materialSwitch1.Name = "materialSwitch1";
        materialSwitch1.Ripple = true;
        materialSwitch1.Size = new Size(210, 24);
        materialSwitch1.TabIndex = 6;
        materialSwitch1.Text = "Mostrar contraseña";
        materialSwitch1.TextAlign = ContentAlignment.MiddleCenter;
        materialSwitch1.UseVisualStyleBackColor = true;
        // 
        // materialButton1
        // 
        materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        materialButton1.Depth = 0;
        materialButton1.HighEmphasis = true;
        materialButton1.Icon = null;
        materialButton1.Location = new Point(63, 228);
        materialButton1.Margin = new Padding(4, 6, 4, 6);
        materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
        materialButton1.Name = "materialButton1";
        materialButton1.NoAccentTextColor = Color.Empty;
        materialButton1.Size = new Size(91, 36);
        materialButton1.TabIndex = 1;
        materialButton1.Text = "Ingresar";
        materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        materialButton1.UseAccentColor = false;
        materialButton1.UseVisualStyleBackColor = true;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = Properties.Resources.logo2;
        pictureBox3.Location = new Point(39, 27);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(407, 236);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 3;
        pictureBox3.TabStop = false;
        // 
        // Form3
        // 
        ClientSize = new Size(584, 790);
        Controls.Add(materialCard1);
        Controls.Add(pictureBox3);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        FormStyle = FormStyles.ActionBar_None;
        MaximizeBox = false;
        Name = "Form3";
        Padding = new Padding(3, 24, 35, 5);
        RightToLeft = RightToLeft.No;
        SizeGripStyle = SizeGripStyle.Hide;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        materialCard1.ResumeLayout(false);
        materialCard1.PerformLayout();
        materialCard2.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);

    }

    #endregion
    private TableLayoutPanel tableLayoutPanel1;
    private MaterialSkin.Controls.MaterialCard materialCard2;
    private PictureBox pictureBox1;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    private PictureBox pictureBox2;
    private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
    private MaterialSkin.Controls.MaterialButton materialButton1;
    private MaterialSkin.Controls.MaterialButton materialButton2;
    private PictureBox pictureBox3;
    private RoundedMaterialCard materialCard1;
}