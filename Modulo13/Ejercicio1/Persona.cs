﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo13
{
    public class Persona
    {

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Localidad { get; set; }

        public Persona(string nombre, int edad, string localidad)
        {
            Nombre = nombre;
            Edad = edad;
            Localidad = localidad;
        }

        public Persona() { }
    }
}
