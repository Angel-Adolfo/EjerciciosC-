using System;
using System.Collections;
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

            List<int> numList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                int numero = int.Parse(Console.ReadLine());

                numList.Add(numero);
            }

            int numeroMayor = numList.Max();
            int numeroMenor = numList.Min();

            Console.WriteLine("El numero mayor de la lista es: " + numeroMayor);
            Console.WriteLine("El numero menor de la lista es: " + numeroMenor);
            Console.Read();
        }
    }
}
