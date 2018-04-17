using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Sucursal
    {
        public string nombre, ubicacion;
        public List<Vehiculos> vehiculos;
        public List<Arriendo> arriendos;
        public Cliente cliente;
        public Arriendo arriendo;
        public Sucursal(string _nombre, string _ubicacion)
        {
            nombre = _nombre;
            ubicacion = _ubicacion;
            vehiculos = new List<Vehiculos>();
            arriendos = new List<Arriendo>();
        }

        public void AnadirVehiculo(Sucursal sucursal, Vehiculos vehiculo)
        {
            sucursal.vehiculos.Add(vehiculo);
        }

        public void Arrendar(Cliente cliente, DateTime inicio, DateTime fin, Vehiculos vehiculo, Sucursal sucursal, List<Accesorios> accesorios)
        {
            if (cliente.licencia.Contains(vehiculo.licencia) && cliente is Persona)
            {
                int costo = vehiculo.costo;
                Arriendo arriendo = new Arriendo(cliente, sucursal, vehiculo, inicio, fin);
                foreach (Accesorios a in accesorios){ arriendo.accesorios.Add(a); }
                sucursal.vehiculos.Remove(vehiculo);
                sucursal.arriendos.Add(arriendo);

            }

            else if (cliente is Empresa && vehiculo is MaquinariaPesada)
            {
                int costo = vehiculo.costo;
                Arriendo arriendo = new Arriendo(cliente, sucursal, vehiculo, inicio, fin);
                foreach (Accesorios a in accesorios) { arriendo.accesorios.Add(a); }
                sucursal.vehiculos.Remove(vehiculo);
                sucursal.arriendos.Add(arriendo);
            }

            else if ((cliente is Empresa || cliente is Persona) && vehiculo is MaquinariaPesada)
            {
                Console.WriteLine("No se puede arrendar este vehiculo\n");
            }

            else { Console.WriteLine("No se puede arrendar este vehiculo.\n"); }
        }



    }
}
