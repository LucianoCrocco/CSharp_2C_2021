using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int cantidadAIngresar = 5;
            int max = 0;
            int min = 0;
            int promedio = 0;
            int acumulador = 0;
            int numero;
            string ingreso;
            Console.Title = "Ejercicio 1";

            for(i = 0; i<cantidadAIngresar; i++)
            {
                Console.Write("Ingrese el {0}º numero: ", i + 1);
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out numero) == false)
                {
                    Console.Write("Error...! SOLO INGRESE NUMEROS -> Ingrese el {0}º numero: ", i + 1);
                    ingreso = Console.ReadLine();
                }
                acumulador += numero;

                if(i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else if( i != 0)
                {
                    if(max < numero)
                    {
                        max = numero;

                    } else if (min > numero)
                    {
                        min = numero;
                    }
                }
            }
            promedio = acumulador / cantidadAIngresar;
            Console.Write("El maximo es: {0}, el minimo; {1} y el promedio {2}", max, min, promedio);
        }
    }
}
