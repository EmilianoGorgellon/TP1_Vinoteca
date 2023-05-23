using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_UTN.Clases;

namespace TP1_UTN
{
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }
        private static List<string> listaProductosId = new List<string>();

        public string add_producto(string id)
        {
            listaProductosId.Add(id);
            return "Se agrego un nuevo producto";
        }

        public string remove_product(string id)
        {
            if (listaProductosId.Remove(id))
            {
                return "Se elimino producto";
            }
            else
            {
                return "No se elimino correctamente el producto";
            }
        }

        private async void Carrito_Load(object sender, EventArgs e)
        {
            FirebaseResponse response = await Firebase.GetAsync("productos");
            Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

            foreach (string id in listaProductosId)
            {
                foreach (KeyValuePair<string, Producto> elemento in lista)
                {
                    if (elemento.Key == id)
                    {
                        CarritoBox carritBox = new CarritoBox();
                        carritBox.Nombre = elemento.Value.Nombre;
                        carritBox.Precio = elemento.Value.Precio;
                        carritBox.LinkImage = elemento.Value.LinkImage;
                        carritBox.Id = elemento.Key;
                        carritBox.llenar_carrito();
                        flpanel_carrito.Controls.Add(carritBox);
                    }
                }
            }
        }

        private async void btn_comprar_Click(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse response = await Firebase.GetAsync("productos");
                Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

                foreach (string id in listaProductosId)
                {
                    Producto.ReducirStockProducto(id);
                }
                MessageBox.Show("Felicitaciones!! Se hizo correctamente la compra");

                listaProductosId.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
