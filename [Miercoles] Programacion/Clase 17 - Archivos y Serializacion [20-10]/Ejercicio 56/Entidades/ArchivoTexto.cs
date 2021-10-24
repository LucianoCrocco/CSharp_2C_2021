using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class ArchivoTexto : IArchivo<string>
    {
        public string RutaDeArchivo 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public bool Guardar(string dato, string path)
        {
            bool retorno = false;
            if (!String.IsNullOrWhiteSpace(path)){
                try
                {
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(dato, true);
                    sw.Close();
                    retorno = true;
                }
                catch (Exception)
                {
                    throw;
                }

            } else
            {
                throw new Exception("El PATH ingresado esta vacio!");
            }
            return retorno;
        }

        public string Leer(string path)
        {
            string retorno = "";
            if (!String.IsNullOrWhiteSpace(path))
            {
                try
                {
                    StreamReader sw = new StreamReader(path);
                    retorno = sw.ReadToEnd();
                    sw.Close();
                }
                catch (FileNotFoundException)
                {
                    throw new FileNotFoundException("No se encontro el archivo");
                }
                catch (DirectoryNotFoundException)
                {
                    throw new DirectoryNotFoundException("No se encontro la ruta del archivo");
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                throw new Exception("El PATH ingresado esta vacio!");
            }
            return retorno;
        }
    }
}
