using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_UTN.Clases;

namespace TP1_UTN
{
    public partial class RegistrarProducto : Form
    {
        public RegistrarProducto()
        {
            InitializeComponent();
        }

        private static string linkImage;

        private async void btn_add_product_Click(object sender, EventArgs e)
        {
            string nombre = txb_name.Text;
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(linkImage) && float.TryParse(numeric_price.Text, out float precio) && int.TryParse(numeric_stock.Text, out int stock))
            {
                MessageBox.Show(await Producto.AgregarProducto(nombre, precio, stock, linkImage));
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            this.Close();
        }

        private void btn_select_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSeleccionada = new OpenFileDialog();
            imageSeleccionada.Filter = "|*.png;";

            if (imageSeleccionada.ShowDialog() == DialogResult.OK)
            {
                pbox_image.Image = Image.FromFile(imageSeleccionada.FileName);
                linkImage = imageSeleccionada.FileName;
            }

        }
    }
}
