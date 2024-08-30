using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            ImprimirTablaDeMultiplicar(numero);

            Console.ReadKey();
        }

        static void ImprimirTablaDeMultiplicar(int numero)
        {
            Console.WriteLine($"Tabla de multiplicar del {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
                
            }
            
        }
    }
}
