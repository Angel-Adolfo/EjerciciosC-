using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo10
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal miAnimal = new Animal("Perro");

            miAnimal.Andar();

            if (miAnimal.EsPerro())
            {
                Console.WriteLine("Este animal es un perro.");
            }
            else
            {
                Console.WriteLine("Este animal no es un perro.");
            }

            miAnimal.Saltar();
            Console.Read();

        }
    }
}
