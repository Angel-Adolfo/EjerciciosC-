using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraM5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Bienvenido-----");
            Console.WriteLine("1. ----- Suma -----");
            Console.WriteLine("2. ----- Resta -----");
            Console.WriteLine("3. ----- Multiplicacion -----");
            Console.WriteLine("4. ----- Division -----");
            //Console.WriteLine("5. ----- Salir -----");

            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = Suma(num1, num2);
                    break;
                case 2:
                    resultado = Resta(num1, num2);
                    break;
                case 3:
                    resultado = Multiplicacion(num1, num2);
                    break;
                case 4:
                    resultado = Division(num1, num2);
                    break;
                default:
                    break;
            }
            Console.WriteLine("El resultado al operar es: " + resultado);
            Console.Read();
        }
        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Division(int num1, int num2)
        {
            if (num2 == 0 || num1 == 0)
            {
                Console.WriteLine("No se puede realizar la operacion!!");
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}
