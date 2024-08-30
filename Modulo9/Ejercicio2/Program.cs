using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa el nombre de la persona");
            string nombre = Console.ReadLine();

            Console.WriteLine("Es Alumno o Profesor");
            string profesion = Console.ReadLine();

            Console.WriteLine("Ingresa la edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Si puede ser profesor");
            } 
            else if (profesion.Equals("Alumno", StringComparison.OrdinalIgnoreCase))
            {
                Alumno alumno = new Alumno();

                alumno.Nombre = nombre;
                alumno.Edad = edad;
                Console.WriteLine("Ingresa el Num. de carnet del alumno");
                alumno.Carnet = int.Parse(Console.ReadLine());

                Console.WriteLine($"El alumno {alumno.Nombre} de la edad de {alumno.Edad} con el carnet {alumno.Carnet}");
            }
            else if (profesion.Equals("Profesor", StringComparison.OrdinalIgnoreCase))
            {
                if (edad < 18)
                {
                    Console.WriteLine("La edad no es la correcta para que sea un profesor");
                }
                else
                {
                    Profesor profesor = new Profesor();

                    profesor.Nombre = nombre;
                    profesor.Edad = edad;
                    Console.WriteLine("Que materia imparte este profesor?");
                    profesor.MateriaQueImparte = Console.ReadLine();

                    Console.WriteLine($"El profesor {profesor.Nombre} imparte la materia {profesor.Nombre} a la edad de {profesor.Edad}");
                }
                
            }
            else
            {
                Console.WriteLine("Datos no validos");
            }
            Console.Read(); 
        }
    }
}
