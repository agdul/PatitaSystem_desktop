using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace PatitaSystem.Presentacion.Controles
{
    /// <summary>
    /// MaterialCard sin relleno (transparente):
    /// - No pinta su propio fondo.
    /// - Rellena con el BackColor del padre (sin dibujar los hijos del padre).
    /// - Podés mantener un borde fino opcional.
    /// </summary>
    public class TransparentCard : MaterialCard
    {
        public TransparentCard()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
        }

        /// <summary>
        /// Pinta SOLO el fondo del padre (color liso), evitando dibujar los hijos del padre.
        /// Así no se “duplica” ningún control detrás del card.
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Parent != null)
            {
                // Relleno plano con el color del contenedor
                using var b = new SolidBrush(Parent.BackColor);
                e.Graphics.FillRectangle(b, ClientRectangle);

                // Si quisieras soportar BackgroundImage del padre,
                // deberías dibujar la porción correspondiente aquí respetando el Layout.
                return;
            }

            base.OnPaintBackground(e);
        }

        /// <summary>
        /// No dibuja el relleno del card. Si querés, dejá un borde muy sutil.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Borde opcional:
            // using var pen = new Pen(Color.FromArgb(60, Color.Black), 1);
            // e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
        }
    }
}
