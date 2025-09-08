namespace PatitaSystem.Presentacion.Forms
{
    partial class Turnos_Form
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
            transparentCard1 = new PatitaSystem.Presentacion.Controles.TransparentCard();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            TCARD_BaseIzqTurnos = new PatitaSystem.Presentacion.Controles.TransparentCard();
            TCARD_BaseCalendarPanel = new PatitaSystem.Presentacion.Controles.TransparentCard();
            CM_CalendarioTurno = new MonthCalendar();
            transparentCard3 = new PatitaSystem.Presentacion.Controles.TransparentCard();
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            transparentCard1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            TCARD_BaseIzqTurnos.SuspendLayout();
            TCARD_BaseCalendarPanel.SuspendLayout();
            transparentCard3.SuspendLayout();
            SuspendLayout();
            // 
            // transparentCard1
            // 
            transparentCard1.BackColor = Color.FromArgb(255, 255, 255);
            transparentCard1.Controls.Add(tableLayoutPanel1);
            transparentCard1.Depth = 0;
            transparentCard1.Dock = DockStyle.Top;
            transparentCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            transparentCard1.Location = new Point(3, 64);
            transparentCard1.Margin = new Padding(14);
            transparentCard1.MouseState = MaterialSkin.MouseState.HOVER;
            transparentCard1.Name = "transparentCard1";
            transparentCard1.Padding = new Padding(14);
            transparentCard1.Size = new Size(794, 111);
            transparentCard1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.853754F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.14625F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 290F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(materialButton1, 3, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(materialTextBox21, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(14, 14);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(766, 83);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(materialFloatingActionButton2, 0, 0);
            tableLayoutPanel3.Controls.Add(materialLabel2, 0, 1);
            tableLayoutPanel3.Location = new Point(13, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 64.93507F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35.0649338F));
            tableLayoutPanel3.Size = new Size(52, 77);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.Icon = Properties.Resources.back;
            materialFloatingActionButton2.Location = new Point(3, 7);
            materialFloatingActionButton2.Mini = true;
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(46, 40);
            materialFloatingActionButton2.TabIndex = 2;
            materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(3, 50);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(45, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Volver";
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(529, 23);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(233, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "+ Nuevo Turno";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(materialFloatingActionButton1, 0, 0);
            tableLayoutPanel2.Controls.Add(materialLabel1, 0, 1);
            tableLayoutPanel2.Location = new Point(71, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 64.93507F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35.0649338F));
            tableLayoutPanel2.Size = new Size(48, 77);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.Icon = Properties.Resources.menu2;
            materialFloatingActionButton1.Location = new Point(3, 7);
            materialFloatingActionButton1.Mini = true;
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(42, 40);
            materialFloatingActionButton1.TabIndex = 2;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(3, 50);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(41, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Menu";
            // 
            // materialTextBox21
            // 
            materialTextBox21.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HelperText = "Buscar";
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(238, 17);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(284, 48);
            materialTextBox21.TabIndex = 0;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // TCARD_BaseIzqTurnos
            // 
            TCARD_BaseIzqTurnos.BackColor = Color.FromArgb(255, 255, 255);
            TCARD_BaseIzqTurnos.Controls.Add(TCARD_BaseCalendarPanel);
            TCARD_BaseIzqTurnos.Depth = 0;
            TCARD_BaseIzqTurnos.Dock = DockStyle.Left;
            TCARD_BaseIzqTurnos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            TCARD_BaseIzqTurnos.Location = new Point(3, 175);
            TCARD_BaseIzqTurnos.Margin = new Padding(14);
            TCARD_BaseIzqTurnos.MouseState = MaterialSkin.MouseState.HOVER;
            TCARD_BaseIzqTurnos.Name = "TCARD_BaseIzqTurnos";
            TCARD_BaseIzqTurnos.Padding = new Padding(14);
            TCARD_BaseIzqTurnos.Size = new Size(315, 367);
            TCARD_BaseIzqTurnos.TabIndex = 1;
            // 
            // TCARD_BaseCalendarPanel
            // 
            TCARD_BaseCalendarPanel.BackColor = Color.FromArgb(255, 255, 255);
            TCARD_BaseCalendarPanel.Controls.Add(materialSwitch1);
            TCARD_BaseCalendarPanel.Controls.Add(CM_CalendarioTurno);
            TCARD_BaseCalendarPanel.Depth = 0;
            TCARD_BaseCalendarPanel.Dock = DockStyle.Top;
            TCARD_BaseCalendarPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            TCARD_BaseCalendarPanel.Location = new Point(14, 14);
            TCARD_BaseCalendarPanel.Margin = new Padding(14);
            TCARD_BaseCalendarPanel.MouseState = MaterialSkin.MouseState.HOVER;
            TCARD_BaseCalendarPanel.Name = "TCARD_BaseCalendarPanel";
            TCARD_BaseCalendarPanel.Padding = new Padding(8);
            TCARD_BaseCalendarPanel.Size = new Size(287, 242);
            TCARD_BaseCalendarPanel.TabIndex = 0;
            // 
            // CM_CalendarioTurno
            // 
            CM_CalendarioTurno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CM_CalendarioTurno.BackColor = Color.FromArgb(48, 48, 48);
            CM_CalendarioTurno.FirstDayOfWeek = Day.Monday;
            CM_CalendarioTurno.Font = new Font("Segoe UI", 9F);
            CM_CalendarioTurno.ForeColor = Color.Gainsboro;
            CM_CalendarioTurno.Location = new Point(18, 15);
            CM_CalendarioTurno.Margin = new Padding(15);
            CM_CalendarioTurno.MaxSelectionCount = 1;
            CM_CalendarioTurno.Name = "CM_CalendarioTurno";
            CM_CalendarioTurno.ShowTodayCircle = false;
            CM_CalendarioTurno.TabIndex = 0;
            CM_CalendarioTurno.TitleBackColor = Color.FromArgb(0, 121, 107);
            CM_CalendarioTurno.TitleForeColor = Color.White;
            CM_CalendarioTurno.TrailingForeColor = Color.FromArgb(120, 120, 120);
            // 
            // transparentCard3
            // 
            transparentCard3.BackColor = Color.FromArgb(255, 255, 255);
            transparentCard3.Controls.Add(materialListView1);
            transparentCard3.Depth = 0;
            transparentCard3.Dock = DockStyle.Right;
            transparentCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            transparentCard3.Location = new Point(332, 175);
            transparentCard3.Margin = new Padding(14);
            transparentCard3.MouseState = MaterialSkin.MouseState.HOVER;
            transparentCard3.Name = "transparentCard3";
            transparentCard3.Padding = new Padding(14);
            transparentCard3.Size = new Size(465, 367);
            transparentCard3.TabIndex = 2;
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Depth = 0;
            materialListView1.Dock = DockStyle.Top;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(14, 14);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(437, 145);
            materialListView1.TabIndex = 0;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // materialSwitch1
            // 
            materialSwitch1.AutoSize = true;
            materialSwitch1.Depth = 0;
            materialSwitch1.Location = new Point(18, 186);
            materialSwitch1.Margin = new Padding(0);
            materialSwitch1.MouseLocation = new Point(-1, -1);
            materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitch1.Name = "materialSwitch1";
            materialSwitch1.Ripple = true;
            materialSwitch1.Size = new Size(200, 37);
            materialSwitch1.TabIndex = 1;
            materialSwitch1.Text = "Mostrar Disponibles";
            materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // Turnos_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 545);
            Controls.Add(transparentCard3);
            Controls.Add(TCARD_BaseIzqTurnos);
            Controls.Add(transparentCard1);
            Name = "Turnos_Form";
            Text = "PatitaShop - Turnos";
            transparentCard1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            TCARD_BaseIzqTurnos.ResumeLayout(false);
            TCARD_BaseCalendarPanel.ResumeLayout(false);
            TCARD_BaseCalendarPanel.PerformLayout();
            transparentCard3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controles.TransparentCard transparentCard1;
        private Controles.TransparentCard TCARD_BaseIzqTurnos;
        private Controles.TransparentCard transparentCard3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MonthCalendar CM_CalendarioTurno;
        private Controles.TransparentCard TCARD_BaseCalendarPanel;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
    }
}