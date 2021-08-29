using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            int numero;
            int numeroAuxiliar = 0;
            int primerAcumulador = 0;
            int segundoAcumulador = 0;
            int i = 1;

            Console.Title = "Ejercicio 5";

            do
            {
                Console.Write("Ingrese un numero MAYOR a 0 para calcular su centro numérico: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out numero) == false)
                {
                    Console.Write("ERROR... INGRESE SOLO NUMEROS! -> Ingrese un numero MAYOR a 0 para calcular su centro numérico: ");
                    ingreso = Console.ReadLine();
                }
            } while (numero < 1);

            numeroAuxiliar = numero;
            segundoAcumulador = numero;

            while (i <= numero)
            {
                if (numeroAuxiliar != i)
                {
                    primerAcumulador += i;

                    if (primerAcumulador > segundoAcumulador)
                    {
                        numeroAuxiliar--;
                        if (numeroAuxiliar == i)
                        {
                            primerAcumulador -= i;
                            break;
                        } else
                        {
                            segundoAcumulador = segundoAcumulador + numeroAuxiliar;
                        }
                    }
                }
                i++;
            }

            if (primerAcumulador != segundoAcumulador)
            {
                Console.Write($"\tEl numero {numero} NO tiene centro numerico.\n");
                Console.Write($"SUMA DEL PRIMER ACUMULADOR {primerAcumulador}\n");
                Console.Write($"SUMA DEL SEGUNDO ACUMULADOR {segundoAcumulador}\n");
            } else
            {
                Console.Write($"\tEl centro numerico de {numero} es: {numeroAuxiliar}\n");
                Console.Write($"SUMA DEL PRIMER ACUMULADOR {primerAcumulador}\n");
                Console.Write($"SUMA DEL SEGUNDO ACUMULADOR {segundoAcumulador}\n");
            }
        }
    }
}