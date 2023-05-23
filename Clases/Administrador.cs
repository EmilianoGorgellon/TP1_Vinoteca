using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Clases;

namespace TP1_UTN.Clases
{
    public class Administrador : Persona
    {
        private int _dni;
        public int Dni { get { return _dni; } set { _dni = value; } }
        public Administrador(int dni, string user, string pw) 
        {
            Usuario = user;
            Password = pw;
            Dni = dni;
            IsAdmin = true;
        }

        public Administrador(): this(0,"","") { }
        /// <summary>
        /// Elimino cliente de la lista
        /// </summary>
        /// <param name="id">Recibo ID del cliente seleccionado</param>
        /// <param name="rol">Recibo Rol del cliente</param>
        /// <returns>Devuelvo string con mensaje de exito o fallo</returns>
        /// <exception cref="Exception"></exception>
        public async Task <string> deleteClientUser(string id, string rol)
        {
            try
            {
                if (id != null && rol != "Administrador")
                {
                    FirebaseResponse response = await Firebase.deleteAsync($"users/{id}");
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return $"Se elimino usuario con id: {id}";
                    }
                }
                return "No se pudo eliminar usuario";
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
