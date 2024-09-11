using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDePropina
{
    class Program
    {
        static void Main()
        {
            double totalCuenta; 

            while (true)
            {
                Console.WriteLine("Ingrese el total de la cuenta:");
                totalCuenta = double.Parse(Console.ReadLine());

                if (totalCuenta >= 1 && totalCuenta <= 1000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("El monto tiene que ser entre el rango de 1 a 1000 quetzales.");
                }
            }

            Console.WriteLine("Ingrese el porcentaje de propina:");
            double porcentajePropina = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de personas:");
            int numeroPersonas = int.Parse(Console.ReadLine());

            double totalConPropina = CalcularTotalConPropina(totalCuenta, porcentajePropina);
            double[] montosPorPersona = DividirCuenta(totalConPropina, numeroPersonas);

            Console.WriteLine($"Total de la cuenta con propina: Q{totalConPropina:N2} (En letras: {NumeroALetras((int)totalConPropina)})");

            for (int i = 0; i < montosPorPersona.Length; i++)
            {
                Console.WriteLine($"Persona {i + 1}: Q{montosPorPersona[i]:N2}");
            }

            Console.Read();
        }

        static double CalcularTotalConPropina(double total, double porcentaje)
        {
            return total + (total * porcentaje / 100);
        }

        static double[] DividirCuenta(double total, int personas)
        {
            double[] resultados = new double[personas];
            double montoBase = Math.Floor((total / personas) * 100) / 100;
            double acumulado = montoBase * personas;
            for (int i = 0; i < personas; i++)
            {
                resultados[i] = montoBase;
                if (i == personas - 1)
                {
                    resultados[i] += (total - acumulado);
                }
            }
            return resultados;
        }

        static string NumeroALetras(int numero)
        {
            string[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve", "veinte" };
            string[] decenas = { "", "", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] centenas = { "", "cien", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

            if (numero == 1000)
                return "mil quetzales";

            string resultado = "";
            int centena = numero / 100;
            int decena = (numero % 100) / 10;
            int unidad = numero % 10;

            if (centena > 0)
            {
                resultado += centenas[centena] + " ";
            }
            
            if (decena > 1)
            {
                resultado += decenas[decena] + (unidad > 0 ? " y " + unidades[unidad] : "");
            }
            else
            {
                resultado += unidades[numero % 100];
            }

            return resultado.Trim() + " quetzales";
        }
    }
}
