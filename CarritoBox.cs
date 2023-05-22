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
    public partial class CarritoBox : UserControl
    {
        public CarritoBox()
        {
            InitializeComponent();
        }
        Carrito carrit = new Carrito();
        private string _nombre;
        private float _precio;
        private string _linkImage;
        private string _id;
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public float Precio { get { return _precio; } set { _precio = value; } }
        public string LinkImage { get { return _linkImage; } set { _linkImage = value; } }
        public string Id { get { return _id; } set { _id = value; } }

        public void llenar_carrito()
        {
            lbl_title.Text = _nombre;
            lbl_price.Text = _precio.ToString();
            pbox_image.Image = Image.FromFile(_linkImage);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carrit.remove_product(_id));
        }
    }
}
