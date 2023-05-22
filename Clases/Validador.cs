using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Clases
{
    public class Validador
    {

        public bool ValidarNombre(string nombre)
        {
            if (nombre == null && int.TryParse(nombre, out int respuesta) == true)
            {
                return true;
            }

            return false;
        }
    }
}
