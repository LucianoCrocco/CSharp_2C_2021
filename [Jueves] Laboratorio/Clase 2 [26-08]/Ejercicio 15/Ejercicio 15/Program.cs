using System;

using Entidades;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";

            int numero;
            int numero2;
            char operador;
            string ingreso;
            double resultado;

            Console.Write("Ingrese el primer numero: ");
            ingreso = Console.ReadLine();
            while (int.TryParse(ingreso, out numero) == false)
            {
                Console.Write("Error... Ingrese un NUMERO: ");
                ingreso = Console.ReadLine();
            }

            Console.Write("Ingrese el segundo numero: ");
            ingreso = Console.ReadLine();
            while (int.TryParse(ingreso, out numero2) == false)
            {
                Console.Write("Error... Ingrese un NUMERO: ");
                ingreso = Console.ReadLine();
            }


            Console.Write("Ingrese el operador, de ingresar un caracter invalido se utilizara automaticamente el '+': ");
            ingreso = Console.ReadLine();
            while (char.TryParse(ingreso, out operador) == false)
            {
                Console.Write("Error... Ingrese un OPERADOR: ");
                ingreso = Console.ReadLine();
            }


            resultado = Calculadora.Operar(numero, numero2, operador);
            Console.Write($"\n\nEl resultado de la operacion es: {resultado}");

        }
    }
}
