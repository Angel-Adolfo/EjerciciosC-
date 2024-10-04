using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProyectoSemana5
{

    [Serializable]
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Vidas { get; set; }
        public int Reinicios { get; set; }

        public void GuardarProgreso(string rutaArchivo)
        {
            try
            {
                // Serializa el jugador y guarda en el archivo
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, this); // this hace referencia a la instancia actual del jugador
                }
                Console.WriteLine("Progreso guardado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el progreso: {ex.Message}");
            }
        }

        public static Jugador CargarProgreso(string nombreJugador)
        {
            try
            {
                string ruta = $"{nombreJugador}.bin"; 
                if (!File.Exists(ruta))
                {
                    Console.WriteLine("No se encontró el archivo del jugador.");
                    return null;
                }

                using (FileStream fs = new FileStream(ruta, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (Jugador)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("errores.log", $"{DateTime.Now}: {ex.Message}\n");
                Console.WriteLine("Error al cargar el progreso.");
                return null;
            }
        }
    }
}
