using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PatitaSystem;

partial class Dashboard_Form : MaterialForm
{
    private System.ComponentModel.IContainer components = null;

    private MaterialDrawer DRW_Menu;
    private MaterialButton BTN_Menu;
    private PictureBox PIC_Logo;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }


    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        DRW_Menu = new MaterialDrawer();
        TABS_MenuPatita = new MaterialTabControl();
        TAB_PatitaShop = new TabPage();
        materialCard1 = new MaterialCard();
        LYOUT_PanelPatitaShop = new TableLayoutPanel();
        BTN_Ventas = new MaterialFloatingActionButton();
        LBL_Productos = new MaterialLabel();
        BTN_Productos = new MaterialFloatingActionButton();
        LBL_Ventas = new MaterialLabel();
        TAB_PatitaPelu = new TabPage();
        CARD_PatitaPelu = new MaterialCard();
        LYOUT_PanelPatitaPelu = new TableLayoutPanel();
        BTN_Mascotas = new MaterialFloatingActionButton();
        LBL_Turnos = new MaterialLabel();
        BTN_Turnos = new MaterialFloatingActionButton();
        LBL_Mascotas = new MaterialLabel();
        TAB_PatitaAdmin = new TabPage();
        materialCard2 = new MaterialCard();
        tableLayoutPanel1 = new TableLayoutPanel();
        materialFloatingActionButton1 = new MaterialFloatingActionButton();
        LBL_Menu = new MaterialLabel();
        BTN_AdminMenu = new MaterialFloatingActionButton();
        materialLabel2 = new MaterialLabel();
        BTN_Menu = new MaterialButton();
        PIC_Logo = new PictureBox();
        TABS_MenuPatita.SuspendLayout();
        TAB_PatitaShop.SuspendLayout();
        materialCard1.SuspendLayout();
        LYOUT_PanelPatitaShop.SuspendLayout();
        TAB_PatitaPelu.SuspendLayout();
        CARD_PatitaPelu.SuspendLayout();
        LYOUT_PanelPatitaPelu.SuspendLayout();
        TAB_PatitaAdmin.SuspendLayout();
        materialCard2.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PIC_Logo).BeginInit();
        SuspendLayout();
        // 
        // DRW_Menu
        // 
        DRW_Menu.AutoHide = false;
        DRW_Menu.AutoShow = false;
        DRW_Menu.BackgroundWithAccent = false;
        DRW_Menu.BaseTabControl = TABS_MenuPatita;
        DRW_Menu.Depth = 0;
        DRW_Menu.Dock = DockStyle.Left;
        DRW_Menu.HighlightWithAccent = true;
        DRW_Menu.IndicatorWidth = 0;
        DRW_Menu.IsOpen = false;
        DRW_Menu.Location = new Point(3, 24);
        DRW_Menu.MouseState = MouseState.HOVER;
        DRW_Menu.Name = "DRW_Menu";
        DRW_Menu.ShowIconsWhenHidden = false;
        DRW_Menu.Size = new Size(188, 573);
        DRW_Menu.TabIndex = 0;
        DRW_Menu.UseColors = false;
        DRW_Menu.Visible = false;
        // 
        // TABS_MenuPatita
        // 
        TABS_MenuPatita.Anchor = AnchorStyles.None;
        TABS_MenuPatita.Controls.Add(TAB_PatitaShop);
        TABS_MenuPatita.Controls.Add(TAB_PatitaPelu);
        TABS_MenuPatita.Controls.Add(TAB_PatitaAdmin);
        TABS_MenuPatita.Depth = 0;
        TABS_MenuPatita.Location = new Point(215, 279);
        TABS_MenuPatita.MouseState = MouseState.HOVER;
        TABS_MenuPatita.Multiline = true;
        TABS_MenuPatita.Name = "TABS_MenuPatita";
        TABS_MenuPatita.SelectedIndex = 0;
        TABS_MenuPatita.Size = new Size(407, 294);
        TABS_MenuPatita.TabIndex = 2;
        TABS_MenuPatita.Visible = false;
        // 
        // TAB_PatitaShop
        // 
        TAB_PatitaShop.BackColor = Color.White;
        TAB_PatitaShop.Controls.Add(materialCard1);
        TAB_PatitaShop.Location = new Point(4, 24);
        TAB_PatitaShop.Margin = new Padding(6);
        TAB_PatitaShop.Name = "TAB_PatitaShop";
        TAB_PatitaShop.Padding = new Padding(10);
        TAB_PatitaShop.Size = new Size(399, 266);
        TAB_PatitaShop.TabIndex = 0;
        TAB_PatitaShop.Text = "PatitaShop";
        // 
        // materialCard1
        // 
        materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        materialCard1.AutoScroll = true;
        materialCard1.BackColor = Color.FromArgb(255, 255, 255);
        materialCard1.Controls.Add(LYOUT_PanelPatitaShop);
        materialCard1.Depth = 0;
        materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
        materialCard1.Location = new Point(24, 24);
        materialCard1.Margin = new Padding(14);
        materialCard1.MouseState = MouseState.HOVER;
        materialCard1.Name = "materialCard1";
        materialCard1.Padding = new Padding(20);
        materialCard1.Size = new Size(351, 218);
        materialCard1.TabIndex = 0;
        // 
        // LYOUT_PanelPatitaShop
        // 
        LYOUT_PanelPatitaShop.ColumnCount = 2;
        LYOUT_PanelPatitaShop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        LYOUT_PanelPatitaShop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        LYOUT_PanelPatitaShop.Controls.Add(BTN_Ventas, 1, 0);
        LYOUT_PanelPatitaShop.Controls.Add(LBL_Productos, 0, 1);
        LYOUT_PanelPatitaShop.Controls.Add(BTN_Productos, 0, 0);
        LYOUT_PanelPatitaShop.Controls.Add(LBL_Ventas, 1, 1);
        LYOUT_PanelPatitaShop.Dock = DockStyle.Fill;
        LYOUT_PanelPatitaShop.Location = new Point(20, 20);
        LYOUT_PanelPatitaShop.Margin = new Padding(0);
        LYOUT_PanelPatitaShop.Name = "LYOUT_PanelPatitaShop";
        LYOUT_PanelPatitaShop.RowCount = 2;
        LYOUT_PanelPatitaShop.RowStyles.Add(new RowStyle(SizeType.Percent, 45.91195F));
        LYOUT_PanelPatitaShop.RowStyles.Add(new RowStyle(SizeType.Percent, 54.08805F));
        LYOUT_PanelPatitaShop.Size = new Size(311, 178);
        LYOUT_PanelPatitaShop.TabIndex = 0;
        // 
        // BTN_Ventas
        // 
        BTN_Ventas.Anchor = AnchorStyles.Bottom;
        BTN_Ventas.BackColor = Color.Transparent;
        BTN_Ventas.Depth = 0;
        BTN_Ventas.Icon = Properties.Resources.icon_sale2;
        BTN_Ventas.Location = new Point(205, 22);
        BTN_Ventas.MouseState = MouseState.HOVER;
        BTN_Ventas.Name = "BTN_Ventas";
        BTN_Ventas.Size = new Size(56, 56);
        BTN_Ventas.TabIndex = 2;
        BTN_Ventas.Text = "Agregar Producto";
        BTN_Ventas.UseCompatibleTextRendering = true;
        BTN_Ventas.UseVisualStyleBackColor = false;
        // 
        // LBL_Productos
        // 
        LBL_Productos.Anchor = AnchorStyles.Top;
        LBL_Productos.Depth = 0;
        LBL_Productos.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        LBL_Productos.FontType = MaterialSkinManager.fontType.Subtitle2;
        LBL_Productos.Location = new Point(27, 81);
        LBL_Productos.MouseState = MouseState.HOVER;
        LBL_Productos.Name = "LBL_Productos";
        LBL_Productos.Size = new Size(101, 39);
        LBL_Productos.TabIndex = 1;
        LBL_Productos.Text = "Productos";
        LBL_Productos.TextAlign = ContentAlignment.TopCenter;
        // 
        // BTN_Productos
        // 
        BTN_Productos.Anchor = AnchorStyles.Bottom;
        BTN_Productos.BackColor = Color.Transparent;
        BTN_Productos.Depth = 0;
        BTN_Productos.Icon = Properties.Resources.add_producto;
        BTN_Productos.Location = new Point(49, 22);
        BTN_Productos.MouseState = MouseState.HOVER;
        BTN_Productos.Name = "BTN_Productos";
        BTN_Productos.Size = new Size(56, 56);
        BTN_Productos.TabIndex = 0;
        BTN_Productos.Text = "Agregar Producto";
        BTN_Productos.UseCompatibleTextRendering = true;
        BTN_Productos.UseVisualStyleBackColor = false;
        // 
        // LBL_Ventas
        // 
        LBL_Ventas.Anchor = AnchorStyles.Top;
        LBL_Ventas.Depth = 0;
        LBL_Ventas.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        LBL_Ventas.FontType = MaterialSkinManager.fontType.Subtitle2;
        LBL_Ventas.Location = new Point(186, 81);
        LBL_Ventas.MouseState = MouseState.HOVER;
        LBL_Ventas.Name = "LBL_Ventas";
        LBL_Ventas.Size = new Size(94, 39);
        LBL_Ventas.TabIndex = 3;
        LBL_Ventas.Text = "Ventas";
        LBL_Ventas.TextAlign = ContentAlignment.TopCenter;
        // 
        // TAB_PatitaPelu
        // 
        TAB_PatitaPelu.BackColor = Color.White;
        TAB_PatitaPelu.Controls.Add(CARD_PatitaPelu);
        TAB_PatitaPelu.Location = new Point(4, 24);
        TAB_PatitaPelu.Name = "TAB_PatitaPelu";
        TAB_PatitaPelu.Padding = new Padding(10);
        TAB_PatitaPelu.Size = new Size(399, 266);
        TAB_PatitaPelu.TabIndex = 1;
        TAB_PatitaPelu.Text = "PatitaPelu";
        // 
        // CARD_PatitaPelu
        // 
        CARD_PatitaPelu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        CARD_PatitaPelu.AutoScroll = true;
        CARD_PatitaPelu.BackColor = Color.FromArgb(255, 255, 255);
        CARD_PatitaPelu.Controls.Add(LYOUT_PanelPatitaPelu);
        CARD_PatitaPelu.Depth = 0;
        CARD_PatitaPelu.ForeColor = Color.FromArgb(222, 0, 0, 0);
        CARD_PatitaPelu.Location = new Point(24, 24);
        CARD_PatitaPelu.Margin = new Padding(14);
        CARD_PatitaPelu.MouseState = MouseState.HOVER;
        CARD_PatitaPelu.Name = "CARD_PatitaPelu";
        CARD_PatitaPelu.Padding = new Padding(20);
        CARD_PatitaPelu.Size = new Size(351, 218);
        CARD_PatitaPelu.TabIndex = 1;
        // 
        // LYOUT_PanelPatitaPelu
        // 
        LYOUT_PanelPatitaPelu.ColumnCount = 2;
        LYOUT_PanelPatitaPelu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        LYOUT_PanelPatitaPelu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        LYOUT_PanelPatitaPelu.Controls.Add(BTN_Mascotas, 1, 0);
        LYOUT_PanelPatitaPelu.Controls.Add(LBL_Turnos, 0, 1);
        LYOUT_PanelPatitaPelu.Controls.Add(BTN_Turnos, 0, 0);
        LYOUT_PanelPatitaPelu.Controls.Add(LBL_Mascotas, 1, 1);
        LYOUT_PanelPatitaPelu.Dock = DockStyle.Fill;
        LYOUT_PanelPatitaPelu.Location = new Point(20, 20);
        LYOUT_PanelPatitaPelu.Margin = new Padding(0);
        LYOUT_PanelPatitaPelu.Name = "LYOUT_PanelPatitaPelu";
        LYOUT_PanelPatitaPelu.RowCount = 2;
        LYOUT_PanelPatitaPelu.RowStyles.Add(new RowStyle(SizeType.Percent, 45.91195F));
        LYOUT_PanelPatitaPelu.RowStyles.Add(new RowStyle(SizeType.Percent, 54.08805F));
        LYOUT_PanelPatitaPelu.Size = new Size(311, 178);
        LYOUT_PanelPatitaPelu.TabIndex = 0;
        // 
        // BTN_Mascotas
        // 
        BTN_Mascotas.Anchor = AnchorStyles.Bottom;
        BTN_Mascotas.BackColor = Color.Transparent;
        BTN_Mascotas.Depth = 0;
        BTN_Mascotas.Icon = Properties.Resources.icon_dog;
        BTN_Mascotas.Location = new Point(203, 22);
        BTN_Mascotas.MouseState = MouseState.HOVER;
        BTN_Mascotas.Name = "BTN_Mascotas";
        BTN_Mascotas.Size = new Size(59, 56);
        BTN_Mascotas.TabIndex = 2;
        BTN_Mascotas.Text = "Mascotas";
        BTN_Mascotas.UseCompatibleTextRendering = true;
        BTN_Mascotas.UseVisualStyleBackColor = false;
        // 
        // LBL_Turnos
        // 
        LBL_Turnos.Anchor = AnchorStyles.Top;
        LBL_Turnos.Depth = 0;
        LBL_Turnos.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        LBL_Turnos.FontType = MaterialSkinManager.fontType.Subtitle2;
        LBL_Turnos.Location = new Point(27, 81);
        LBL_Turnos.MouseState = MouseState.HOVER;
        LBL_Turnos.Name = "LBL_Turnos";
        LBL_Turnos.Size = new Size(101, 39);
        LBL_Turnos.TabIndex = 1;
        LBL_Turnos.Text = "Turnos";
        LBL_Turnos.TextAlign = ContentAlignment.TopCenter;
        // 
        // BTN_Turnos
        // 
        BTN_Turnos.Anchor = AnchorStyles.Bottom;
        BTN_Turnos.BackColor = Color.Transparent;
        BTN_Turnos.Depth = 0;
        BTN_Turnos.Icon = Properties.Resources.calendar;
        BTN_Turnos.Location = new Point(49, 22);
        BTN_Turnos.MouseState = MouseState.HOVER;
        BTN_Turnos.Name = "BTN_Turnos";
        BTN_Turnos.Size = new Size(56, 56);
        BTN_Turnos.TabIndex = 0;
        BTN_Turnos.Text = "Turnos";
        BTN_Turnos.UseCompatibleTextRendering = true;
        BTN_Turnos.UseVisualStyleBackColor = false;
        // 
        // LBL_Mascotas
        // 
        LBL_Mascotas.Anchor = AnchorStyles.Top;
        LBL_Mascotas.Depth = 0;
        LBL_Mascotas.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        LBL_Mascotas.FontType = MaterialSkinManager.fontType.Subtitle2;
        LBL_Mascotas.Location = new Point(186, 81);
        LBL_Mascotas.MouseState = MouseState.HOVER;
        LBL_Mascotas.Name = "LBL_Mascotas";
        LBL_Mascotas.Size = new Size(94, 39);
        LBL_Mascotas.TabIndex = 3;
        LBL_Mascotas.Text = "Mascotas";
        LBL_Mascotas.TextAlign = ContentAlignment.TopCenter;
        // 
        // TAB_PatitaAdmin
        // 
        TAB_PatitaAdmin.Controls.Add(materialCard2);
        TAB_PatitaAdmin.Location = new Point(4, 24);
        TAB_PatitaAdmin.Name = "TAB_PatitaAdmin";
        TAB_PatitaAdmin.Padding = new Padding(3);
        TAB_PatitaAdmin.Size = new Size(399, 266);
        TAB_PatitaAdmin.TabIndex = 2;
        TAB_PatitaAdmin.Text = "PatitaAdmin";
        TAB_PatitaAdmin.UseVisualStyleBackColor = true;
        // 
        // materialCard2
        // 
        materialCard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        materialCard2.AutoScroll = true;
        materialCard2.BackColor = Color.FromArgb(255, 255, 255);
        materialCard2.Controls.Add(tableLayoutPanel1);
        materialCard2.Depth = 0;
        materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
        materialCard2.Location = new Point(24, 24);
        materialCard2.Margin = new Padding(14);
        materialCard2.MouseState = MouseState.HOVER;
        materialCard2.Name = "materialCard2";
        materialCard2.Padding = new Padding(20);
        materialCard2.Size = new Size(351, 218);
        materialCard2.TabIndex = 2;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(materialFloatingActionButton1, 1, 0);
        tableLayoutPanel1.Controls.Add(LBL_Menu, 0, 1);
        tableLayoutPanel1.Controls.Add(BTN_AdminMenu, 0, 0);
        tableLayoutPanel1.Controls.Add(materialLabel2, 1, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(20, 20);
        tableLayoutPanel1.Margin = new Padding(0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.91195F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.08805F));
        tableLayoutPanel1.Size = new Size(311, 178);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // materialFloatingActionButton1
        // 
        materialFloatingActionButton1.Anchor = AnchorStyles.Bottom;
        materialFloatingActionButton1.BackColor = Color.Transparent;
        materialFloatingActionButton1.Depth = 0;
        materialFloatingActionButton1.Icon = Properties.Resources.icon_dog;
        materialFloatingActionButton1.Location = new Point(203, 22);
        materialFloatingActionButton1.MouseState = MouseState.HOVER;
        materialFloatingActionButton1.Name = "materialFloatingActionButton1";
        materialFloatingActionButton1.Size = new Size(59, 56);
        materialFloatingActionButton1.TabIndex = 2;
        materialFloatingActionButton1.Text = "Mascotas";
        materialFloatingActionButton1.UseCompatibleTextRendering = true;
        materialFloatingActionButton1.UseVisualStyleBackColor = false;
        // 
        // LBL_Menu
        // 
        LBL_Menu.Anchor = AnchorStyles.Top;
        LBL_Menu.Depth = 0;
        LBL_Menu.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        LBL_Menu.FontType = MaterialSkinManager.fontType.Subtitle2;
        LBL_Menu.Location = new Point(27, 81);
        LBL_Menu.MouseState = MouseState.HOVER;
        LBL_Menu.Name = "LBL_Menu";
        LBL_Menu.Size = new Size(101, 39);
        LBL_Menu.TabIndex = 1;
        LBL_Menu.Text = "Menu";
        LBL_Menu.TextAlign = ContentAlignment.TopCenter;
        // 
        // BTN_AdminMenu
        // 
        BTN_AdminMenu.Anchor = AnchorStyles.Bottom;
        BTN_AdminMenu.BackColor = Color.Transparent;
        BTN_AdminMenu.Depth = 0;
        BTN_AdminMenu.Icon = Properties.Resources.calendar;
        BTN_AdminMenu.Location = new Point(49, 22);
        BTN_AdminMenu.MouseState = MouseState.HOVER;
        BTN_AdminMenu.Name = "BTN_AdminMenu";
        BTN_AdminMenu.Size = new Size(56, 56);
        BTN_AdminMenu.TabIndex = 0;
        BTN_AdminMenu.Text = "Turnos";
        BTN_AdminMenu.UseCompatibleTextRendering = true;
        BTN_AdminMenu.UseVisualStyleBackColor = false;
        BTN_AdminMenu.Click += BTN_AdminMenu_Click;
        // 
        // materialLabel2
        // 
        materialLabel2.Anchor = AnchorStyles.Top;
        materialLabel2.Depth = 0;
        materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        materialLabel2.FontType = MaterialSkinManager.fontType.Subtitle2;
        materialLabel2.Location = new Point(186, 81);
        materialLabel2.MouseState = MouseState.HOVER;
        materialLabel2.Name = "materialLabel2";
        materialLabel2.Size = new Size(94, 39);
        materialLabel2.TabIndex = 3;
        materialLabel2.Text = "Mascotas";
        materialLabel2.TextAlign = ContentAlignment.TopCenter;
        // 
        // BTN_Menu
        // 
        BTN_Menu.AutoSize = false;
        BTN_Menu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BTN_Menu.Density = MaterialButton.MaterialButtonDensity.Default;
        BTN_Menu.Depth = 0;
        BTN_Menu.HighEmphasis = true;
        BTN_Menu.Icon = null;
        BTN_Menu.Location = new Point(544, 253);
        BTN_Menu.Margin = new Padding(4, 6, 4, 6);
        BTN_Menu.MouseState = MouseState.HOVER;
        BTN_Menu.Name = "BTN_Menu";
        BTN_Menu.NoAccentTextColor = Color.Empty;
        BTN_Menu.Size = new Size(78, 36);
        BTN_Menu.TabIndex = 1;
        BTN_Menu.Text = "Menú";
        BTN_Menu.Type = MaterialButton.MaterialButtonType.Contained;
        BTN_Menu.UseAccentColor = false;
        BTN_Menu.UseVisualStyleBackColor = true;
        BTN_Menu.Click += BTN_Menu_Click;
        // 
        // PIC_Logo
        // 
        PIC_Logo.Image = Properties.Resources.logo2;
        PIC_Logo.Location = new Point(215, 60);
        PIC_Logo.Name = "PIC_Logo";
        PIC_Logo.Size = new Size(417, 191);
        PIC_Logo.SizeMode = PictureBoxSizeMode.Zoom;
        PIC_Logo.TabIndex = 3;
        PIC_Logo.TabStop = false;
        // 
        // Dashboard_Form
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(659, 600);
        Controls.Add(BTN_Menu);
        Controls.Add(DRW_Menu);
        Controls.Add(PIC_Logo);
        Controls.Add(TABS_MenuPatita);
        FormStyle = FormStyles.ActionBar_None;
        Name = "Dashboard_Form";
        Padding = new Padding(3, 24, 3, 3);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dashboard";
        TABS_MenuPatita.ResumeLayout(false);
        TAB_PatitaShop.ResumeLayout(false);
        materialCard1.ResumeLayout(false);
        LYOUT_PanelPatitaShop.ResumeLayout(false);
        TAB_PatitaPelu.ResumeLayout(false);
        CARD_PatitaPelu.ResumeLayout(false);
        LYOUT_PanelPatitaPelu.ResumeLayout(false);
        TAB_PatitaAdmin.ResumeLayout(false);
        materialCard2.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PIC_Logo).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private MaterialTabControl TABS_MenuPatita;
    private TabPage TAB_PatitaShop;
    private MaterialCard materialCard1;
    private TabPage TAB_PatitaPelu;
    private TableLayoutPanel LYOUT_PanelPatitaShop;
    private MaterialFloatingActionButton BTN_Productos;
    private MaterialLabel LBL_Productos;
    private MaterialFloatingActionButton BTN_Ventas;
    private MaterialLabel LBL_Ventas;
    private MaterialCard CARD_PatitaPelu;
    private TableLayoutPanel LYOUT_PanelPatitaPelu;
    private MaterialFloatingActionButton BTN_Mascotas;
    private MaterialLabel LBL_Turnos;
    private MaterialFloatingActionButton BTN_Turnos;
    private MaterialLabel LBL_Mascotas;
    private TabPage TAB_PatitaAdmin;
    private MaterialCard materialCard2;
    private TableLayoutPanel tableLayoutPanel1;
    private MaterialFloatingActionButton materialFloatingActionButton1;
    private MaterialLabel LBL_Menu;
    private MaterialFloatingActionButton BTN_AdminMenu;
    private MaterialLabel materialLabel2;
}
