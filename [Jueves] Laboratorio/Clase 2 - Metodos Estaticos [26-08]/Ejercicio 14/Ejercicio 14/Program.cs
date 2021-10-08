using System;

using BibliotecaClases;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            Console.WriteLine("Datos hardcodeados: Base-> 4, Altura -> 6, Radio -> 5");
            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;

            areaCuadrado = CalculoDeArea.CalcularCuadrado(4);
            areaTriangulo = CalculoDeArea.CalcularTriangulo(4, 6);
            areaCirculo = CalculoDeArea.CalcularCirculo(5);
            areaCirculo = Math.Round(areaCirculo, 2);
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write($"Area Cuadrado: {areaCuadrado}, Area Triangulo {areaTriangulo}, Area Circulo {areaCirculo}");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
