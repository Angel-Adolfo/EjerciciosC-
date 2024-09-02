using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Recolector<R>
    {

        List<R> listado = new List<R>();

        public void Guardar(R num)
        {
            listado.Add(num);
        }

        public void GetNum()
        {
            Console.WriteLine("Los valores recolectados en la lista son:");
            foreach (var item in listado)
            {
                Console.WriteLine(item);
            }
        }

    }
}
