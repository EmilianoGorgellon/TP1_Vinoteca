using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }
        private string _id;
        private string _linkImage;

        public string LinkImage { get { return _linkImage; } set { _linkImage = value; } }
        public string Id { get { return _id; } set { _id = value; } }

        public void cargarFormulario(string nombre, float precio, int stock, string linkImage)
        {
            txb_name.Text = nombre;
            numeric_price.Text = precio.ToString();
            numeric_stock.Text = stock.ToString();
            pbox_image.Image = Image.FromFile(linkImage);
        }


        private async void btn_update_product_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txb_name.Text) && float.TryParse(numeric_price.Text, out float precio) && int.TryParse(numeric_stock.Text, out int stock))
                {
                    Producto.ActualizarProducto(txb_name.Text, precio, stock, _linkImage, _id);
                    MessageBox.Show("Se actualizo el producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btn_select_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSeleccionada = new OpenFileDialog();
            imageSeleccionada.Filter = "|*.jpg; *.png; *.jpeg";

            if (imageSeleccionada.ShowDialog() == DialogResult.OK)
            {
                pbox_image.Image = Image.FromFile(imageSeleccionada.FileName);
                _linkImage = imageSeleccionada.FileName;
            }
        }
    }
}
