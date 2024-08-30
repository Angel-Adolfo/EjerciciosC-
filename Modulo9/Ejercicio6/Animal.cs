using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Animal
    {

        public string ColorDePelo { get; set; }
        public int NumPatas { get; set; }
        public string Raza { get; set; }

        public Animal()
        {

        }

        public Animal(string colorDePelo, int numPatas, string raza)
        {
            ColorDePelo = colorDePelo;
            NumPatas = numPatas;
            Raza = raza;
        }

        public void AnimalInfo()
        {
            Console.WriteLine($"El color de pelo del animal es: {ColorDePelo}");
            Console.WriteLine($"Numero de patas: {NumPatas}");
            Console.WriteLine($"La raza es: {Raza}");
        }


    }
}
