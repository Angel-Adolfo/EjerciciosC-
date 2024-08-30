using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Carro : Vehiculo
    {

        public override void Arrancar()
        {
            Console.WriteLine($"El carro {Marca} {Modelo} esta arrancando");
        }

        public override void Frenar()
        {
            Console.WriteLine($"El carro {Marca} {Modelo} esta frenando");
        }

    }
}
