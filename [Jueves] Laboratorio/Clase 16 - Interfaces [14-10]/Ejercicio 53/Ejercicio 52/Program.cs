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


            Console.WriteLine("\n----------TESTING EJERCICIO 53----------");


            Cartuchera2<Boligrafo, Lapiz> cartuchera2 = new Cartuchera2<Boligrafo, Lapiz>();
            Cartuchera1 cartuchera1 = new Cartuchera1();
            cartuchera1 += miBoligrafo;
            cartuchera1 += miLapiz;
            cartuchera2 += miBoligrafo;
            cartuchera2 += miLapiz;
            bool pruebaCartuchera1 = true;
            bool pruebaCartuchera2 = true;
            //Tuve que cambiar los Setters de UnidadesDeEscritura para que rompa el loop.


            while (pruebaCartuchera1)
            {
                pruebaCartuchera1 = cartuchera1.ProbarMetodos();
                Console.WriteLine("Se pudo probar los metodos en la cartuchera1?: " + (pruebaCartuchera1 ? "SI" : "NO"));
            }
            

            while (pruebaCartuchera2)
            {
                pruebaCartuchera2 = cartuchera2.ProbarElementos();
                Console.WriteLine("Se pudo utilizar la tinta de los boligrafos y lapiz en la cartuchera2?: " + (pruebaCartuchera2 ? "SI" : "NO"));
            }
        }
    }
}
