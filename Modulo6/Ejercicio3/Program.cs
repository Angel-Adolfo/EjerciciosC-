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

            int[] numFrase = new int[4];

            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    Console.WriteLine("Ingresa un número");
                    string numero = Console.ReadLine();

                    if (int.TryParse(numero, out int numTotal))
                    {
                        numFrase[i] = numTotal;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No es valida la cantidad de numeros");
                    }
                }
            }

            StringBuilder mensaje = new StringBuilder();
            mensaje.Append($"El primer numero introducido es el {numFrase[0]}, despues han introducido el {numFrase[1]}, y {numFrase[2]} y por ultimo el {numFrase[3]}");
            Console.WriteLine(mensaje.ToString());
            Console.Read();
        }
    }
}
