using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo11
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> diccionario = new Dictionary<int, string>();

            while (true)
            {
                Console.WriteLine("Ingresa un numero o presiona el numero 'cero' para cancelar la ejecucion");
                int clave = int.Parse(Console.ReadLine());

                if (clave == 0)
                    break;

                Console.WriteLine("Introduce el valor para la cadena");
                string valor = Console.ReadLine();

                diccionario[clave] = valor;

            }

            Console.WriteLine("Ingresa una cadena de 2 letras");
            string cadena = Console.ReadLine();

            Console.WriteLine("Las claves son con los caracteres solicitados son: ", cadena);
            foreach (var item in diccionario)
            {
                if (item.Value.Contains(cadena))
                {
                    Console.WriteLine(item.Key);
                }
            }
            Console.Read();
        }
    }
}
