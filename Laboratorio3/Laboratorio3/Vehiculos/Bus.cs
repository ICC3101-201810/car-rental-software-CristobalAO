using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Bus : Vehiculos
    {
        public Bus(string _patente, int _costo, int _ano, string _licencia) : base(_patente, _costo, _ano, _licencia) { }
    }
}
