using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PatitaSystem;

public partial class Dashboard_Form : MaterialForm
{
    private bool _drawerShown = false;
    private System.Windows.Forms.Timer? _hideTmr;

    public Dashboard_Form()
    {
        InitializeComponent();

        try { 
          // MaterialSkin
          var skin = MaterialSkinManager.Instance;
          skin.AddFormToManage(this);
          skin.Theme = MaterialSkinManager.Themes.DARK;
          skin.ColorScheme = new ColorScheme(
             Primary.Teal700, Primary.Teal900, Primary.Teal500,
             Accent.Green200, TextShade.WHITE
          );

          // Asegurar que el Drawer NO esté en el árbol al iniciar
          if (Controls.Contains(DRW_Menu))
               Controls.Remove(DRW_Menu);

          // Centrar logo+botón al arrancar
          RelayoutNow();
        } 
        catch (Exception ex){
            MessageBox.Show("Error en constructor de Dashboard:\n\n" + ex,
               "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
           throw;
        }
    }

    // CLICK del botón
    private void materialButtonMenu_Click(object? sender, EventArgs e)
    {
        if (_drawerShown) CloseDrawer();
        else OpenDrawer();
    }

    // ABRIR
    private void OpenDrawer()
    {
        // Volver a insertar y dockear el Drawer
        if (!Controls.Contains(DRW_Menu))
            Controls.Add(DRW_Menu);

        DRW_Menu.Visible = true;
        DRW_Menu.Dock = DockStyle.Left;
        DRW_Menu.BringToFront();
        DRW_Menu.IsOpen = true;

        // Mostrar tabs a la derecha
        tabs.Visible = true;
        tabs.Left = DRW_Menu.Width;
        tabs.Width = ClientSize.Width - tabs.Left;

        _drawerShown = true;
        BTN_Menu.Text = "Cerrar";

        RelayoutNow();

        if (_hideTmr is not null) { _hideTmr.Stop(); _hideTmr.Dispose(); _hideTmr = null; }
    }

    // CERRAR
    private void CloseDrawer()
    {
        DRW_Menu.IsOpen = false;
        BTN_Menu.Text = "Menú";

        _hideTmr ??= new System.Windows.Forms.Timer { Interval = 220 };
        _hideTmr.Tick += (_, __) =>
        {
            _hideTmr!.Stop();
            _hideTmr.Dispose();
            _hideTmr = null;

            tabs.Visible = false;
            tabs.Left = 0;
            tabs.Width = ClientSize.Width;

            DRW_Menu.Visible = false;
            DRW_Menu.Dock = DockStyle.None;
            if (Controls.Contains(DRW_Menu))
                Controls.Remove(DRW_Menu);

            _drawerShown = false;

            RelayoutNow();
        };
        _hideTmr.Start();
    }

    // Mantener layout al redimensionar
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        if (tabs.Visible)
        {
            var left = Controls.Contains(DRW_Menu) && DRW_Menu.Visible ? DRW_Menu.Width : 0;
            tabs.Left = left;
            tabs.Width = ClientSize.Width - left;
        }

        RelayoutNow();
    }

    // ----- Utilidades de layout: mover logo + botón -----

    private void LayoutHero(bool drawerOpen)
    {
        int leftMargin = (Controls.Contains(DRW_Menu) && DRW_Menu.Visible) ? DRW_Menu.Width : 0;
        int availWidth = ClientSize.Width - leftMargin;

        int heroWidth = Math.Max(PIC_Logo.Width, BTN_Menu.Width);
        int heroLeft = leftMargin + (availWidth - heroWidth) / 2;

        // --- offsets verticales ---
        int baseTop = 150;           // altura cuando está CERRADO (lo que ya tenías)
        int shiftWhenOpen = -60;     // cuántos píxeles mover cuando está ABIERTO (negativo = subir)

        PIC_Logo.Left = heroLeft;
        PIC_Logo.Top = baseTop + (drawerOpen ? shiftWhenOpen : 0);

        BTN_Menu.Left = heroLeft + (heroWidth - BTN_Menu.Width) / 2;
        BTN_Menu.Top = PIC_Logo.Bottom - 45;   // separación con el logo
    }


    private void RelayoutNow() => LayoutHero(_drawerShown);


}
