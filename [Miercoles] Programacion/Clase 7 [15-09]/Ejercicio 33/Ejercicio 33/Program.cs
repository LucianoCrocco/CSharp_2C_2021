using System;
using Entidades;
namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[0] = "Hola";
            Console.WriteLine(libro[0]);
            libro[1] = "Mundo";
            Console.WriteLine(libro[1]);
            libro[0] = "Chau";
            Console.WriteLine(libro[0]);

            Console.WriteLine("----------------------");


            Console.WriteLine(libro[2]);
            Console.WriteLine(libro[3]);
            Console.WriteLine(libro[4]);


        }
    }
}
