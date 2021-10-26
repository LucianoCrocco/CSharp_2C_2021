using System;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Entidades
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona() { }//Constructor por defecto para no tener el InvalidOperationException en XML

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        #endregion

        #region Metodos
        public static void Guardar(string path, Persona p)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                xmlSerializer.Serialize(writer, p);
                writer.Close();
            }
            catch
            {
                throw;
            }
        }
        public static Persona Leer(string path)
        {
            Persona persona;
            try
            {
                using (XmlTextReader read = new XmlTextReader(path))
                {
                    XmlSerializer xmlDeserializer = new XmlSerializer(typeof(Persona));
                    persona = (Persona)xmlDeserializer.Deserialize(read);
                }
            }
            catch
            {
                throw;
            }
            return persona;
        }

        public static void GuardarBinario(string path, Persona p)
        {
            try
            {
                Stream FileStream = new FileStream(path, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(FileStream, p);
                FileStream.Close();
            }
            catch
            {
                throw;
            }
        }
        public static Persona LeerBinario(string path)
        {
            Persona persona;
            try
            {
                Stream FileStream = new FileStream(path, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                persona = (Persona)formatter.Deserialize(FileStream);
                FileStream.Close();
            }
            catch
            {
                throw;
            }
            return persona;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);

            return sb.ToString();
        }
        #endregion
    }
}
