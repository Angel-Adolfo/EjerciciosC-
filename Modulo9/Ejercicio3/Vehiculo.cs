using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Vehiculo
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual void Arrancar()
        {
            Console.WriteLine("Estoy arrancando");
        }

        public virtual void Frenar()
        {
            Console.WriteLine("Estoy frenando");
        }
    }
}
