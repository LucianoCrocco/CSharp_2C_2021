using System;
using Entidades;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace PruebaSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Luciano", "Crocco", 21);
            ArchivoTexto archivoTexto = new ArchivoTexto();
            string path;
            Console.WriteLine(p1.ToString());
            Persona persona;

            #region Json


            path = $"{Environment.CurrentDirectory}\\Serializacion.json";
            string jsonSerializacion = JsonSerializer.Serialize(p1);
            string jsonDeserializado = "";

            //Para serializar en un archivo, vamos a utilizar la manera que aprendimos con Archivos.
            
            try
            {
                archivoTexto.Guardar(jsonSerializacion, $"{Environment.CurrentDirectory}\\SerializacionJSON.json");
                Console.WriteLine("Serializado JSON correctamente como: " + jsonSerializacion);
                Console.WriteLine("Guardado correctamente");

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                jsonDeserializado = archivoTexto.Leer($"{Environment.CurrentDirectory}\\SerializacionJSON.json");
                Console.WriteLine("Leido correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Persona persona = (Persona)JsonSerializer.Deserialize(jsonDeserializado, typeof(Persona));
            persona = JsonSerializer.Deserialize<Persona>(jsonDeserializado);

            Console.WriteLine("\n---Deserializado correctamente en JSON como--- \n" + persona.ToString());

            #endregion

            #region XML
            path = $"{Environment.CurrentDirectory}\\Serializacion.XML";
            XmlTextWriter escribirObjeto = new XmlTextWriter(path, System.Text.Encoding.UTF8);

            XmlSerializer serializarObjeto = new XmlSerializer(typeof(Persona));

            XmlTextReader leerObjeto = new XmlTextReader(path);


            try
            {
                serializarObjeto.Serialize(escribirObjeto, p1);
                escribirObjeto.Close();
                Console.WriteLine("Serializado XML correctamente como: " + escribirObjeto.ToString());
                Console.WriteLine("Guardado correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                persona = (Persona)serializarObjeto.Deserialize(leerObjeto);
                leerObjeto.Close();
                Console.WriteLine("Leido correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n---Deserializado correctamente en XML como--- \n" + persona.ToString());


            #endregion

            #region Binarios
            path = $"{Environment.CurrentDirectory}\\Serializacion.dat";
            Stream fileStream = new FileStream(path, FileMode.OpenOrCreate);//Create para crear,Open para abrir
            BinaryFormatter objetoASerializar = new BinaryFormatter();
            
            try
            {
                objetoASerializar.Serialize(fileStream, persona);
                fileStream.Close();
                Console.WriteLine("Serializado Binario correctamente como: " + objetoASerializar.ToString());
                Console.WriteLine("Guardado correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            fileStream = new FileStream(path, FileMode.Open);

            try
            {
                persona = (Persona)objetoASerializar.Deserialize(fileStream);
                fileStream.Close();
                Console.WriteLine("Leido correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n---Deserializado correctamente en Binario como--- \n" + persona.ToString());

            #endregion
        }
    }
}
