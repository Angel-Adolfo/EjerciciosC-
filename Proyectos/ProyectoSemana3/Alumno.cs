using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana3
{
    class Alumno
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string Carrera { get; set; }
        public double[] Notas { get; set; }

        public Alumno(string nombre, string apellido, string identificacion, string carrera, double[] notas) 
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Carrera = carrera;
            Notas = notas;
        }

        public double Promedio()
        {
            double suma = 0;
            for (int i = 0; i < Notas.Length; i++)
            {
                suma += Notas[i];
            }
            return suma / Notas.Length;
        }

    }
}
