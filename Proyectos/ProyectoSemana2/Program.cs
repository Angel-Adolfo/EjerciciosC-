using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana2
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;

            do
            {
                Console.WriteLine("Ingresa una frase (se verificara si es pálindromo o no)");
                string frase = Console.ReadLine();

                //string palindromo = frase.Replace(" ", "").ToLower();
                string palindromo = new string(frase.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();

                char[] charArray = palindromo.ToCharArray();
                Array.Reverse(charArray);
                string fraseInvertida = new string(charArray);

                if (palindromo == fraseInvertida)
                {
                    Console.WriteLine("Esta frase es un pálindromo");
                }
                else
                {
                    Console.WriteLine("Esta frase no es un pálindromo");
                }

                Console.WriteLine("Quieres ingresar otra frase? (si/no)");
                respuesta = Console.ReadLine().Trim().ToLower();

            } while (respuesta == "si");

            Console.WriteLine("Programa finalizado");
            Console.ReadKey();
            
        }
    }
}
