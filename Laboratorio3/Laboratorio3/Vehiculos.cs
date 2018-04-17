using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Vehiculos
    {
        public string patente, licencia;
        public int costo, ano;
        public Vehiculos (string _patente, int  _costo, int _ano, string _licencia)
        {
            ano = _ano;
            patente = _patente;
            costo = _costo;
            licencia = _licencia;
        }
        
    }
}
