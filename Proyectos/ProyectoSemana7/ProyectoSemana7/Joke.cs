using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoSemana6.Models
{
    public class Joke
    {
        public string Content { get; set; }

        public Joke(string content)
        {
            Content = content;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
