using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TP1_UTN.Clases
{
    public class Producto
    {
        public static event Action<string> InformarProductoAgregado;
        private string _nombre;
        private float _precio;
        private int _stock;
        private string _fecha;
        
        public string Fecha { get { return _fecha;  } set { _fecha = value; } }
        public string Nombre { get {  return _nombre; } set {  _nombre = value; } }
        public float Precio { get {  return _precio; } set {  _precio = value; } }
        public int Stock { get {  return _stock; } set {  _stock = value; } }
        public string LinkImage { get ; set; }
        public Producto(string nombre, float precio, int stock, string linkImage, string fecha) 
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            LinkImage = linkImage;
            Fecha = fecha;
        }
        /// <summary>
        /// Reduce stock del producto en 1
        /// </summary>
        /// <param name="id">Id del producto</param>
        /// <exception cref="Exception"></exception>
        public async static void ReducirStockProducto(string id)
        {
            try
            {
                FirebaseResponse response = await Firebase.GetElement("productos");
                Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

                foreach (KeyValuePair<string, Producto> elemento in lista)
                {
                    if (elemento.Key == id)
                    {
                        DateTime fechaActual = DateTime.Now;
                        string fechaFormateada = fechaActual.ToString("dd/MM/yyyy HH:mm");
                        Producto product = new Producto(elemento.Value.Nombre, elemento.Value.Precio, elemento.Value.Stock - 1, elemento.Value.LinkImage, fechaFormateada);
                        FirebaseResponse responseUpdate = await Firebase.UpdateElement($"productos/{id}", product);
                        if (responseUpdate.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            return;
                        }
                        else
                        {
                            throw new Exception($"Error: ${responseUpdate}");
                        }

                    }
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Actualizo todos los valores del producto menos el Id
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="linkImage"></param>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public async static void ActualizarProducto(string nombre, float precio, int stock, string linkImage, string id)
        {
            try
            {
                FirebaseResponse response = await Firebase.GetElement("productos");
                Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);
                foreach (KeyValuePair<string, Producto> elemento in lista)
                {
                    if (elemento.Key == id)
                    {
                        DateTime fechaActual = DateTime.Now;
                        string fechaFormateada = fechaActual.ToString("dd/MM/yyyy HH:mm");
                        Producto product = new Producto(nombre, precio, stock, linkImage, fechaFormateada);
                        FirebaseResponse responseUpdate = await Firebase.UpdateElement($"productos/{id}", product);
                        if (responseUpdate.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            return;
                        }
                        else
                        {
                            throw new Exception($"Error: ${responseUpdate}");
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async static Task<string> ComprarProductos(List<string> listaProductosId, string _idUsername, float totalPrecio)
        {
            try
            {
                FirebaseResponse response = await Firebase.GetElement("productos");
                Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

                foreach (string id in listaProductosId)
                {
                    ReducirStockProducto(id);
                }

                FirebaseResponse responseClient = await Firebase.GetElement("users");
                Dictionary<string, Cliente> listaClientes = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(responseClient.Body);

                foreach (KeyValuePair<string, Cliente> elemento in listaClientes)
                {
                    if (_idUsername == elemento.Key)
                    {
                        int puntos = (int)totalPrecio / 99;
                        Cliente client = new Cliente(elemento.Value.Usuario, elemento.Value.Password, elemento.Value.Puntos + puntos);
                        FirebaseResponse responseUsuarioActualizado = await Firebase.UpdateElement($"users/{_idUsername}", client);
                        if (responseUsuarioActualizado.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            Logs.SetLogs(_idUsername, $"El usuario: {elemento.Value.Usuario} hizo una compra de {totalPrecio}");
                            return $"Felicitaciones, se hizo correctamente la compra y se le agrego {puntos} a {elemento.Value.Usuario}!!";
                        }
                    }
                }
                throw new Exception("Error en la compra");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public async static Task<bool> AgregarProducto(string nombre, float precio, int stock, string linkImage)
        {
            try
            {
                DateTime fechaActual = DateTime.Now;
                string fechaFormateada = fechaActual.ToString("dd/MM/yyyy HH:mm");

                var data = new
                {
                    Fecha = fechaFormateada,
                    LinkImage = linkImage,
                    Nombre = nombre, 
                    Precio = precio,
                    Stock = stock
                };

                FirebaseResponse response = await Firebase.SetElement("productos/", data);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    InformarProductoAgregado?.Invoke("Se creo producto nuevo");
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch
            {
                return false;
            }

        }

        
    }
}
