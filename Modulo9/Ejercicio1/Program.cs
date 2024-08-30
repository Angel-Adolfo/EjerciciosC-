using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo9
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persona> personas = new List<Persona>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa un nombre de una persona");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingresa la edad de la persona");
                int edad = int.Parse(Console.ReadLine());

                personas.Add(new Persona { Nombre = nombre, Edad = edad });
            }

            ImprimirPersonasMayores(personas);
            Console.Read();
        }

        static void ImprimirPersonasMayores(List<Persona> personas)
        {
            Console.WriteLine("Estas personas son mayores de 18 años");
            foreach ( Persona persona in personas)
            {
                if (persona.Edad >= 18)
                {
                    Console.WriteLine(persona.Nombre + " " + "Es mayor de edad");
                }
                else
                {
                    Console.WriteLine(persona.Nombre + " " + "No es mayor de edad");
                }
            }
        }
    }
}
