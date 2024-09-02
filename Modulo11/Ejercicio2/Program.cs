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

            Recolector<string> recolector = new Recolector<string>();

            while (true)
            {
                Console.WriteLine("Ingresa valores a este recolector (escribe la palabra 'salir' para cerrar el programa)");
                string valor = Console.ReadLine();

                if (valor.ToLower() == "salir")
                    break;

                recolector.Guardar(valor);
            }

            recolector.GetNum();
            Console.Read();
        }
    }
}
