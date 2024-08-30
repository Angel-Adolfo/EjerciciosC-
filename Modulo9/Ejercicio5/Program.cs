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

            int valorFinal = Producto.SumarValores(50, 50);
            Console.WriteLine("El resultado de la suma de los valores es: " + valorFinal);
            Console.Read();

        }
    }
}
