using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Organizacion:Cliente
    {
        public string ubicacion;
        public Organizacion(string _nombre, string _ubicacion, int _numero, bool permisoBus, bool permisoMP) : base(_nombre,_numero, permisoBus, permisoMP)
        {
            ubicacion = _ubicacion;
        }
    }
}
