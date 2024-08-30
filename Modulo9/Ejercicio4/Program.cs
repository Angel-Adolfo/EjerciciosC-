using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehiculo vehiculoUno = new Vehiculo();
            Console.WriteLine($"El primer vehiculo tiene {vehiculoUno.Ruedas} ruedas y tiene {vehiculoUno.GetPuertas()} puertas");

            Vehiculo vehiculoDos = new Vehiculo(6);
            Console.WriteLine($"El primer vehiculo tiene {vehiculoDos.Ruedas} y tiene {vehiculoDos.GetPuertas()}");

            Vehiculo vehiculoTres = new Vehiculo(8, 10);
            Console.WriteLine($"El primer vehiculo tiene {vehiculoTres.Ruedas} y tiene {vehiculoTres.GetPuertas()}");

            Console.Read();
        }
    }
}
