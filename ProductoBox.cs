using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        Carrito carrit = new Carrito();
        public string Fecha { get { return _fecha; } set { _fecha = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public float Precio { get { return _precio; } set { _precio = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        public string LinkImage { get { return _linkImage; } set { _linkImage = value; } }
        public string Id { get { return _id; } set { _id = value; } }
        public void llenar_Producto()
        {
            lbl_fecha.Text = _fecha;
            lbl_title.Text = _nombre;
            lbl_price.Text = _precio.ToString();
            pbox_image.Image = Image.FromFile(_linkImage);
        }

        private void btn_add_carrito_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carrit.add_producto(_id));
        }
    }
}
