using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static async Task<FirebaseResponse> GetAsync(string path)
        {
            return await Client.GetAsync(path);
        }

        public static async Task<FirebaseResponse> SetAsyncClient(Cliente client)
        {
            string IdGenerado = Guid.NewGuid().ToString("N");
            return await Client.SetAsync("users/"+IdGenerado, client);
        }

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

        public static async Task<FirebaseResponse> deleteAsync(string pathId)
        {
            return await Client.DeleteAsync(pathId);
        }
    }
}
