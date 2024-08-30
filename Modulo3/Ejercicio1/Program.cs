using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su nombre");

            String nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.ReadKey();

            Console.WriteLine("Ingrese su ciudad");

            String ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + "bienvenido a " + ciudad);
            Console.ReadKey();
        }
    }
}
