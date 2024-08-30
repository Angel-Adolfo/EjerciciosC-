using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Como te llamas?");

            string nombre = Console.ReadLine();

            if (nombre.Equals("Alejandro", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hola Alejandro");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
            Console.Read();
        }
    }
}
