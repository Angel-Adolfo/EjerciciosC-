using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList listNumeros = new ArrayList();

            int sumaPares = 0;
            int sumaImpares = 0;

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    Console.WriteLine("Introduce un numero");
                    string numero = Console.ReadLine();

                    if (int.TryParse(numero, out int numeroList))
                    {
                        listNumeros.Add(numeroList);

                        if (numeroList % 2 == 0)
                        {
                            sumaPares += numeroList;
                        }
                        else
                        {
                            sumaImpares += numeroList;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cantidad de numeros invalida");
                    }
                }
            }
            Console.WriteLine("La suma de los numeros pares es: " + sumaPares);
            Console.WriteLine("La suma de los numeros impares es: " + sumaImpares);
            Console.Read();
        }
    }
}
