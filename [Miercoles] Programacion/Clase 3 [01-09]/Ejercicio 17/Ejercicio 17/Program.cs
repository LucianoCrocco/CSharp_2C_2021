using System;

using BibliotecaBoligrafo;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);
            string dibujo;
            short cantidadDeTinta;

            if (boligrafoRojo.Pintar(100, out dibujo) == false)
            {
                Console.WriteLine("Tinta roja insuficiente");
            }
            else
            {
                Console.WriteLine("Tinta roja suficiente");
            }
            cantidadDeTinta = boligrafoRojo.GetTinta();
            Console.ForegroundColor = boligrafoRojo.GetColor();
            Console.WriteLine(dibujo);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Cantidad de tinta Roja restante: {cantidadDeTinta}");

            if(boligrafoAzul.Pintar(99, out dibujo) == false)
            {
                Console.WriteLine("Tinta azul insuficiente");
            } else
            {
                Console.WriteLine("Tinta azul suficiente");
            }
            cantidadDeTinta = boligrafoRojo.GetTinta();
            Console.ForegroundColor = boligrafoAzul.GetColor();
            Console.WriteLine(dibujo);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Cantidad de tinta Azul restante: {cantidadDeTinta}");

            Console.Write("\nRecargo de tinta Azul: ");
            boligrafoAzul.Recargar();
            cantidadDeTinta = boligrafoAzul.GetTinta();
            Console.WriteLine(cantidadDeTinta);

            Console.Write("\nRecargo de tinta Roja: ");
            boligrafoRojo.Recargar();
            cantidadDeTinta = boligrafoRojo.GetTinta();
            Console.WriteLine(cantidadDeTinta);
        }
    }
}
