using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Clases;

namespace TP1_UTN.Clases
{
    public class Cliente : Persona
    {
        private int _puntos;

        public int Puntos { get { return _puntos; } set { _puntos = value; } }

        public Cliente(string user, string pw, int puntos)
        {
            Usuario = user;
            Password = pw;
            Puntos = puntos;
            IsAdmin = false;
        }


        public async static Task<dynamic> Login(string user, string pw)
        {
            FirebaseResponse response = await Firebase.GetElement("users");
            Dictionary<string, Cliente> lista = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(response.Body);

            foreach (KeyValuePair<string, Cliente> elemento in lista)
            {
                if (elemento.Value.Usuario == user && elemento.Value.Password == pw)
                {
                    var dataJson = new
                    {
                        isAdmin = elemento.Value.IsAdmin == true ? true : false,
                        userId = elemento.Key
                    };
                    return dataJson;
                }
            }
            throw new Exception("Error, no existe usuario y/o contraseña con esos valores");
        }

        public async static Task<bool> UserIsAdmin(string userId)
        {
            FirebaseResponse response = await Firebase.GetElement("users");
            Dictionary<string, Cliente> lista = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(response.Body);

            foreach (KeyValuePair<string, Cliente> elemento in lista)
            {
                if (userId == elemento.Key && elemento.Value.IsAdmin)
                {
                    return true;
                }
            }
            return false;
        }

        public async static Task<string> CreateUser(string user, string pw, int puntos)
        {
            try
            {
                var data = new
                {
                    Usuario = user,
                    Password = pw,
                    Puntos = puntos,
                    IsAdmin = false
                };

                FirebaseResponse response = await Firebase.SetElement("users/", data);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return "Se creo satisfactoriamente el usuario";
                }
                else
                {
                    return "Error no se pudo crear el usuario";
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            
        }
    }
}
