﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int minimoIngresado;
            int maximoIngresado;
            int promedio;

            for(int i = 0; i < cantidad; i++)
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
                }  else
                {
                    Console.WriteLine($"El numero ingresado {numeroIngresado} se encuentra DENTRO del rango\n");
                }
            }
        }   
    }
}
