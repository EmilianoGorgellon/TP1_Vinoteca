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
    public partial class CarritoBox : UserControl
    {
        public CarritoBox()
        {
            InitializeComponent();
        }

        private string _nombre;
        private float _precio;
        private string _linkImage;
        private string _id;
        private int _cantidad;
        Carrito carrit = new Carrito();

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public float Precio { get { return _precio; } set { _precio = value; } }
        public string LinkImage { get { return _linkImage; } set { _linkImage = value; } }
        public string Id { get { return _id; } set { _id = value; } }
        public int Cantidad { get { return _cantidad;  } set { _cantidad = value; } }
        public string IdUsername { get; set; } 
        public void Llenar_carrito()
        {
            lbl_title.Text = _nombre;
            lbl_price.Text = $"${_precio * _cantidad}";
            lbl_cantidad.Text = $"{_cantidad}";
            pbox_image.Image = Image.FromFile(_linkImage);
        }

        /// <summary>
        /// Elimino el producto del carrito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Logs.SetLogs(IdUsername, $"Elimino el producto {Nombre}");
            MessageBox.Show(carrit.remove_product(_id));
        }
    }
}
