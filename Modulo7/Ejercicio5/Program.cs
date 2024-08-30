using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa el valor que tenga el array");
            int valorArray = int.Parse(Console.ReadLine());

            int[] numeros = new int[valorArray];

            for (int i = 0; i < valorArray; i++)
            {
                Console.WriteLine("Ingrese valores al array");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingresa el valor para cambiar la posicion");
            int posicion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nuevo valor");
            numeros[posicion - 1 ] = int.Parse(Console.ReadLine());

            Console.WriteLine("Los nuevos valores son:");
            for (int i = 0; i < valorArray; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.Read();
        }
    }
}
