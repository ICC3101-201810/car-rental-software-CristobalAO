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
        public List<string> licencia;
        public bool permisoBus,permisoMP;
        public string nombre;
        public Cliente (string _nombre,int _numero, bool permisoBus, bool permisoMP)
        {
            nombre = _nombre;
            numero = _numero;
            licencia = new List<string>();
        }
        public bool PermisoBus(Cliente cliente)
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 101);
            if (cliente.permisoBus == true)
            {
                Console.WriteLine("Ya se tiene el permiso");
                return true;
            }
            else
            {
                if (cliente is Empresa && numero < 63) { return true; }
                else if (cliente is Organizacion && numero < 35) { return true; }
                else if (cliente is Institucion && numero < 58) { return true; }
                else { return false; }
            }
        }
        public bool PermisoMP(Cliente cliente)
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 101);
            if (cliente.permisoBus == true)
            {
                Console.WriteLine("Ya se tiene el permiso");
                return true;
            }
            else
            {
                if (cliente is Empresa && numero < 63) { return true; }
                else { return false; }
            }
        }

    }
}
