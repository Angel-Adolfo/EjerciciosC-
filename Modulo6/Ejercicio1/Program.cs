using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escriba una palabra");

            string palabra = Console.ReadLine();

            string palabraVolteada = new string(palabra.Reverse().ToArray());

            Console.WriteLine("Tu palabra paso a ser: " + palabraVolteada);
            Console.Read();
        }
    }
}
