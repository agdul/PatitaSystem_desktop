namespace PatitaSystem;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;

public partial class Login_Form : MaterialForm
{
    public Login_Form()
    {
        InitializeComponent();     // todo el diseño lo hacés en el Designer
        if (!DesignMode)           // evita ejecutar skin en el diseñador de VS
        {
            ConfigurarMaterialSkin();
            WireEvents();          // opcional: acá enganchás eventos (checkbox, etc.)
        }
        this.MinimumSize = new Size(488, 556);
        this.MaximumSize = new Size(488, 556);

    }

    private void ConfigurarMaterialSkin()
    {
        var skin = MaterialSkinManager.Instance;
        skin.AddFormToManage(this);

        // Elegí el tema y paleta que te gustó
        skin.Theme = MaterialSkinManager.Themes.DARK;
        skin.ColorScheme = new ColorScheme(
            Primary.Teal700, Primary.Teal900, Primary.Teal500,
            Accent.Green200, TextShade.WHITE
        );
        // Opcional:
        // skin.EnforceBackcolorOnAllComponents = true;
    }

    private void WireEvents()
    {
        // ej: chkMostrar.CheckedChanged += (s,e) => txtPassword.Password = !chkMostrar.Checked;
        // this.AcceptButton = btnIngresar;
        // this.CancelButton = btnCancelar;
    }
    public class RoundedMaterialCard : MaterialCard
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = 40; // Ajustá el radio para más o menos redondeo
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }

}
