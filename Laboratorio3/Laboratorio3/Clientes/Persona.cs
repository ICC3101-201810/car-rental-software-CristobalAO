using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Persona:Cliente
    {
        public string  rut;
        public Persona (string _nombre, string _rut, int _numero, bool permisoBus, bool permisoMP) : base(_nombre,_numero, permisoBus, permisoMP)
        {
            rut = _rut;
        }
    }
}
