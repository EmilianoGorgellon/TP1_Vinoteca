using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Clases
{
    public class Persona
    {
        private string _usuario;
        private string _password;
        private bool _isAdmin;
        public string Usuario { get { return _usuario; } set { _usuario = value; } }

        public string Password { get { return _password; } set { _password = value; } }
        
        public bool IsAdmin { get {  return _isAdmin; } set {  _isAdmin = value; } }
    }
}
