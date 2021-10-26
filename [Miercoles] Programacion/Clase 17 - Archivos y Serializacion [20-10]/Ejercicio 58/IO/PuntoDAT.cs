using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace IO
{
    [Serializable]
    public class PuntoDAT : Archivo, IArchivos<PuntoDAT>
    {
        private string contenido;

        public PuntoDAT() { }

        public PuntoDAT(string contenido)
        {
            this.Contenido = contenido;
        }

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try
            {
                if(base.ValidarArchivo(ruta, validaExistencia))
                {
                    if(Path.GetExtension(ruta) == ".dat")
                    {
                        return true;
                    } else
                    {
                        throw new ArchivoIncorrectoException("El archivo seleccionado no tiene extension .dat");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            return false;
        }

        public bool Guardar(string ruta, PuntoDAT objeto)
        {
            if (this.ValidarArchivo(ruta, true))
            {
                using (FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fileStream, objeto);
                }
            } else
            {
                return false;
            }
            return true;
        }

        public bool GuardarComo(string ruta, PuntoDAT objeto)
        {
            return this.Guardar(ruta, objeto);
        }

        public PuntoDAT Leer(string ruta)
        {
            PuntoDAT item = null;
            if (this.ValidarArchivo(ruta, true))
            {
                using (FileStream fileStream = new FileStream(ruta, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    item = (PuntoDAT)bf.Deserialize(fileStream);
                }
            }

            return item;
        }
    }
}
