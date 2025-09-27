using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


            // Conectar selector con tabcontrol
            TABS_Carrito.BaseTabControl = TABC_Carrito;

            // Configuración de MaterialSkin
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Teal700, Primary.Teal900, Primary.Teal500,
                Accent.Green200, TextShade.WHITE
            );

            // Definir columnas
            LIS_ProductoC.Columns.Add("ID", 50);
            LIS_ProductoC.Columns.Add("Producto", 150);
            LIS_ProductoC.Columns.Add("Precio Unitario", 175);
            LIS_ProductoC.Columns.Add("Stock", 70);
            LIS_ProductoC.Columns.Add("Cantidad", 100);

            //Columnas de carrito
            LIS_Carrito.Columns.Add("ID", 50);
            LIS_Carrito.Columns.Add("Producto", 150);
            LIS_Carrito.Columns.Add("Cantidad", 100);
            LIS_Carrito.Columns.Add("Precio Unitario", 175);
            LIS_Carrito.Columns.Add("Sub total", 70);

            //Columnas de compras

            LIS_Compra.Columns.Add("Producto", 150);
            LIS_Compra.Columns.Add("Cantidad", 100);
            LIS_Compra.Columns.Add("Precio Unitario", 175);
            LIS_Compra.Columns.Add("Sub total", 70);





        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
