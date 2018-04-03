using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Persona:Cliente
    {
        public string nombre, rut,licencia;
        public Persona (string _nombre, string _rut, string _licencia, int _numero) : base(_numero)
        {
            nombre = _nombre;
            rut = _rut;
            licencia = _licencia;
        }
    }
}
