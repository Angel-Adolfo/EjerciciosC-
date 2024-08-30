using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosModulo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Ejercicio1

            //int numeroUno = 5;
            //int numeroDos = 10;
            //int numeroTres = 15;

            //int resultado = numeroUno + numeroDos + numeroTres;

            //Console.WriteLine("El resultado de la suma es " + resultado);
            //Console.ReadKey();

            //#endregion


            //#region Ejercicio2
            //Console.WriteLine("Ingrese un número");

            //int num1 = int.Parse(Console.ReadLine());
            //Console.ReadKey();

            //Console.WriteLine("Ingrese otro número");

            //int num2 = int.Parse(Console.ReadLine());
            //Console.ReadKey();

            //if (num1 > num2)
            //{
            //    Console.WriteLine("El primer numero es mayor al segundo");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("El segundo numero es mayor al primero");
            //    Console.ReadKey();
            //}
            //#endregion

            //#region Ejercicio3

            //Console.WriteLine("Ingrese un dia de la semana");

            //string dia = Console.ReadLine();

            //switch (dia)
            //{
            //    case "Lunes":
            //    case "Martes":
            //    case "Miercoles":
            //    case "Jueves":
            //    case "Viernes":
            //        Console.WriteLine("No es fin de semana");
            //        break;
            //    case "Sabado":
            //    case "Domingo":
            //        Console.WriteLine("Es fin de semana");
            //        break;
            //    default:
            //        Console.WriteLine("El dia que ingresaste no es valido");
            //        break;
            //}
            //Console.ReadKey();

            //#endregion

            //#region Ejercicio 4

            //Console.WriteLine("Ingrese el valor de su producto");

            //int valor = int.Parse(Console.ReadLine());
            //Console.ReadKey();

            //if (valor <= 0)
            //{
            //    Console.WriteLine("El valor debe ser mayor a cero");
            //    return;
            //}

            //Console.WriteLine("Seleccione el metodo de paso (Efectivo o Tarjeta)");

            //string pago = Console.ReadLine();

            //if (pago == "Efectivo")
            //{
            //    Console.WriteLine("El precio total es: " + valor);
            //    Console.ReadKey();
            //}
            //else if (pago == "Tarjeta")
            //{
            //    Console.WriteLine("Ingrese el numero de cuenta");

            //    int numCuenta = int.Parse(Console.ReadLine());

            //    Console.WriteLine("El precio total a pagar es: " + valor + " y se pago con el numero de cuenta: " + numCuenta);
            //}
            //else
            //{
            //    Console.WriteLine("La forma de pago no es valida, favor de intentar una forma valida");
            //}

            //Console.ReadKey();

            //#endregion

            //#region Ejercicio5

            //for (int i = 1; i <= 100 ; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();
            //#endregion

            //#region Ejercicio6

            //int i = 1;

            //while (i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.Read();
            //#endregion

            //#region Ejercicio7

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Read();

            //#endregion

            //#region Ejercicio8

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0 || i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Read();
            //#endregion

            //#region Ejercicio9

            //int[] numeros = new int[50];

            //int par = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        numeros[par] = i;
            //        par++;
            //    }
            //}

            //foreach (int numPar in numeros)
            //{
            //    Console.WriteLine(numPar);
            //}
            //Console.Read();
            //#endregion

            //#region Ejercicio10

            //int sumaPares = 0;
            //int restaImpares = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Inrese el numero");
            //    int numero = int.Parse(Console.ReadLine());

            //    if (numero % 2 == 0)
            //    {
            //        sumaPares += numero;
            //    }
            //    else
            //    {
            //        restaImpares += numero;
            //    }
            //}

            //int resultado = sumaPares - restaImpares;

            //Console.WriteLine("El resultado es: " + resultado);
            //Console.Read();

            //#endregion

            //#region Ejercicio11

            //Console.WriteLine("Ingrese un numero del 1 al 7");

            //int num = int.Parse(Console.ReadLine());
            //string diaDeLaSemana;

            //switch (num)
            //{
            //    case 1:
            //        diaDeLaSemana = "Lunes";
            //        break;
            //    case 2:
            //        diaDeLaSemana = "Martes";
            //        break;
            //    case 3:
            //        diaDeLaSemana = "Miercoles";
            //        break;
            //    case 4:
            //        diaDeLaSemana = "Jueves";
            //        break;
            //    case 5:
            //        diaDeLaSemana = "Viernes";
            //        break;
            //    case 6:
            //        diaDeLaSemana = "Sabado";
            //        break;
            //    case 7:
            //        diaDeLaSemana = "Domingo";
            //        break;
            //    default:
            //        diaDeLaSemana = "Campo no valido";
            //        break;
            //}
            //Console.WriteLine(diaDeLaSemana);
            //Console.Read();
            //#endregion

            //#region Ejercicio12

            //Console.WriteLine("Ingrese un numero del 1 al 1000");
            //int num = int.Parse(Console.ReadLine());

            //if (num >= 1 && num <= 1000)
            //{
            //    int suma = 0;

            //    for (int i = 1; i <= num; i++)
            //    {
            //        suma += i;
            //    }
            //    Console.WriteLine("El resultado es: " + suma);
            //}
            //else
            //{
            //    Console.WriteLine("El numero ingresado no esta en el rango requerido");
            //}
            //Console.Read();
            //#endregion

            //#region Ejercicio13

            //Console.WriteLine("Ingrese un numero que sea mayor a cero");
            //int num = int.Parse(Console.ReadLine());

            //bool numPrimo = true;
            //int i = 2;

            //if (num <= 1)
            //{
            //    numPrimo = false;
            //}
            //else
            //{
            //    while (i <= Math.Sqrt(num))
            //    {
            //        if (num % i == 0)
            //        {
            //            numPrimo = false;
            //        }
            //        i++;
            //    }
            //}

            //if (numPrimo)
            //{
            //    Console.WriteLine("Es un numero primo");
            //}
            //else
            //{
            //    Console.WriteLine("No es un numero primo");
            //}
            //Console.Read();

            //#endregion

            //#region Ejercicio14

            //Console.WriteLine("Ingrese un numero entero que sea positivo");
            //int num = int.Parse(Console.ReadLine());

            //int numCifras = 0;

            //if (num > 0)
            //{
            //    while (num > 0)
            //    {
            //        num /= 10;
            //        numCifras++;
            //    }

            //    Console.WriteLine("El siguiente numero tiene estas cantidad de cifras: " + numCifras);
            //}
            //else
            //{
            //    Console.WriteLine("El digito que ingreso no es valido, intente de nuevo!!");
            //}
            //Console.Read();
            //#endregion
        }
    }
}
