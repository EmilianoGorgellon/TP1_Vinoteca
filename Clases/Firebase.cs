using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TP1_UTN.Clases
{
    public static class Firebase
    {
        private static readonly IFirebaseConfig Config = new FirebaseConfig
        {
            AuthSecret = "snuLFpLpLUZwfO9H0hNjiTxLTkLnAA44fIMHKIz8",
            BasePath = "https://tp1utn-default-rtdb.firebaseio.com/"
        };

        public static readonly FirebaseClient Client;

        static Firebase()
        {
            Client = new FirebaseClient(Config);
        }
        /// <summary>
        /// Obtengo todos los elementos segun path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Lista de clientes</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<FirebaseResponse> GetAsync(string path)
        {
            try
            {
                return await Client.GetAsync(path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Actualizo usuario cliente 
        /// </summary>
        /// <param name="id">Recibo id del cliente para actualizar</param>
        /// <param name="client">Recibo todos los elementos del Cliente</param>
        /// <returns>Respuesta del firebase</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<FirebaseResponse> UpdateClient(string id, Cliente client)
        {
            try 
            {
                return await Client.UpdateAsync("users/" + id, client);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Actualizo producto
        /// </summary>
        /// <param name="id">Recibo ID del producto</param>
        /// <param name="product">Recibo todos los elementos del producto</param>
        /// <returns>Respuesta del firebase</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<FirebaseResponse> UpdateProduct(string id, Producto product)
        {
            try
            {
                return await Client.UpdateAsync("productos/" + id, product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Creo cliente y genero nuevo ID
        /// </summary>
        /// <param name="client">Recibo todos los parametros necesarios para crear el cliente</param>
        /// <returns>Respuesta del firebase</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<FirebaseResponse> SetAsyncClient(Cliente client)
        {
            try
            {
                string IdGenerado = Guid.NewGuid().ToString("N");
                return await Client.SetAsync("users/" + IdGenerado, client);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
        /// <summary>
        /// Creo producto y genero nuevo ID
        /// </summary>
        /// <param name="product">Recibo todos los parametros necesarios para crear el producto</param>
        /// <returns>Respuesta del firebase</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<FirebaseResponse> SetAsyncProduct(Producto product)
        {
            try
            {
                string IdGenerado = Guid.NewGuid().ToString("N");
                return await Client.SetAsync("productos/" + IdGenerado, product);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Elimino un elemento segun Path
        /// </summary>
        /// <param name="pathId">Recibo el path y el ID del elemento seleccionado</param>
        /// <returns>Respuesta del firebase</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<FirebaseResponse> deleteAsync(string pathId)
        {
            try
            {
                return await Client.DeleteAsync(pathId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
