using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Cliente
    {
        public int numero;
        public Vehiculos arrienda;
        public List<Vehiculos> vehiculos = new List<Vehiculos>();
        public Cliente (int _numero)
        {
            vehiculos.Add(arrienda);
            numero = _numero;
        }
        public void Arrienda()
        {
            Console.WriteLine("Que tipo de vehiculo desea arrendar? ");
            string tipo = Console.ReadLine().ToString();
        }
    }
}
