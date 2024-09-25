using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana4
{
    public class Biblioteca : IBiblioteca
    {

        private List<Material> materiales = new List<Material>();

        public void AgregarMaterial(Material material)
        {
            materiales.Add(material);
            Console.WriteLine($"'{material.Titulo}' se agrego a la biblioteca");
        }

        public List<Material> BuscarPorTitulo(string titulo)
        {
            return materiales.Where(m => m.Titulo.Contains(titulo)).ToList();
        }

        public void PrestarMaterial(Material material)
        {
            if (material is Libro libro)
            {
                libro.Prestar();
            }
            else if (material is Revista revista)
            {
                revista.Prestar();
            }
            else
            {
                Console.WriteLine("Tipo de material no soportado.");
            }
        }

        public void DevolverMaterial(Material material)
        {
            if (!material.Disponible)
            {
                if (material is Libro libro)
                {
                    libro.Devolver();
                }
                else
                {
                    Console.WriteLine($"El material '{material.Titulo}' no es un libro, no puede devolverse.");
                }
            }
            else
            {
                Console.WriteLine($"El material '{material.Titulo}' no estaba prestado.");
            }
        }
        public List<Libro> BuscarLibrosPorTitulo(string titulo)
        {
            var librosCoincidentes = materiales
                .OfType<Libro>() 
                .Where(l => l.Titulo.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0) 
                .ToList();

            if (librosCoincidentes.Count == 0)
            {
                Console.WriteLine($"No se encontraron libros con la palabra '{titulo}' en el título.");
            }
            else
            {
                Console.WriteLine($"Se encontraron {librosCoincidentes.Count} libros con la palabra '{titulo}' en el título:");
                foreach (var libro in librosCoincidentes)
                {
                    Console.WriteLine($"- Título: {libro.Titulo}, Autor: {libro.Autor}, Disponible: {(libro.Disponible ? "Sí" : "No")}");
                }
            }

            return librosCoincidentes;
        }
    }
}
