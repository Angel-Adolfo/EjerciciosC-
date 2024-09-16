using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana3
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] alumnos = new Alumno[]
            {
            new Alumno("Angel", "Mendez", "101", "Ingeniería", new double[] { 8.9, 7.0, 10.0, 8.0, 7.5 }),
            new Alumno("Sofia", "Arriola", "102", "Medicina", new double[] { 9.0, 8.5, 9.5, 10.0, 8.0 }),
            new Alumno("Elmer", "Santos", "103", "Ingeniería", new double[] { 0.5, 5.0, 6.0, 7.0, 6.0 }),
            new Alumno("Alejandro", "Max", "104", "Dibujo", new double[] { 0.5, 2.5, 9.5, 8.3, 5.5 }),
            new Alumno("Andrew", "Mendez", "105", "Electricidad", new double[] { 5.0, 8.5, 9.0, 10.0, 10.0 }),
            };

            Console.WriteLine("Informacion de todos los alumnos:");
            Console.WriteLine(" ");
            foreach (var alumno in alumnos)
            {
                Console.WriteLine($"{alumno.Nombre} {alumno.Apellido} {alumno.Identificacion} {alumno.Carrera} {alumno.Promedio():0.00}");
            }

            Console.ReadKey();
        }
    }
}
