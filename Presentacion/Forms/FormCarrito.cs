// Archivo: Presentacion/Forms/FormCarrito.cs
using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PatitaSystem.Presentacion.Forms
{
    public partial class FormCarrito : MaterialForm
    {
        public FormCarrito()
        {
            InitializeComponent();

            // Cableado robusto del selector (por si el Designer reordena props)
            WireTabSelectorSafely();

            // MaterialSkin
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Teal700, Primary.Teal900, Primary.Teal500,
                Accent.Green200, TextShade.WHITE
            );

            // Config ListViews (idempotente: no duplica columnas si reabrís el form)
            ConfigListViewProductos();
            ConfigListViewCarrito();
            ConfigListViewCompras();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Reafirmar el cableado cuando el control ya está materializado
            WireTabSelectorSafely();
        }

        /// <summary>
        /// Conecta el MaterialTabSelector al MaterialTabControl y recién entonces
        /// aplica opciones como CharacterCasing. Idempotente y a prueba de Designer.
        /// </summary>
        private void WireTabSelectorSafely()
        {
            // Usa tus nombres reales del Designer:
            // TABS_Carrito  -> MaterialTabSelector
            // TABC_Carrito  -> MaterialTabControl
            if (TABS_Carrito != null && TABC_Carrito != null)
            {
                if (TABS_Carrito.BaseTabControl != TABC_Carrito)
                    TABS_Carrito.BaseTabControl = TABC_Carrito;

                // Ahora es seguro setear el casing (si lo querés distinto, cambiá aquí)
                TABS_Carrito.CharacterCasing = MaterialTabSelector.CustomCharacterCasing.Normal;
            }
        }

        private void ConfigListViewProductos()
        {
            if (LIS_ProductoC.View != View.Details) LIS_ProductoC.View = View.Details;
            LIS_ProductoC.FullRowSelect = true;
            LIS_ProductoC.GridLines = true;
            if (LIS_ProductoC.Columns.Count == 0)
            {
                LIS_ProductoC.Columns.Add("ID", 60);
                LIS_ProductoC.Columns.Add("Producto", 180);
                LIS_ProductoC.Columns.Add("Precio Unitario", 120, HorizontalAlignment.Right);
                LIS_ProductoC.Columns.Add("Stock", 80, HorizontalAlignment.Right);
                LIS_ProductoC.Columns.Add("Cantidad", 90, HorizontalAlignment.Right);
            }
        }

        private void ConfigListViewCarrito()
        {
            if (LIS_Carrito.View != View.Details) LIS_Carrito.View = View.Details;
            LIS_Carrito.FullRowSelect = true;
            LIS_Carrito.GridLines = true;
            if (LIS_Carrito.Columns.Count == 0)
            {
                LIS_Carrito.Columns.Add("ID", 60);
                LIS_Carrito.Columns.Add("Producto", 180);
                LIS_Carrito.Columns.Add("Cantidad", 90, HorizontalAlignment.Right);
                LIS_Carrito.Columns.Add("Precio Unitario", 120, HorizontalAlignment.Right);
                LIS_Carrito.Columns.Add("Sub total", 120, HorizontalAlignment.Right);
            }
        }

        private void ConfigListViewCompras()
        {
            if (LIS_Compra.View != View.Details) LIS_Compra.View = View.Details;
            LIS_Compra.FullRowSelect = true;
            LIS_Compra.GridLines = true;
            if (LIS_Compra.Columns.Count == 0)
            {
                LIS_Compra.Columns.Add("Producto", 180);
                LIS_Compra.Columns.Add("Cantidad", 90, HorizontalAlignment.Right);
                LIS_Compra.Columns.Add("Precio Unitario", 120, HorizontalAlignment.Right);
                LIS_Compra.Columns.Add("Sub total", 120, HorizontalAlignment.Right);
            }
        }



        private void AutoSizeTabSelectorToTabs()
        {
            if (TABS_Carrito == null || TABC_Carrito == null) return;

            // padding por item: MaterialSkin deja ~24px por lado
            const int sidePaddingPerItem = 24 * 2; // 48 px por tab
            const int interItemGap = 16;           // espacio entre tabs

            int total = 0;
            foreach (TabPage tp in TABC_Carrito.TabPages)
            {
                // medir texto con la misma fuente del selector
                var sz = TextRenderer.MeasureText(tp.Text ?? string.Empty, TABS_Carrito.Font);
                total += sz.Width + sidePaddingPerItem + interItemGap;
            }
            if (total > 0) total -= interItemGap; // quitar el último gap

            // limitar al ancho del form y centrar
            int desired = Math.Min(ClientSize.Width, total);
            TABS_Carrito.Width = desired;
            TABS_Carrito.Left = (ClientSize.Width - desired) / 2;
        }

        // Eventos autogenerados
        private void FormCarrito_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }


    }
}
