using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            int numero = 0;
            double cuadrado;
            double cubo;
            Console.Title = "Ejercicio 2";

            numero = 5;
            do
            {
                Console.Write("Ingrese un numero MAYOR a 0 para calcular el cuadrado y cubo del mismo: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out numero) == false)
                {
                    Console.Write("ERROR... INGRESE SOLO NUMEROS! -> Ingrese un numero MAYOR a 0 para calcular el cuadrado y cubo del mismo: ");
                    ingreso = Console.ReadLine();
                }
            } while (numero < 1);

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.Write("El numero {0} al cudrado es: {1} y al cubo es: {2}", numero, cuadrado, cubo);
        }
    }
}
