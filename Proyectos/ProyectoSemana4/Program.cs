using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana4
{
    class Program
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();

            Libro libro1 = new Libro("El principito", "Antoine de Saint-Exupéry");
            Libro libro2 = new Libro("El señor presidente", "Miguel Ángel Asturias");
            Revista revista1 = new Revista("National Geographic", 2021);


            Console.WriteLine("Libros que se agregaron a la biblioteca.");
            Console.WriteLine(" ");
            biblioteca.AgregarMaterial(libro1);
            biblioteca.AgregarMaterial(libro2);
            biblioteca.AgregarMaterial(revista1);
            Console.WriteLine(" ");

            biblioteca.PrestarMaterial(libro1);
            biblioteca.DevolverMaterial(libro1);
            Console.WriteLine(" ");

            biblioteca.PrestarMaterial(libro2);
            //biblioteca.DevolverMaterial(libro2);
            Console.WriteLine(" ");

            biblioteca.BuscarLibrosPorTitulo("señor");
            Console.ReadKey();
        }
    }
}
