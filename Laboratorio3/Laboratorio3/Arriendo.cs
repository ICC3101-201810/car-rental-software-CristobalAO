using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Arriendo
    {
        Cliente cliente;
        Sucursal sucursal;
        public Vehiculos vehiculo;
        DateTime dia, termino;
        public List<Accesorios> accesorios;
        public Arriendo ( Cliente _cliente, Sucursal _sucursal, Vehiculos _vehiculo, DateTime _dia, DateTime _termino)
        {
            cliente = _cliente;
            sucursal = _sucursal;
            vehiculo = _vehiculo;
            dia = _dia;
            termino = _termino;
            accesorios = new List<Accesorios>();

        }
        
    }
    
}
