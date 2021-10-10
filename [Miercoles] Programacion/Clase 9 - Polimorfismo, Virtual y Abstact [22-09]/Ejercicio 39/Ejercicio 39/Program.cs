using System;
using Entidades;

namespace Ejercicio_39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº39";

            Sobrescrito sobrecarga = new SobreSobrescrito();
            Sobrescrito sobreSobrecarga = new SobreSobrescrito();

            Console.WriteLine(sobrecarga.ToString());
            string objeto = "¡Este es mi método ToString sobrescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");

            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.ReadKey();

            Console.WriteLine("**********************************************");

            Console.WriteLine(sobreSobrecarga.ToString());
            string objeto2 = "¡Este es mi método ToString sobreSobrescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación SobreSobrecargas con String: ");

            Console.WriteLine(sobreSobrecarga.Equals(objeto2));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobreSobrecarga.GetHashCode());
            Console.ReadKey();
        }
    }
}
