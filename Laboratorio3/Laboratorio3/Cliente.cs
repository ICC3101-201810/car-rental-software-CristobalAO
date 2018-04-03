using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Cliente
    {
        public Persona persona;
        public Empresa empresa;
        public string licencia;
        public Vehiculos arrienda;
        public List<Vehiculos> vehiculos = new List<Vehiculos>();
        public Cliente (Persona _persona, Empresa _empresa , string _licencia)
        {
            vehiculos.Add(arrienda);
            licencia = null;
            if (_empresa == null)
            {
                licencia = _licencia;
            }
            persona = _persona;
            empresa = _empresa;
        }
    }
}
