using System;
using Entidades;

namespace Ejercicio_73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 73";
            string ingreso = "";
            double cantidadDeSignosDePuntuacion;


            Console.Write("Ingrese un string para calcular la cantidad de \",\", \".\" y \";\": ");
            ingreso = Console.ReadLine();

            cantidadDeSignosDePuntuacion = ingreso.ContadorDeSignosDePuntuacion();
            Console.Write($"La cantidad de signos de puntuacion fue de: {cantidadDeSignosDePuntuacion}");

        }
    }
}
