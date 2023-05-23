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
            string name = txb_name.Text;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(linkImage) && float.TryParse(numeric_price.Text, out float precio) && int.TryParse(numeric_stock.Text, out int stock))
            {
                DateTime fechaActual = DateTime.Now;
                string fechaFormateada = fechaActual.ToString("dd/MM/yyyy HH:mm");

                Producto product = new Producto(name, precio, stock, linkImage, fechaFormateada);

                FirebaseResponse response = await Firebase.SetAsyncProduct(product);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se creo satisfactoriamente un nuevo producto");
                }
                else
                {
                    MessageBox.Show($"Error: ${response}");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
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
