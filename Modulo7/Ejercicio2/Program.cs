using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList nombresList = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa un nombre:");
                string nombre = Console.ReadLine();

                nombresList.Add(nombre);
            }

            Console.WriteLine("Introduce otro nombre para ver si esta en la lista");
            string nombreExtra = Console.ReadLine();

            if (nombresList.Contains(nombreExtra))
            {
                Console.WriteLine($"El nombre {nombreExtra} esta dentro de la lista");
            }
            else
            {
                Console.WriteLine($"El nombre {nombreExtra} no esta dentro de la lista");
            }
            Console.Read();
        }
    }
}
