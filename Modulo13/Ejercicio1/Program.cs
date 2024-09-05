using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo13
{
    class Program
    {

        const string filePath = "miArchivo.txt";
        static void Main(string[] args)
        {
            List<Persona> personas = LeerArchivoPersona();
            string opcion = "S";

            while (opcion == "S")
            {
                Console.WriteLine("Introduzca el nombre de la persona:");
                var nombre = Console.ReadLine();

                Console.WriteLine("Introduzca la edad de la persona:");
                var edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca la localidad de la persona:");
                var localidad = Console.ReadLine();

                personas.Add(new Persona(nombre, edad, localidad));

                Console.WriteLine("¿Quieres introducir otra persona? S o N?");
                opcion = Console.ReadLine().ToUpper();
            }
            GuardarPersonasEnArchivo(personas);
            ListarPersonas(personas);
            Console.Read();
        }

        static List<Persona> LeerArchivoPersona()
        {
            var personas = new List<Persona>();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        var persona = ExtractPersona(linea);
                        personas.Add(persona);
                    }
                }
            }
            return personas;
        }

        static void GuardarPersonasEnArchivo(List<Persona> personas)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var persona in personas)
                {
                    writer.WriteLine($"{persona.Nombre}|{persona.Edad}|{persona.Localidad}");
                }
            }
        }

        static void ListarPersonas(List<Persona> personas)
        {
            Console.WriteLine("\nPersonas en el archivo:");
            foreach (var persona in personas)
            {
                Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}, Localidad: {persona.Localidad}");
            }
        }

        public static Persona ExtractPersona(string linea)
        {
            var datos = linea.Split('|');
            return new Persona
            {
                Nombre = datos[0],
                Edad = int.Parse(datos[1]),
                Localidad = datos[2]
            };
        }

    }
}
