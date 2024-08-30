using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo10
{
    public class Animal : IAnimal
    {
        private string tipo;
        public Animal(string tipo)
        {
            this.tipo = tipo;
        }
        public void Andar()
        {
            Console.WriteLine("El animal está andando.");
        }
       
        public bool EsPerro()
        {
            return tipo.ToLower() == "perro";
        }
       
        public void Saltar()
        {
            Console.WriteLine("El animal ha saltado.");
        }

    }
}
