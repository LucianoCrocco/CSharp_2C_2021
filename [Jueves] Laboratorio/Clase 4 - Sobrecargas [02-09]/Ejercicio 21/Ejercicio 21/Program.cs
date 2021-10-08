using System;

using Temperatura;
namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Kelvin k1 = 326;// Reserva de memoria implicita
            Celsius c1 = new Celsius(10); // Utilizo mi constructor y utilizo el new para reservar memoria
            Fahrenheit f1 = 127.13;

            Console.WriteLine(k1 == f1);
            Console.WriteLine(k1 != f1);
            Console.WriteLine(k1 == c1);
            Console.WriteLine(c1 == f1);
            Console.WriteLine(f1.GetTemperatura());
            Console.WriteLine(((Kelvin)f1).GetTemperatura());
        }
    }
}
