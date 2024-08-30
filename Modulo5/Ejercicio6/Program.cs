using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int num;

            while ((num = VerNumero()) != 0)
            {
                numeros.Add(num);
            }

            if (numeros.Count > 0)
            {
                int max = numeros.Max();
                int min = numeros.Min();
                int difference = max - min;
                int count = numeros.Count;

                Console.WriteLine($"Número más alto: {max}");
                Console.WriteLine($"Número más bajo: {min}");
                Console.WriteLine($"Diferencia: {difference}");
                Console.WriteLine($"Cantidad de números introducidos: {count}");
            }
            else
            {
                Console.WriteLine("No se introdujeron números.");
            }

            Console.Read();
        }

        static int VerNumero()
        {
            Console.Write("Introduce un número (0 para terminar): ");
            return int.Parse(Console.ReadLine());
        }
    }
}
