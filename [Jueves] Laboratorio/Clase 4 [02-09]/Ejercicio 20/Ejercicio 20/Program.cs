using System;

using Billetes;
namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";

            Euro euro = 10;
            Peso peso = (Peso)euro;
            Peso peso2 = 600;
            Dolar dolar = 100; //Conversion Implicita, comentar el codigo para ver la diferencia.
            Peso peso3 = (Peso)dolar;

            Console.WriteLine(peso.GetCantidad());
            Console.WriteLine(euro.GetCantidad());
            Console.WriteLine(peso == peso2);
            Console.WriteLine(peso == euro);
            Console.WriteLine(peso != euro);
            Console.WriteLine(euro != peso);
            Console.WriteLine(dolar.GetCantidad());
            Console.WriteLine(peso3 == dolar);
            Console.WriteLine(peso3 != dolar);
        }
    }
}
