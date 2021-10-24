using System;
using Entidades;
using IO;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 42 
            /*try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.Metodo();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);

                Exception e = ex.InnerException;

                while (e is not null)
                {
                    Console.WriteLine(e.Message);
                    e = e.InnerException;
                }

            }*/
            #endregion

            #region Ejercicio 52
            string filePath = $"{Environment.CurrentDirectory}\\Logs\\{DateTime.Today.Year}{DateTime.Today.Month}{DateTime.Today.Day}-{DateTime.Now.Hour}{DateTime.Now.Minute}.txt";
            try
            {
                ArchivosTexto.Guardar(filePath, "Pruebo mi funcion Guardar");
                Console.WriteLine("Se guardo correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            try
            {
                string lectura = ArchivosTexto.Leer(filePath);
                Console.WriteLine(lectura);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            #endregion
        }
    }
}
