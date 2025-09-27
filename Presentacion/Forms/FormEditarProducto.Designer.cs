namespace PatitaSystem.Presentacion.Forms
{
    partial class FormEditarProducto
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
            ListVierProducto = new MaterialSkin.Controls.MaterialListView();
            ELIMINARP = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // ListVierProducto
            // 
            ListVierProducto.AutoSizeTable = false;
            ListVierProducto.BackColor = Color.FromArgb(255, 255, 255);
            ListVierProducto.BorderStyle = BorderStyle.None;
            ListVierProducto.Depth = 0;
            ListVierProducto.FullRowSelect = true;
            ListVierProducto.Location = new Point(273, 183);
            ListVierProducto.MinimumSize = new Size(200, 100);
            ListVierProducto.MouseLocation = new Point(-1, -1);
            ListVierProducto.MouseState = MaterialSkin.MouseState.OUT;
            ListVierProducto.Name = "ListVierProducto";
            ListVierProducto.OwnerDraw = true;
            ListVierProducto.Size = new Size(250, 125);
            ListVierProducto.TabIndex = 0;
            ListVierProducto.UseCompatibleStateImageBehavior = false;
            ListVierProducto.View = View.Details;
            // 
            // ELIMINARP
            // 
            ELIMINARP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ELIMINARP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ELIMINARP.Depth = 0;
            ELIMINARP.HighEmphasis = true;
            ELIMINARP.Icon = null;
            ELIMINARP.Location = new Point(509, 351);
            ELIMINARP.Margin = new Padding(4, 6, 4, 6);
            ELIMINARP.MouseState = MaterialSkin.MouseState.HOVER;
            ELIMINARP.Name = "ELIMINARP";
            ELIMINARP.NoAccentTextColor = Color.Empty;
            ELIMINARP.Size = new Size(158, 36);
            ELIMINARP.TabIndex = 1;
            ELIMINARP.Text = "materialButton1";
            ELIMINARP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ELIMINARP.UseAccentColor = false;
            ELIMINARP.UseVisualStyleBackColor = true;
            // 
            // FormEditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ELIMINARP);
            Controls.Add(ListVierProducto);
            Name = "FormEditarProducto";
            Text = "Editar Usuario";
            Load += FormEditarUsuario_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView ListVierProducto;
        private MaterialSkin.Controls.MaterialButton ELIMINARP;
    }
}