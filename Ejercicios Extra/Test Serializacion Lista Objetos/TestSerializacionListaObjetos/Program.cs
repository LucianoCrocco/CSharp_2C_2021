using System;
using Entidades;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TestSerializacionListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Luciano", "Crocco", 21);
            Persona p2 = new Persona("Fernando", "Gago", 38);
            Persona p3 = new Persona("Maria", "Listorti", 55);
            Persona p4 = new Persona("Juan", "Riquelme", 44);
            Persona p5 = new Persona("Javier", "Mascherano", 41);
            List<Persona> personas = new List<Persona>() { 
                p1, p2, p3, p4, p5
            };
            ArchivoTexto archivoTexto = new ArchivoTexto();

            #region Json


            string jsonSerializacion = "";
            string jsonDeserializado = "";

            string path = $"{Environment.CurrentDirectory}\\SerializacionLista.json";


            //Para serializar en un archivo, vamos a utilizar la manera que aprendimos con Archivos.

            try
            {
                jsonSerializacion = JsonSerializer.Serialize(personas);
                archivoTexto.Guardar(jsonSerializacion, $"{Environment.CurrentDirectory}\\SerializacionListaJSON.json");
                Console.WriteLine("Gurdado correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("\n---Serializados en JSON correctamente como--- \n");
            Console.WriteLine(jsonSerializacion);


            try
            {
                jsonDeserializado = archivoTexto.Leer($"{Environment.CurrentDirectory}\\SerializacionListaJSON.json");
                Console.WriteLine("Leido correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Persona> personasDes = JsonSerializer.Deserialize<List<Persona>>(jsonDeserializado);


            Console.WriteLine("\n---Deserializado en JSON correctamente como--- \n");
            foreach (Persona persona in personasDes)
            {
                Console.WriteLine(persona.ToString());
            }

            #endregion

            #region XML
            path = $"{Environment.CurrentDirectory}\\SerializacionLista.XML";
            XmlTextWriter escribirObjeto = new XmlTextWriter(path, System.Text.Encoding.UTF8);

            XmlSerializer serializarObjeto = new XmlSerializer(typeof(List<Persona>));

            XmlTextReader leerObjeto = new XmlTextReader(path);


            try
            {
                serializarObjeto.Serialize(escribirObjeto, personas);
                escribirObjeto.Close();
                Console.WriteLine("Serializado XML correctamente como: " + escribirObjeto.ToString());
                Console.WriteLine("Gurdado correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                personas = (List<Persona>)serializarObjeto.Deserialize(leerObjeto);
                leerObjeto.Close();
                Console.WriteLine("Leido correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            personasDes.Clear();
            personasDes = JsonSerializer.Deserialize<List<Persona>>(jsonDeserializado);


            Console.WriteLine("\n---Deserializado en XML correctamente como--- \n");
            foreach (Persona persona in personasDes)
            {
                Console.WriteLine(persona.ToString());
            }

            #endregion

            #region Binario
            path = $"{Environment.CurrentDirectory}\\SerializacionLista.dat";
            Stream fileStream = new FileStream(path, FileMode.OpenOrCreate);//Create para crear,Open para abrir
            BinaryFormatter objetoASerializar = new BinaryFormatter();

            try
            {
                objetoASerializar.Serialize(fileStream, personas);
                fileStream.Close();
                Console.WriteLine("Serializado Binario correctamente como: " + objetoASerializar.ToString());
                Console.WriteLine("Gurdado correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            fileStream = new FileStream(path, FileMode.Open);
            personasDes.Clear();
            try
            {
                personasDes = (List<Persona>)objetoASerializar.Deserialize(fileStream);
                fileStream.Close();
                Console.WriteLine("Leido correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n---Deserializado en Binario correctamente como--- \n");
            foreach (Persona persona in personasDes)
            {
                Console.WriteLine(persona.ToString());
            }
            #endregion
        }
    }
}
