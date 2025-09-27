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
    public partial class FormRegistrarMascotas : MaterialForm
    {
        public FormRegistrarMascotas()
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

            TXTB_Nombre.Hint= "Ingrese el nombre de la mascota";
            CBX_Especie.Hint= "Ingrese la especie";
            TXT_Edad.Hint= "Ingrese la edad";
            TXTB_Dueño.Hint= "Ingrese el nombre del dueño";
            TXTB_Raza.Hint="Ingrese la raza";
            TXTB_EspecieAnimal.Hint="Ingrese la especie del animal";

        }

        private void FormRegistrarMascotas_Load(object sender, EventArgs e)
        {

        }
    }
}
