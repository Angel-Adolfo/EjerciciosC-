using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal 
            { 
                ColorDePelo = "Marron", 
                NumPatas = 4, 
                Raza = "Pastor Aleman" 
            };

            animal.AnimalInfo();
            Console.Read();
        }
    }
}
