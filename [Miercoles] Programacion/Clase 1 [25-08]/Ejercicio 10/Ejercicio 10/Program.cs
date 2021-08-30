using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";

            string ingreso;
            int altura;
            char caracter = '*';
            int acumulador = 1;

            Console.Write("Ingrese la altura de la piramide a imprimir (La altura debe ser mayor a 0): ");
            ingreso = Console.ReadLine();

            while (int.TryParse(ingreso, out altura) == false || altura < 1)
            {
                Console.Write("ERROR... Ingrese solo numeros que sean mayores a 0: ");
                ingreso = Console.ReadLine();
            }

            for (int i = 0; i < altura; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{caracter}");
                }
                else
                {
                    acumulador += 2;
                    for (int j = 0; j < acumulador; j++)
                    {
                        if (j == 0 && i != 0)
                        {
                            Console.Write("\n");
                        }
                        Console.Write($"{caracter}");
                    }
                }
            }
        }
    }
}
