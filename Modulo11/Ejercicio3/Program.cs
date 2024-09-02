using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa un numero");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"El valor es del animal: {EsTipoAnimal(numero)}");
            Console.Read();
        }

        public static string EsTipoAnimal(int tipoAnimal)
        {
            switch (tipoAnimal)
            {
                case 12:
                    return Animales.Caballo.ToString();
                    break;
                case 2:
                    return Animales.Canario.ToString();
                    break;
                case 8:
                    return Animales.Gato.ToString();
                    break;
                case 5:
                    return Animales.Perro.ToString();
                    break;
                default:
                    return "Desconocido";
                    break;
            }
            return string.Empty;
        }
    }
}
