using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTXT : Archivo, IArchivos<string>
    {

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".txt")
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo seleccionado no tiene extension .txt");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            return false;
        }

        public bool Guardar(string ruta, string objeto)
        {
            if (this.ValidarArchivo(ruta, true))
            {
                using (StreamWriter sw = File.AppendText(ruta))
                {
                    sw.WriteLine(objeto);
                }
                return true;
            }
            return false;
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            return this.Guardar(ruta, objeto);
        }

        public string Leer(string ruta)
        {
            string retorno = "";
            if (this.ValidarArchivo(ruta, true))
            {
                using (StreamReader reader = new StreamReader(ruta))
                {
                    retorno = reader.ReadToEnd();
                }
            }

            return retorno;
        }
    }
}
