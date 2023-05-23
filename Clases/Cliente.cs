using Microsoft.VisualBasic.ApplicationServices;
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
       
    }
}
