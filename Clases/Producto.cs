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


    }
}
