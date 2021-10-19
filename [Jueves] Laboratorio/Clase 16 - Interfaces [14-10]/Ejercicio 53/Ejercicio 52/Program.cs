using System;
using Entidades;

namespace Ejercicio_52
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);


            Console.WriteLine("----------TESTING EJERCICIO 52----------");

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);
            Console.ReadKey();



            Cartuchera2<Boligrafo, Lapiz> cartuchera2 = new Cartuchera2<Boligrafo, Lapiz>();
            cartuchera2 += miBoligrafo;
            cartuchera2 += miLapiz;
            Lapiz lapiz1 = new Lapiz(0);

            Console.WriteLine("\n----------TESTING EJERCICIO 53----------");
            Console.WriteLine("\nSe pudo utilizar la tinta de los boligrafos y lapiz en la cartuchera?: " + (cartuchera2.ProbarElementos()? "SI" : "NO" ));
            Console.WriteLine("\n\tAgregando un elemento para que de false");
            cartuchera2 += lapiz1;
            Console.WriteLine("\nSe pudo utilizar la tinta de los boligrafos y lapiz en la cartuchera?: " + (cartuchera2.ProbarElementos() ? "SI" : "NO"));
        }
    }
}
