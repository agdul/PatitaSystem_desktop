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
    public partial class FormMascotas : MaterialForm
    {
        public FormMascotas()
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


        // Definir columnas
            LIS_mascotas.Columns.Add("ID", 50);
            LIS_mascotas.Columns.Add("Nombre", 90);
            LIS_mascotas.Columns.Add("Especie", 90);
            LIS_mascotas.Columns.Add("Edad", 80);
            LIS_mascotas.Columns.Add("Dueño", 80);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
