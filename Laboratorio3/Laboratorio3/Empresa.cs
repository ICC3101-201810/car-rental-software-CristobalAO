using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Empresa:Cliente
    {
        public string nombre, ubicacion;
        public Empresa (string _nombre, string _ubicacion, int _numero):base( _numero)
        {
            nombre = _nombre;
            ubicacion = _ubicacion;
        }
    }
}
