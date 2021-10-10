using System;
using Entidades;
namespace Ejercicio_72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 72";
            double cantidadDeDigitos;
            double numero = 10;
            string ingreso = "";

            Console.Write("Ingrese un numero para calcular la cantidad de digitos: ");
            ingreso = Console.ReadLine();
            double.TryParse(ingreso, out numero);

            cantidadDeDigitos = numero.CantidadDeDigitos();

            Console.WriteLine($"El numero: {numero} tiene un total de: {cantidadDeDigitos} digitos");
        }
    }
}
