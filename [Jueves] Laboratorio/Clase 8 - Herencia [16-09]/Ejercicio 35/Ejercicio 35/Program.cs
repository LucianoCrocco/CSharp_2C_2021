using System;
using Entidades;
namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 35";
            Jugador j1 = new Jugador(100, "Jose");
            Jugador j2 = new Jugador(100, "Jose");
            Jugador j3 = new Jugador(101, "Pedro", 1, 10);
            Jugador j4 = new Jugador(102, "Juanlo", 3000000, 1200);
            Jugador j5 = new Jugador(103, "Maradona", 200, 300);
            Jugador j6 = new Jugador(104, "Messi", 300, 150);
            Jugador j7 = new Jugador(105, "Ortigoza", 5, 303);


            Equipo equipo = new Equipo(6, "Los mejores");


            Console.Write("Se pudo agregar? -> ");
            Console.WriteLine(equipo + j1);
            Console.WriteLine(j1.mostrarDatos());


            Console.Write("Se pudo agregar? -> ");
            Console.WriteLine(equipo + j2);
            Console.WriteLine(j2.mostrarDatos());


            Console.Write("Se pudo agregar? -> ");
            Console.WriteLine(equipo + j3);
            Console.WriteLine(j3.mostrarDatos());


            Console.Write("Se pudo agregar? -> ");
            Console.WriteLine(equipo + j4);
            Console.WriteLine(j4.mostrarDatos());


            Console.Write("Se pudo agregar? -> ");
            Console.WriteLine(equipo + j5);
            Console.WriteLine(j5.mostrarDatos());


            Console.Write("Se pudo agregar? -> ");
            Console.WriteLine(equipo + j6);
            Console.WriteLine(j6.mostrarDatos());


            Console.Write("Se pudo agregar? -> ");
            Console.WriteLine(equipo + j7);
            Console.WriteLine(j7.mostrarDatos());

        }
    }
}
