using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4M5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un caracter cualquiera.");
            var letra = Console.ReadKey();
            var letraKey = letra.KeyChar;

            if (EsNumero(letraKey))
            {
                Console.WriteLine("El caracter es un numero");
            }
            else
            {
                if (EsVocal(letraKey))
                {
                    Console.WriteLine("El caracter es una vocal");
                }
                else
                {
                    Console.WriteLine("El caracter es una consonante");
                }
            }
            Console.ReadKey();
        }

        static bool EsNumero(char letra)
        {
            if (letra == 1 || letra == 2 || letra == 3 || letra == 4 || letra == 5 || letra == 6 ||
                letra == 7 || letra == 8 || letra == 9 || letra == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool EsVocal(char letra)
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
