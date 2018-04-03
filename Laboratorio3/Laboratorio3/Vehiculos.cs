using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Vehiculos
    {
        public string tipo;
        public int costo;
        public Vehiculos (string _tipo, int  _costo)
        {
            tipo = _tipo;
            costo = _costo;
        }
        public void AnadirTipo()
        {
            Console.WriteLine("Que tipo de vehiculo es? ");
            Console.Read();
            Console.WriteLine("Que costo tendra? ");
            Console.Read();
        }
    }
}
