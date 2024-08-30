using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro { Marca = "Toyota", Modelo = "Corolla"};
            Barco barco = new Barco { Marca = "Yamaha", Modelo = "WaveRunner"};
            Avion avion = new Avion { Marca = "Boeing", Modelo = "747"};

            carro.Arrancar();
            carro.Frenar();

            Console.WriteLine("");

            barco.Arrancar();
            barco.Frenar();

            Console.WriteLine("");

            avion.Arrancar();
            avion.Frenar();

            Console.Read();
        }
    }
}
