using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class MaquinariaPesada:Vehiculos
    {
        public MaquinariaPesada(string _patente, int _costo, int _ano, string _licencia) : base(_patente, _costo, _ano, _licencia) { }
    }
}
