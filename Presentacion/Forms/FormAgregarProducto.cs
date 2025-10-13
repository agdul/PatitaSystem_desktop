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
    public partial class FormAgregarProducto : MaterialForm
    {
        public FormAgregarProducto()
        {
            InitializeComponent();

            // Configuración de MaterialSkin
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Teal700, Primary.Teal900, Primary.Teal500,
                Accent.Green200, TextShade.WHITE
            );

            TXTB_NombreProducto.Hint = "Ingrese el nombre del producto";
            TXT_Stock.Hint = "Ingrese la cantidad en stock";
            TXT_PrecioDeCompra.Hint = "Ingrese el precio de compra";
            TXT_Descripcion.Hint = "Ingrese una descripción del producto";
            CBX_Estado.Hint = "Seleccione el estado del producto";
            CBX_Categoria.Hint = "Seleccione la categoría del producto";
            CBX_Linea.Hint = "Seleccione la línea del producto";


        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {

        }

       
    }
}
