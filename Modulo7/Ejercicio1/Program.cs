using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo7
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList numLista = new ArrayList();

            int sumaList = 0;

            for (int i = 1; i <= 1000; i++)
            {
                numLista.Add(i);
            }
            
            Console.WriteLine("El resultado de la lista es:");
            foreach (int num in numLista)
            {
                sumaList += num;
                Console.WriteLine(sumaList);
            }
            Console.Read();
        }
    }
}
