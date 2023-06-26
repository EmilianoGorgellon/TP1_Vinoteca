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
        private string _idUsername;
        private float totalPrecio = 0;
        public string IdUsername { get { return _idUsername; } set { _idUsername = value; } }


        /// <summary>
        /// Agrego el id del producto de la lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string add_producto(string id)
        {
            listaProductosId.Add(id);
            return "Se agrego un nuevo producto";
        }
        /// <summary>
        /// Remuevo el id del producto de la lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string remove_product(string id)
        {
            if (listaProductosId.Remove(id))
            {
                this.Close();
                return "Se elimino producto";
            }
            else
            {
                return "No se elimino correctamente el producto";
            }
        }
        /// <summary>
        /// Cargo el carrito con los productos que agrego al carrito el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Carrito_Load(object sender, EventArgs e)
        {
            FirebaseResponse response = await Firebase.GetElement("productos");
            Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);
            
            foreach (string id in listaProductosId)
            {
                foreach (KeyValuePair<string, Producto> elemento in lista)
                {
                    if (elemento.Key == id)
                    {
                        CarritoBox carritoExistente = flpanel_carrito.Controls.OfType<CarritoBox>().FirstOrDefault(item => item.Id == elemento.Key);
                        if (carritoExistente != null)
                        {
                            carritoExistente.Cantidad = carritoExistente.Cantidad + 1;
                            carritoExistente.Llenar_carrito();
                            totalPrecio += carritoExistente.Precio;
                        }
                        else
                        {
                            CarritoBox carritoNuevo = new CarritoBox();
                            carritoNuevo.Nombre = elemento.Value.Nombre;
                            carritoNuevo.Precio = elemento.Value.Precio;
                            carritoNuevo.LinkImage = elemento.Value.LinkImage;
                            carritoNuevo.Cantidad = 1;
                            carritoNuevo.Id = elemento.Key;
                            carritoNuevo.Llenar_carrito();
                            totalPrecio += elemento.Value.Precio;
                            carritoNuevo.IdUsername = IdUsername;
                            flpanel_carrito.Controls.Add(carritoNuevo);
                        }

                    }
                }
            }
            btn_comprar.Text = $"${totalPrecio} - Comprar";
        }
        /// <summary>
        /// Compro los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_comprar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(await Producto.ComprarProductos(listaProductosId, _idUsername, totalPrecio));
                listaProductosId.Clear();
                totalPrecio = 0;
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
