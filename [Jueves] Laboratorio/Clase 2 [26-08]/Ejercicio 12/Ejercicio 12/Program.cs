using System;

using BibliotecaClases;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir = 'S';
            string ingreso;
            int numeroIngresado;
            int acumulador = 0;
            do
            {
                Console.Write("Ingrese un numero: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out numeroIngresado) == false)
                {
                    Console.Write("Error... Ingrese un NUMERO: ");
                    ingreso = Console.ReadLine();
                }
                acumulador += numeroIngresado;

                Console.Write("Si desea seguir ingresando numeros presione 'S', de lo contrario ingrese cualquier otra tecla: ");
                ingreso = Console.ReadLine();
                while (char.TryParse(ingreso, out seguir) == false)
                {
                    Console.Write("Error, ingrese solo UN CARACTER... Si desea seguir ingresando numeros presione 'S', de lo contrario ingrese cualquier otra tecla: ");
                    ingreso = Console.ReadLine();
                }


            } while (BibliotecaClases.ValidarRespuesta.ValidarS_N(seguir));
            Console.Write($"La suma de todos los numeros ingresados es: {acumulador}");
            Console.ReadKey();
        }
    }
}
