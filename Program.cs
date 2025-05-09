using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_P_Clase_II_10_Instacias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            do
            {
                string op, matricula, modelo;
                int cv;

                Console.WriteLine("\n--- REGISTRO DE VEHÍCULOS ---");
                Console.Write("¿Qué tipo de vehículo desea ingresar? (1: Taxi, 2: Autobús, 3: Otro Vehículo): ");
                op = Console.ReadLine();

                Console.Write("Ingrese la matrícula del vehículo: ");
                matricula = Console.ReadLine();

                Console.Write("Ingrese el modelo del vehículo: ");
                modelo = Console.ReadLine();

                Console.Write("Ingrese los caballos de fuerza (CV): ");
                cv = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case "1":
                        Console.Write("Ingrese el número de licencia del taxi: ");
                        int numLicen = int.Parse(Console.ReadLine());

                        Taxi taxi = new Taxi
                        {
                            matricula = matricula,
                            modelo = modelo,
                            cv = cv,
                            numLicen = numLicen
                        };

                        listaVehiculos.Add(taxi);

                        Console.WriteLine($"\nTaxi registrado:");
                        Console.WriteLine($"Matrícula: {taxi.matricula}");
                        Console.WriteLine($"Modelo: {taxi.modelo}");
                        Console.WriteLine($"CV: {taxi.cv}");
                        Console.WriteLine($"Licencia: {taxi.numLicen}");
                        break;

                    case "2":
                        Console.Write("Ingrese el número de plazas del autobús: ");
                        int plazas = int.Parse(Console.ReadLine());

                        Autobus bus = new Autobus
                        {
                            matricula = matricula,
                            modelo = modelo,
                            cv = cv,
                            numeroPlazos = plazas
                        };

                        listaVehiculos.Add(bus);

                        Console.WriteLine($"\nAutobús registrado:");
                        Console.WriteLine($"Matrícula: {bus.matricula}");
                        Console.WriteLine($"Modelo: {bus.modelo}");
                        Console.WriteLine($"CV: {bus.cv}");
                        Console.WriteLine($"Plazas: {bus.numeroPlazos}");
                        break;

                    case "3":
                        Vehiculo vehiculo = new Vehiculo
                        {
                            matricula = matricula,
                            modelo = modelo,
                            cv = cv
                        };

                        listaVehiculos.Add(vehiculo);

                        Console.WriteLine($"\nVehículo registrado:");
                        Console.WriteLine($"Matrícula: {vehiculo.matricula}");
                        Console.WriteLine($"Modelo: {vehiculo.modelo}");
                        Console.WriteLine($"CV: {vehiculo.cv}");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.Write("\n¿Desea ingresar otro vehículo? (s/n): ");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            // Mostrar todos los vehículos registrados
            Console.WriteLine("\n--- LISTA DE VEHÍCULOS REGISTRADOS ---");
            foreach (var v in listaVehiculos)
            {
                Console.WriteLine($"\nTipo: {v.GetType().Name}");
                Console.WriteLine($"Matrícula: {v.matricula}");
                Console.WriteLine($"Modelo: {v.modelo}");
                Console.WriteLine($"CV: {v.cv}");

                if (v is Taxi t) {
                    Console.WriteLine($"Licencia: {t.numLicen}");
                }
                else if (v is Autobus a) {
                    Console.WriteLine($"Plazas: {a.numeroPlazos}");
                }
                    
            }
            Console.WriteLine("\nGracias por usar el sistema. Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
