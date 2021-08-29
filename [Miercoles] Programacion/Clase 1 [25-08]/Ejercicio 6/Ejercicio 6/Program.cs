using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio 6";
            string ingreso;
            int anioInicio;
            int anioFin;
            int anio;

            Console.Write("Ingrese un inicio de año para un rango de años biestos: ");
            ingreso = Console.ReadLine();
            while(int.TryParse(ingreso,out anioInicio) == false)
            {
                Console.Write("Error... Ingrese un inicio de año para un rango de años biestos: ");
                ingreso = Console.ReadLine();
            }

            Console.Write("Ingrese un fin de año para un rango de años biestos: ");
            ingreso = Console.ReadLine();
            while (int.TryParse(ingreso, out anioFin) == false)
            {
                Console.Write("Error... Ingrese un fin de año para un rango de años biestos: ");
                ingreso = Console.ReadLine();
            }

            for(int i = anioInicio; i <= anioFin; i++)
            {
                anio = i;
                if ( anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0) {
                    Console.Write($"\tEl año {anio} es bisiesto\n");
                } else
                {
                    Console.Write($"El año {anio} NO es bisiesto\n");
                }
            }

        }
    }
}
