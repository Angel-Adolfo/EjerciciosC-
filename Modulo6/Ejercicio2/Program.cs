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

            string frase;

            while (true)
            {
                Console.WriteLine("Ingresa una frase");
                frase = Console.ReadLine();

                string fraseRemplazada = frase.Replace("a", "x").Replace("A", "X");
                string fraseMayus = frase.ToUpper();
                string fraseMinus = frase.ToLower();
                string fraseInvertida = new string(frase.Reverse().ToArray());
                

                if (ValidarFrase(frase))
                {
                    int numFrase = frase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    string[] terceraPalabra = frase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine("Frase valida: " + frase);
                    Console.WriteLine("Frase remplazada: " + fraseRemplazada);
                    Console.WriteLine("Frase en Mayusculas: " + fraseMayus);
                    Console.WriteLine("Frase en Minusculas: " + fraseMinus);
                    if (frase.Length >= 10)
                    {
                        string subFrase = frase.Substring(5, 5);
                        Console.WriteLine("Del caracter 5 al 10: " + subFrase);
                    }
                    Console.WriteLine("Frase invertida: " + fraseInvertida);
                    Console.WriteLine("La frase tiene: " + numFrase + " palabras en total");
                    if (terceraPalabra.Length >= 3)
                    {
                        Console.WriteLine($"La tercera palabra es: {terceraPalabra[2]}");
                    }
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Frase invalida");
                }
            }
            Console.Read();
        }

        static bool ValidarFrase(string frase)
        {
            int numPalabras = frase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            return frase.Length >= 20 && numPalabras >= 4;
        }

    }
}
