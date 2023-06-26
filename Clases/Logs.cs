using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace TP1_UTN.Clases
{
    public class Logs
    {
        public string IdUser { get; set; }
        public string Action { get; set; }
        public string FechaActual { get; set; }
        public async static Task<bool> SetLogs(string idUser, string action)
        {
            try
            {
                if (!string.IsNullOrEmpty(idUser) && !string.IsNullOrEmpty(action))
                {
                    DateTime fechaActual = DateTime.Now;
                    string fechaFormateada = fechaActual.ToString("dd/MM/yyyy HH:mm");
                    var data = new
                    {
                        idUser = idUser,
                        action = action,
                        fechaActual = fechaFormateada
                    };
                    FirebaseResponse response = await Firebase.SetElement($"logs/", data);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return true;
                    }
                }
                return false;
            } catch (Exception ex)
            {
                return false;
            }
        }


        public async static void DeleteLogs(string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    FirebaseResponse response = await Firebase.DeleteElement(path);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return;
                    }
                    else
                    {
                        throw new Exception(response.StatusCode.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<string> GetUser(string userId)
        {
            try
            {
                if (!string.IsNullOrEmpty(userId))
                {
                    FirebaseResponse response = await Firebase.GetElement("users");

                    Dictionary<string, Cliente> lista = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(response.Body);

                    foreach (KeyValuePair<string, Cliente> elemento in lista)
                    {
                        if (userId == elemento.Key)
                        {
                            return $"{elemento.Value.Usuario}";
                        }
                    }
                }
                throw new Exception("Error, no se encontro el user id");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
