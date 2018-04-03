using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Sucursal
    {
        public string nombre , ubicacion;
        public List<Vehiculos> vehiculos = new List<Vehiculos>();
        public Sucursal (string _nombre, string _ubicacion)
        {
            nombre = _nombre;
            ubicacion = _ubicacion;
        }
        public void AnadirVehiculo (Sucursal sucursal, Vehiculos vehiculo)
        {
            sucursal.vehiculos.Add(vehiculo);
        }
    }
}
