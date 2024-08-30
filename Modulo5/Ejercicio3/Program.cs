using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3M5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un importe");
            var importe = double.Parse(Console.ReadLine());

            double[] dinero = { 200, 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01};
            string[] nombreDinero = { "billete de 200", "billete de 100", "billete de 50",
                "billete de 20", "billete de 10", "billetes de 5",
                "moneda de 1", "moneda de 50 centavos", "monedas de 25 centavos",
                "monedas de 10 centavos", "monedas de 5 centavos", "monedas de 1 centavos"};

            for (int i = 0; i < dinero.Length; i++)
            {
                int cantidad = CantidadBilletesYMonedas(importe, dinero[i]);

                if (cantidad > 0)
                {
                    importe -= cantidad * dinero[i];
                    Console.WriteLine($"La cantidad total es de {cantidad} {nombreDinero[i]}");
                }
            }

            Console.Read();

        }

        static int CantidadBilletesYMonedas(double importe, double dinero)
        {
            if (importe >= dinero)
            {
                return (int)(importe / dinero);
            }
            return 0;
        }
    }
}
