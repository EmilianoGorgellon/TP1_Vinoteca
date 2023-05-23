using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_UTN.Clases
{
    public class Producto
    {
        private string _nombre;
        private float _precio;
        private int _stock;
        private string _linkImage;
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
                FirebaseResponse response = await Firebase.GetAsync("productos");
                Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

                foreach (KeyValuePair<string, Producto> elemento in lista)
                {
                    if (elemento.Key == id)
                    {
                        DateTime fechaActual = DateTime.Now;
                        string fechaFormateada = fechaActual.ToString("dd/MM/yyyy HH:mm");
                        Producto product = new Producto(elemento.Value.Nombre, elemento.Value.Precio, elemento.Value.Stock - 1, elemento.Value.LinkImage, fechaFormateada);
                        FirebaseResponse responseUpdate = await Firebase.UpdateProduct(id, product);
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
                FirebaseResponse response = await Firebase.GetAsync("productos");
                Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);
                foreach (KeyValuePair<string, Producto> elemento in lista)
                {
                    if (elemento.Key == id)
                    {
                        DateTime fechaActual = DateTime.Now;
                        string fechaFormateada = fechaActual.ToString("dd/MM/yyyy HH:mm");
                        Producto product = new Producto(nombre, precio, stock, linkImage, fechaFormateada);
                        FirebaseResponse responseUpdate = await Firebase.UpdateProduct(id, product);
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
    }
}
