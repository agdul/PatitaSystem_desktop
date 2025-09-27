using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PatitaSystem.Presentacion.Forms
{
    partial class FormVendedor
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
            materialTabVendedor = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            listViewVendedor1 = new MaterialSkin.Controls.MaterialListView();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            tabPage2 = new TabPage();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            listViewPelu = new MaterialSkin.Controls.MaterialListView();
            monthCalendar1 = new MonthCalendar();
            tabPage3 = new TabPage();
            drawerVendedor = new MaterialSkin.Controls.MaterialDrawer();
            materialTabVendedor.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabVendedor
            // 
            materialTabVendedor.Controls.Add(tabPage1);
            materialTabVendedor.Controls.Add(tabPage2);
            materialTabVendedor.Controls.Add(tabPage3);
            materialTabVendedor.Depth = 0;
            materialTabVendedor.Location = new Point(336, 85);
            materialTabVendedor.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabVendedor.Multiline = true;
            materialTabVendedor.Name = "materialTabVendedor";
            materialTabVendedor.SelectedIndex = 0;
            materialTabVendedor.Size = new Size(554, 463);
            materialTabVendedor.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listViewVendedor1);
            tabPage1.Controls.Add(materialButton1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(546, 430);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Productos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewVendedor1
            // 
            listViewVendedor1.AutoSizeTable = false;
            listViewVendedor1.BackColor = Color.FromArgb(255, 255, 255);
            listViewVendedor1.BorderStyle = BorderStyle.None;
            listViewVendedor1.Depth = 0;
            listViewVendedor1.FullRowSelect = true;
            listViewVendedor1.Location = new Point(16, 27);
            listViewVendedor1.MinimumSize = new Size(200, 100);
            listViewVendedor1.MouseLocation = new Point(-1, -1);
            listViewVendedor1.MouseState = MaterialSkin.MouseState.OUT;
            listViewVendedor1.Name = "listViewVendedor1";
            listViewVendedor1.OwnerDraw = true;
            listViewVendedor1.Size = new Size(511, 162);
            listViewVendedor1.TabIndex = 1;
            listViewVendedor1.UseCompatibleStateImageBehavior = false;
            listViewVendedor1.View = View.Details;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(53, 257);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(152, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "Agregar Carrito";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(materialButton3);
            tabPage2.Controls.Add(materialButton2);
            tabPage2.Controls.Add(listViewPelu);
            tabPage2.Controls.Add(monthCalendar1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(546, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Peluqeria";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(360, 388);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(158, 36);
            materialButton3.TabIndex = 3;
            materialButton3.Text = "materialButton3";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(64, 385);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(135, 36);
            materialButton2.TabIndex = 2;
            materialButton2.Text = "Asignar Turno";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // listViewPelu
            // 
            listViewPelu.AutoSizeTable = false;
            listViewPelu.BackColor = Color.FromArgb(255, 255, 255);
            listViewPelu.BorderStyle = BorderStyle.None;
            listViewPelu.Depth = 0;
            listViewPelu.FullRowSelect = true;
            listViewPelu.Location = new Point(20, 231);
            listViewPelu.MinimumSize = new Size(200, 100);
            listViewPelu.MouseLocation = new Point(-1, -1);
            listViewPelu.MouseState = MaterialSkin.MouseState.OUT;
            listViewPelu.Name = "listViewPelu";
            listViewPelu.OwnerDraw = true;
            listViewPelu.Size = new Size(508, 125);
            listViewPelu.TabIndex = 1;
            listViewPelu.UseCompatibleStateImageBehavior = false;
            listViewPelu.View = View.Details;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(128, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(546, 430);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Perfil";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // drawerVendedor
            // 
            drawerVendedor.AutoHide = false;
            drawerVendedor.AutoShow = false;
            drawerVendedor.BackColor = SystemColors.ActiveBorder;
            drawerVendedor.BackgroundImageLayout = ImageLayout.Stretch;
            drawerVendedor.BackgroundWithAccent = false;
            drawerVendedor.BaseTabControl = null;
            drawerVendedor.Depth = 0;
            drawerVendedor.Dock = DockStyle.Left;
            drawerVendedor.HighlightWithAccent = true;
            drawerVendedor.IndicatorWidth = 0;
            drawerVendedor.IsOpen = true;
            drawerVendedor.Location = new Point(3, 64);
            drawerVendedor.MouseState = MaterialSkin.MouseState.HOVER;
            drawerVendedor.Name = "drawerVendedor";
            drawerVendedor.ShowIconsWhenHidden = false;
            drawerVendedor.Size = new Size(272, 499);
            drawerVendedor.TabIndex = 2;
            drawerVendedor.Text = "drawerVendedor";
            drawerVendedor.UseColors = false;
            drawerVendedor.Click += drawerVendedor_Click;
            // 
            // FormVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 566);
            Controls.Add(drawerVendedor);
            Controls.Add(materialTabVendedor);
            Name = "FormVendedor";
            Text = "Usuario: ";
            Load += FormVendedor_Load;
            materialTabVendedor.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabVendedor;
        private MaterialSkin.Controls.MaterialDrawer drawerVendedor;
        private TabPage tabPage1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MaterialSkin.Controls.MaterialListView listViewVendedor1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialListView listViewPelu;
        private MonthCalendar monthCalendar1;
    }
}