using System;
using Entidades;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Luciano", "Crocco");
            Persona personaLeer;

            Console.WriteLine("\tREGION XML\n");

            #region XML serializacion
            try
            {
                Persona.Guardar("", persona);
                Console.WriteLine("Guardado correctamente.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }

            try
            {
                Persona.Guardar($"{Environment.CurrentDirectory}\\Serializacion.XML", persona);
                Console.WriteLine("Guardado correctamente.");
            }
            catch (InvalidOperationException ex)//Construyo un constructor por defecto para que no rompa.
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                personaLeer = Persona.Leer("");
                Console.WriteLine("Leido correctamente.");
                Console.Write(personaLeer.ToString());//Para que muestre corretamente una persona en XML DEBO tener propiedades publicas
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                personaLeer = Persona.Leer($"{Environment.CurrentDirectory}\\Serializacion.XML");
                Console.WriteLine("Leido correctamente.");
                Console.Write(personaLeer.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            Console.WriteLine("\t\n\nREGION BINARIO\n");

            #region Binario Serializacion
            try
            {
                Persona.GuardarBinario("", persona);
                Console.WriteLine("Guardado correctamente.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Persona.GuardarBinario($"{Environment.CurrentDirectory}\\Serializacion.dat", persona);
                Console.WriteLine("Guardado correctamente.");
            }
            catch (System.Runtime.Serialization.SerializationException ex)//Para que esto no suceda debo ponerle [Serializable] a la cabecera de la clase a serializar
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                personaLeer = Persona.LeerBinario("");
                Console.WriteLine("Leido correctamente.");
                Console.Write(personaLeer.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                personaLeer = Persona.LeerBinario($"{Environment.CurrentDirectory}\\Serializacion.dat");
                Console.WriteLine("Leido correctamente.");
                Console.Write(personaLeer.ToString());//Vincula/lee atributos y propiedades tanto publicas como privadas.
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion


        }
    }
}
