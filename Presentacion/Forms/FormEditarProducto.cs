using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PatitaSystem.Presentacion.Forms
{


    public partial class FormEditarProducto : MaterialForm
    {
        private MaterialListView listViewModificar;
        public FormEditarProducto(ListView ListViewOriginal)
        {
            InitializeComponent();
            // Configuración de MaterialSkin
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK; // o LIGTH
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700, Primary.Blue200,
                Accent.LightBlue200, TextShade.WHITE
            );

            listViewModificar = new MaterialListView
            {
                Dock = DockStyle.Fill,
                FullRowSelect = true,
                View = View.Details
            };

            // Copiar las columnas del ListView original
            foreach (ColumnHeader col in ListViewOriginal.Columns)
            {
                listViewModificar.Columns.Add(col.Text, col.Width);
            }

            // Copiar los items del ListView original
            foreach (ListViewItem item in ListViewOriginal.Items)
            {
                listViewModificar.Items.Add((ListViewItem)item.Clone());
            }

            this.Controls.Add(listViewModificar);

            // Botón de eliminar dentro del formulario
            var btnEliminar = new MaterialButton
            {
                Text = "Eliminar Seleccionado",
                Dock = DockStyle.Bottom
            };
            btnEliminar.Click += ELIMINARP_Click;
            this.Controls.Add(btnEliminar);

            // Podés precargar datos en los TextBox si querés
            //txtUsuario.Text = usuario;
            //txtEmail.Text = email;
            //txtTelefono.Text = telefono;
        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            // Podés inicializar datos acá si querés
            // Ejemplo:
            // txtUsuario.Text = Usuario;
            // txtEmail.Text = Email;
            // txtTelefono.Text = Telefono;
        }

        private void FormEditarUsuario_Load_1(object sender, EventArgs e)
        {

        }

        private void ELIMINARP_Click(object sender, EventArgs e)
        {
            // Aquí va el código que quieres que se ejecute al hacer clic
            MessageBox.Show("Botón eliminar clickeado");
        }
    }
}
