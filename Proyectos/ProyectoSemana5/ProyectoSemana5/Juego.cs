using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProyectoSemana5
{
    public class Juego
    {
        private Jugador jugador;
        private int nivel = 1;
        private List<string> nombresExistentes = new List<string>();

        public void MostrarMenu()
        {
            int opcion;

            Console.WriteLine("BIENVENIDO A MI JUEGO");
            do
            {
                
                Console.WriteLine("1. Comenzar juego");
                Console.WriteLine("2. Cargar progreso");
                Console.WriteLine("3. Eliminar progreso");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Jugar();
                        break;
                    case 2:
                        Cargar();
                        break;
                    case 3:
                        Eliminar();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

            } while (opcion != 4);
        }

        public void Jugar()
        {
            if (jugador == null)
            {
                Console.WriteLine("¿Cómo te llamas?");
                string nombre = Console.ReadLine();

                while (nombresExistentes.Contains(nombre))
                {
                    Console.WriteLine("Ese nombre ya existe, elige otro:");
                    nombre = Console.ReadLine();
                }

                nombresExistentes.Add(nombre);

                jugador = new Jugador { Nombre = nombre, Nivel = 1, Vidas = 3 };
            }

            while (nivel <= 10)
            {
                int vidaMonstruo = 100 + (nivel - 1) * 50;
                Console.WriteLine($"Nivel {nivel}: ¡Un monstruo ha aparecido con {vidaMonstruo} puntos de vida!");

                while (vidaMonstruo > 0 && jugador.Vidas > 0)
                {
                    Console.WriteLine($"Tienes {jugador.Vidas} vidas. Inserta el daño que quieres hacer:");
                    int daño;
                    bool esValido = int.TryParse(Console.ReadLine(), out daño);

                    if (!esValido || daño <= 0)
                    {
                        Console.WriteLine("Por favor, introduce un valor de daño positivo.");
                        continue;
                    }

                    if (daño >= vidaMonstruo)
                    {
                        Console.WriteLine("¡Has derrotado al monstruo!");
                        nivel++;
                        jugador.Nivel = nivel;

                        Console.WriteLine("¿Deseas continuar? (si/no)");
                        string respuesta = Console.ReadLine().ToLower();

                        if (respuesta != "si")
                        {
                            Console.WriteLine("Regresando al menú principal...");
                            GuardarProgresoJugador();
                            ResetearProgreso();
                            return;
                        }

                        if (nivel > 10)
                        {
                            Console.WriteLine("HAS GANADO FELICIDADES");
                            jugador.Nivel = 10;
                            GuardarProgresoJugador();
                            ResetearProgreso();
                            return;
                        }

                        jugador.Vidas = 3;
                        break;
                    }
                    else
                    {
                        vidaMonstruo -= daño;
                        jugador.Vidas--;
                        Console.WriteLine($"Te quedan {jugador.Vidas} vidas. Al monstruo le quedan {vidaMonstruo} puntos de vida.");
                    }
                }

                if (jugador.Vidas == 0)
                {
                    Console.WriteLine("Se acabó el juego. Volviendo al menú principal.");
                    ResetearProgreso();
                    break;
                }
            }
        }

        public void Cargar()
        {
            Console.WriteLine("Introduce el nombre del jugador:");
            string nombreJugador = Console.ReadLine();
            jugador = Jugador.CargarProgreso(nombreJugador);
            if (jugador != null)
            {
                if (jugador.Nivel >= 10)
                {
                    Console.WriteLine("Has completado todos los niveles.");
                    return;
                }
                else
                {
                    Console.WriteLine($"Progreso cargado: Jugador {jugador.Nombre} en nivel {jugador.Nivel}.");
                    nivel = jugador.Nivel;
                    if (!nombresExistentes.Contains(jugador.Nombre))
                    {
                        nombresExistentes.Add(jugador.Nombre);
                    }
                }
            }
        }

        public void Eliminar()
        {
            Console.WriteLine("Introduce el nombre del jugador para eliminar su progreso:");
            string nombreJugador = Console.ReadLine();
            string ruta = $"{nombreJugador}.bin";

            if (File.Exists(ruta))
            {
                try
                {
                    File.Delete(ruta);
                    Console.WriteLine("Progreso eliminado.");

                    if (nombresExistentes.Contains(nombreJugador))
                    {
                        nombresExistentes.Remove(nombreJugador);
                    }

                    if (jugador != null && jugador.Nombre == nombreJugador)
                    {
                        jugador = null;
                        nivel = 1;
                        Console.WriteLine("Progreso en memoria reseteado.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al eliminar el archivo: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Archivo no encontrado.");
            }
        }

        private void GuardarProgresoJugador()
        {
            if (jugador != null)
            {
                jugador.GuardarProgreso($"{jugador.Nombre}.bin");
            }
        }

        private void ResetearProgreso()
        {
            jugador = null;
            nivel = 1;
        }
    }
}
