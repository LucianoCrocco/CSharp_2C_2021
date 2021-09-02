using System;

using ClassLibrary1;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            int cantidad = 10;
            int numeroIngresado;
            int min = -100;
            int max = 100;
            int minimoIngresado = 0;
            int maximoIngresado = 0;
            int acumulador = 0;
            int promedio = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese un numero dentro del rango permitido -> MINIMO: {min} MAXIMO: {max}: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out numeroIngresado) == false)
                {
                    Console.Write($"ERORR... Ingrese un NUMERO dentro del rango permitido -> MINIMO: {min} MAXIMO: {max}: ");
                    ingreso = Console.ReadLine();
                }

                if (Validacion.Validar(numeroIngresado, min, max) == false)
                {
                    Console.WriteLine($"El numero ingresado {numeroIngresado} se encuentra fuera del rango -> MINIMO: {min} MAXIMO: {max}\n");
                }
                else
                {
                    Console.WriteLine($"El numero ingresado {numeroIngresado} se encuentra DENTRO del rango\n");
                }

                if (i == 0)
                {
                    minimoIngresado = numeroIngresado;
                    maximoIngresado = numeroIngresado;
                }
                else
                {
                    if (minimoIngresado > numeroIngresado)
                    {
                        minimoIngresado = numeroIngresado;
                    }
                    else if (maximoIngresado < numeroIngresado)
                    {
                        maximoIngresado = numeroIngresado;
                    }
                }
                acumulador += numeroIngresado;

            }
            promedio = acumulador / cantidad;
            Console.Write($"El maximo ingresado fue: {maximoIngresado}, el minimo: {minimoIngresado} y el promedio {promedio}");
            Console.ReadKey();
        }
    }
}
