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
        public static readonly IFirebaseConfig Config = new FirebaseConfig
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
        public static async Task<FirebaseResponse> GetElement(string path)
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
        /// Actualizo item en la base de datos
        /// </summary>
        /// <typeparam name="T">Dato generico para que sea reutilizable</typeparam>
        /// <param name="path">Path donde queremos actualizar</param>
        /// <param name="item">Item con los cambios dados</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static async Task<FirebaseResponse> UpdateElement<T>(string path, T item)
        {
            try 
            {
                return await Client.UpdateAsync(path, item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Creo un item en un path determinado en la base de datos
        /// </summary>
        /// <typeparam name="T">Dato generico para que sea reutilizable</typeparam>
        /// <param name="path">Path donde creare el nuevo elemento</param>
        /// <param name="item">Item que se va a crear en la base de datos</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static async Task<FirebaseResponse> SetElement<T>(string path, T item)
        {
            try
            {
                string IdGenerado = Guid.NewGuid().ToString("N");
                return await Client.SetAsync(path + IdGenerado, item);
            }
            catch (Exception ex)
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
        public static async Task<FirebaseResponse> DeleteElement(string pathId)
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
