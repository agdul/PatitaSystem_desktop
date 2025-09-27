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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PatitaSystem.Presentacion.Forms
{

    public partial class FormVendedor : MaterialForm
    {

        public FormVendedor()
        {
            InitializeComponent();


            // Configuración de MaterialSkin
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK; // o LIGTH
            skinManager.ColorScheme = new ColorScheme(
               Primary.Teal700, Primary.Teal900, Primary.Teal500,
                Accent.Green200, TextShade.WHITE
            );

            // Conectar el Drawer con el TabControl
            drawerVendedor.BaseTabControl = materialTabVendedor;

            var listViewVendedor = new MaterialSkin.Controls.MaterialListView
            {
                Dock = DockStyle.Fill,
                FullRowSelect = true,
                View = View.Details
            };

            //listViewVendedor1.View = View.Details;
            //listViewVendedor1.FullRowSelect = true;
            //listViewVendedor1.GridLines = true;

            // Definir columnas
            LIS_Vendedor.Columns.Add("ID", 50);
            LIS_Vendedor.Columns.Add("Nombre Producto", 150);
            LIS_Vendedor.Columns.Add("Stock", 175);
            LIS_Vendedor.Columns.Add("Descripción", 170);

            // Agregar usuarios de ejemplo
            LIS_Vendedor.Items.Add(new ListViewItem(new[] { "1", "Alimento", "25", "" }));
            LIS_Vendedor.Items.Add(new ListViewItem(new[] { "2", "Sogas", "15", "" }));

            //Definir columnas
            listViewPelu.Columns.Add("ID", 50);
            listViewPelu.Columns.Add("Nombre de la mascota", 180);
            listViewPelu.Columns.Add("Fecha de turno", 180);

            //Agregar ejemplos
            listViewPelu.Items.Add(new ListViewItem(new[] { "1", "Daila", "20/09/2025" }));

            // Agregar al formulario
            //materialTabVendedor.TabPages[0].Controls.Add(listViewVendedor);


        }

        private MaterialSkin.Controls.MaterialListView listView;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {

        }

        private void drawerVendedor_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //private void materialButton1_Click(object sender, EventArgs e)
        //{
        //    if (LIS_Vendedor.SelectedItems.Count > 0)
        //    {
        //        var item = LIS_Vendedor.SelectedItems[0];

        //        string id = item.SubItems[0].Text;
        //        string producto = item.SubItems[1].Text;
        //        string descripcion = item.SubItems[2].Text;

        //         Abrís un formulario de edición con esos datos
        //        FormRegistrarProducto frm = new FormRegistrarProducto();
        //        if (frm.ShowDialog() == DialogResult.OK)
        //        {
        //             Si el usuario guardó cambios, actualizamos la fila
        //            item.SubItems[1].Text = frm.producto;
        //            item.SubItems[2].Text = frm.Stock;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Seleccioná un producto primero.");
        //    }


        //}

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
