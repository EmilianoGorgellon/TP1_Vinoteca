using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_UTN.Clases;

namespace TP1_UTN
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        public bool _isAdmin;
        private string _idUsername;

        public bool IsAdmin { get { return _isAdmin; } set { _isAdmin = value; } }
        public string IdUsername { get { return _idUsername; } set { _idUsername = value; } }
        private async void Productos_Load(object sender, EventArgs e)
        {
            FirebaseResponse response = await Firebase.GetElement("productos");
            Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

            foreach (KeyValuePair<string, Producto> elemento in lista)
            {
                ProductoBox productBox = new ProductoBox();
                productBox.Nombre = elemento.Value.Nombre;
                productBox.Precio = elemento.Value.Precio;
                productBox.Stock = elemento.Value.Stock;
                productBox.LinkImage = elemento.Value.LinkImage;
                productBox.Fecha = elemento.Value.Fecha;
                productBox.Id = elemento.Key;
                productBox.IsAdmin = _isAdmin;
                productBox.IdUsername = _idUsername;
                productBox.llenar_Producto();
                flpanel_productos.Controls.Add(productBox);
            }
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            RegistrarProducto register = new RegistrarProducto();
            register.Show();
        }

    }
}
