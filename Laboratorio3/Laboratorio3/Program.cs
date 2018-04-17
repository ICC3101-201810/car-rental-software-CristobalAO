using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool menuGeneral = true;
            while (menuGeneral == true)
            {

                //Para que hayan datos//
                //Persona p1 = new Persona();
                //Sucursal s1 = new Sucursal();
                //Auto a1 = new Auto();

                List<Vehiculos> vehiculos = new List<Vehiculos>();
                List<Sucursal> sucursales = new List<Sucursal>();
                List<Cliente> clientes = new List<Cliente>();
                Console.WriteLine("Si en cualquier momento deseas volver al menu principal solo ingresa la opcion 0");
                MENU:
                int opcion = 0;
                Console.WriteLine("\nBienvenido\nQue desea realizar?\n 1.-Crear Datos\n 2.-Hacer un arriendo\n 5.-Recibir Vehiculo\n 4.-Salir ");
                opcion = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (opcion < -1 || opcion > 4) { throw new DivideByZeroException(); }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nElija una opción válida entre 1 y 4\n");
                    Console.Beep(); Console.Beep(); Console.ResetColor();
                    continue;
                }
                if (opcion == 1)
                {
                    Console.WriteLine("\nQue desea crear?\n 1.-Vehiculo\n 2.-Sucursal\n");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion == 0) { goto MENU; }
                    if (opcion == 1)
                    {
                        Console.WriteLine("\nQue tipo de vehiculo desea crear?\n 1.-Bus\n 2.-Auto\n 3.-Acuatico\n 4.-Camion\n 5.-Maquinaria Pesada\n 6-Moto\n");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if (opcion < -1 || opcion > 6) { throw new DivideByZeroException(); }
                        }
                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nElija una opción válida entre 1 y 4\n");
                            Console.Beep(); Console.Beep(); Console.ResetColor();
                            continue;
                        }
                        if (opcion == 0) { goto MENU; }
                        else if (opcion == 1)
                        {
                            Console.WriteLine("Ingrese la patente");
                            string patente = Console.ReadLine();
                            Console.WriteLine("Ingrese el costo");
                            int costo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio");
                            int ano = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el tipo de licencia requerida");
                            string licencia = Console.ReadLine();
                            try { Bus b1 = new Bus(patente, costo, ano, licencia); vehiculos.Add(b1); Console.Beep(); Console.WriteLine("Vehiculo creado con exito"); }
                            catch
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Se han ingresado mal los valores");
                                Console.Beep(); Console.Beep(); Console.ResetColor();
                            }

                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Ingrese la patente");
                            string patente = Console.ReadLine();
                            Console.WriteLine("Ingrese el costo");
                            int costo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio");
                            int ano = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el tipo de licencia requerida");
                            string licencia = Console.ReadLine();
                            try { Auto a1 = new Auto(patente, costo, ano, licencia); vehiculos.Add(a1); Console.Beep(); Console.WriteLine("Vehiculo creado con exito"); }
                            catch
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Se han ingresado mal los valores");
                                Console.Beep(); Console.Beep(); Console.ResetColor();
                            }

                        }
                        else if (opcion == 3)
                        {
                            Console.WriteLine("Ingrese la patente");
                            string patente = Console.ReadLine();
                            Console.WriteLine("Ingrese el costo");
                            int costo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio");
                            int ano = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el tipo de licencia requerida");
                            string licencia = Console.ReadLine();
                            try { Acuatico a1 = new Acuatico(patente, costo, ano, licencia); vehiculos.Add(a1); Console.Beep(); Console.WriteLine("Vehiculo creado con exito"); }
                            catch
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Se han ingresado mal los valores");
                                Console.Beep(); Console.Beep(); Console.ResetColor();
                            }

                        }
                        else if (opcion == 4)
                        {
                            Console.WriteLine("Ingrese la patente");
                            string patente = Console.ReadLine();
                            Console.WriteLine("Ingrese el costo");
                            int costo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio");
                            int ano = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el tipo de licencia requerida");
                            string licencia = Console.ReadLine();
                            try { Camion c1 = new Camion(patente, costo, ano, licencia); vehiculos.Add(c1); Console.Beep(); Console.WriteLine("Vehiculo creado con exito"); }
                            catch
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Se han ingresado mal los valores");
                                Console.Beep(); Console.Beep(); Console.ResetColor();
                            }

                        }
                        else if (opcion == 5)
                        {
                            Console.WriteLine("Ingrese la patente");
                            string patente = Console.ReadLine();
                            Console.WriteLine("Ingrese el costo");
                            int costo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio");
                            int ano = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el tipo de licencia requerida");
                            string licencia = Console.ReadLine();
                            try { MaquinariaPesada mp1 = new MaquinariaPesada(patente, costo, ano, licencia); vehiculos.Add(mp1); Console.Beep(); Console.WriteLine("Vehiculo creado con exito"); }
                            catch
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Se han ingresado mal los valores");
                                Console.Beep(); Console.Beep(); Console.ResetColor();
                            }

                        }
                        else if (opcion == 6)
                        {
                            Console.WriteLine("Ingrese la patente");
                            string patente = Console.ReadLine();
                            Console.WriteLine("Ingrese el costo");
                            int costo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio");
                            int ano = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el tipo de licencia requerida");
                            string licencia = Console.ReadLine();
                            try { Moto m1 = new Moto(patente, costo, ano, licencia); vehiculos.Add(m1); Console.Beep(); Console.WriteLine("Vehiculo creado con exito"); }
                            catch
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Se han ingresado mal los valores");
                                Console.Beep(); Console.Beep(); Console.ResetColor();
                            }

                        }

                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("Ingrese el nombre de la sucursal");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la direccion de la sucursal");
                        string ubicacion = Console.ReadLine();
                        Sucursal sucursalNueva = new Sucursal(nombre, ubicacion);
                        Console.WriteLine("Desea agregar vehiculos?\n 1.- Si\n 2.- No");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if (opcion < -1 || opcion > 2) { throw new DivideByZeroException(); }
                        }
                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nElija una opción válida entre 1 y 2\n");
                            Console.Beep(); Console.Beep(); Console.ResetColor();
                            continue;
                        }
                        if (opcion == 0) { goto MENU; }
                        if (opcion == 1)
                        {
                            Console.WriteLine("Cuantos desea agregar?");
                            int cantidadDeVehiculos = Convert.ToInt32(Console.ReadLine());
                            while (cantidadDeVehiculos > 0)
                            {
                                Console.WriteLine("Ingrese la patente del automovil");
                                string patente = Console.ReadLine();
                                try { Vehiculos vehiculo = vehiculos.First(ve => ve.patente == patente); sucursalNueva.vehiculos.Add(vehiculo); Console.Beep(); Console.WriteLine("Vehiculo agregado con exito"); cantidadDeVehiculos--; }
                                catch
                                {
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Ingrese una patente existente");
                                    Console.Beep(); Console.Beep(); Console.ResetColor();
                                }

                            }
                        }
                        if (opcion == 2) { continue; }

                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese la sucursal");
                    string sucursal = Console.ReadLine();
                    try
                    {
                        Sucursal S = sucursales.First(ve => ve.nombre == sucursal);
                        Console.WriteLine(S.vehiculos);
                        Console.WriteLine("Ingrese la patente del automovil");
                        string patente = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del cliente");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la fecha de termino");
                        DateTime fechaTermino = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Ingrese la fecha de inicio");
                        DateTime fechaInicio = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de accesorios que quiere");
                        int numeroA = Convert.ToInt32(Console.ReadLine());
                        List<Accesorios> accesoriosArriendo = new List<Accesorios>();
                        while (numeroA > 0)
                        {
                            Console.WriteLine("Ingrese el accesorio"); string accesorioA = Console.ReadLine(); //accesoriosArriendo.Add(accesorioA);
                        }
                        try
                        {
                            Vehiculos vehiculo = vehiculos.First(ve => ve.patente == patente);
                            Cliente cliente = clientes.First(ve => ve.nombre == nombre);
                            Arriendo arriendo = new Arriendo(cliente, S, vehiculo, fechaInicio, fechaTermino);
                            S.arriendos.Add(arriendo);
                            S.vehiculos.Remove(vehiculo);
                            Console.Beep(); Console.WriteLine("Vehiculo arrendado con exito");
                        }
                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error al arrendar el vehiculo");
                            Console.Beep(); Console.Beep(); Console.ResetColor();
                        }
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingrese una sucursal existente");
                        Console.Beep(); Console.Beep(); Console.ResetColor();
                    }

                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Ingrese la sucursal");
                    string sucursal = Console.ReadLine();
                    try
                    {
                        Sucursal S = sucursales.First(ve => ve.nombre == sucursal);
                        Console.WriteLine(S.vehiculos);
                        Console.WriteLine("Ingrese la patente del automovil");
                        string patente = Console.ReadLine();
                        try
                        {
                            Vehiculos vehiculo = vehiculos.First(ve => ve.patente == patente);
                            Arriendo arriendo = S.arriendos.First(arr => arr.vehiculo == vehiculo);
                            S.arriendos.Remove(arriendo);
                            S.vehiculos.Add(vehiculo);
                            Console.Beep(); Console.WriteLine("Vehiculo quitado con exito");
                        }
                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error al quitar el vehiculo");
                            Console.Beep(); Console.Beep(); Console.ResetColor();
                        }
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingrese una sucursal existente");
                        Console.Beep(); Console.Beep(); Console.ResetColor();
                    }

                }
                else if (opcion == 4)
                {
                    menuGeneral = false;
                }
            }
        }
    }
}
