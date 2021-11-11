using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class GestorDeArchivos : IGuardar<Carrera>, IGuardar<AutoF1>
    {
        protected string archivo;
        public GestorDeArchivos(string ruta)
        {
            this.archivo = ruta;
        }

        public void Guardar(Carrera tipo)
        {

            XmlSerializer serializador = new XmlSerializer(typeof(Carrera));
            XmlTextWriter escribirObjeto = new XmlTextWriter(this.archivo, Encoding.UTF8);
            try
            {
                serializador.Serialize(escribirObjeto, tipo);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                escribirObjeto.Close();
            }
        }

        void IGuardar<AutoF1>.Guardar(AutoF1 tipo)
        {
            StreamWriter sw = new StreamWriter(this.archivo);
            try 
            {
                sw.WriteLine(tipo.ToString());
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sw.Close();
            }
        }

        public Carrera LeerXML()
        {
            Carrera carrera = null;
            XmlSerializer serializador = new XmlSerializer(typeof(Carrera));
            XmlTextReader leerObjeto = new XmlTextReader(this.archivo);
            if (Path.GetExtension(archivo) == ".xml")
            {
                try
                {
                    carrera = (Carrera)serializador.Deserialize(leerObjeto);
                }
                catch (Exception ex)
                {
                    throw new ArchivoException("No se pudo leer el archivo", ex);
                }
                finally
                {
                    leerObjeto.Close();
                }
            }
            return carrera;
        }
    }
}
