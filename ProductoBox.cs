using FireSharp.Response;
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
    public partial class ProductoBox : UserControl
    {
        public ProductoBox()
        {
            InitializeComponent();
        }

        private string _nombre;
        private float _precio;
        private int _stock;
        private string _linkImage;
        private string _fecha;
        private string _id;

        private bool _isAdmin;

        Carrito carrit = new Carrito();
        public string Fecha { get { return _fecha; } set { _fecha = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public float Precio { get { return _precio; } set { _precio = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        public string LinkImage { get { return _linkImage; } set { _linkImage = value; } }
        public string Id { get { return _id; } set { _id = value; } }
        public bool IsAdmin { get { return _isAdmin; } set { _isAdmin = value; } }
        public string IdUsername { get ; set ; }


        public void llenar_Producto()
        {
            lbl_fecha.Text = _fecha;
            lbl_title.Text = _nombre;
            lbl_stock.Text = $"Cantidad: {_stock}";
            lbl_price.Text = $"${_precio}";
            pbox_image.Image = Image.FromFile(_linkImage);
        }

        private void btn_add_carrito_Click(object sender, EventArgs e)
        {
            if (_stock > 0)
            {
                Logs.SetLogs(IdUsername, $"Agrego el producto {Nombre}");
                MessageBox.Show(carrit.add_producto(_id));
            }
            else
            {
                MessageBox.Show("No hay mas stock de este producto");
            }
        }

        private async void btn_edit_product_Click(object sender, EventArgs e)
        {
            try
            {
                EditProduct editProduct = new EditProduct();
                editProduct.Id = _id;
                editProduct.LinkImage = _linkImage;
                editProduct.cargarFormulario(_nombre, _precio, _stock, _linkImage);
                editProduct.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductoBox_Load(object sender, EventArgs e)
        {
            _ = _isAdmin ? btn_edit_product.Visible = true : btn_edit_product.Visible = false;
        }
    }
}
