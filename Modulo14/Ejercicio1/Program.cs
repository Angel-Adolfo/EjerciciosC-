using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo14
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Comenzamos a preparar la receta de Pizza con Queso y Piña...");

            Task prepararMasaTask = PrepararMasa();
            Task cortarIngredientesTask = CortarIngredientes();
            Task precalentarHornoTask = PrecalentarHorno();

            await prepararMasaTask;
            await cortarIngredientesTask;

            await AgregarIngredientes();
            await precalentarHornoTask;
            await HornearPizza();

            Console.WriteLine("¡La pizza con queso y piña está lista para servir!");
            Console.Read();
        }

        static async Task PrepararMasa()
        {
            Console.WriteLine("Preparando la masa...");
            await Task.Delay(4000);
            Console.WriteLine("Masa preparada.");
        }

        static async Task CortarIngredientes()
        {
            Console.WriteLine("Cortando los ingredientes (queso y piña)...");
            await Task.Delay(2000);
            Console.WriteLine("Ingredientes cortados.");
        }

        static async Task PrecalentarHorno()
        {
            Console.WriteLine("Precalentando el horno...");
            await Task.Delay(3000);
            Console.WriteLine("Horno precalentado.");
        }

        static async Task AgregarIngredientes()
        {
            Console.WriteLine("Agregando ingredientes a la masa (queso y piña)...");
            await Task.Delay(1000);
            Console.WriteLine("Ingredientes agregados a la masa.");
        }

        static async Task HornearPizza()
        {
            Console.WriteLine("Horneando la pizza...");
            await Task.Delay(5000);
            Console.WriteLine("Pizza horneada.");
        }
    }
}
