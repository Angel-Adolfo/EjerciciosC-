using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Barco : Vehiculo
    {

        public override void Arrancar()
        {
            Console.WriteLine($"El barco {Marca} {Modelo} esta arrancando");
        }

        public override void Frenar()
        {
            Console.WriteLine($"El barco {Marca} {Modelo} esta frenando");
        }

    }
}
