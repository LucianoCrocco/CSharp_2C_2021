using System;
using System.Collections.Generic;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadDeNumeros = 20;
            int numero;
            int[] numerosEnteros = new int[cantidadDeNumeros];
            Random random = new Random();

            for(int i = 0; i <cantidadDeNumeros; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine($"\t\tNUMEROS INGRESADOS");
                }
                numero = random.Next(int.MinValue, int.MaxValue);
                while(numero == 0)
                {
                    numero = random.Next(int.MinValue, int.MaxValue);
                }
                numerosEnteros[i] = numero;
                Console.WriteLine($"VECTOR {i} | NUMERO {numerosEnteros[i]}");
            }

            for(int i = 0; i < cantidadDeNumeros -1; i++)
            {
                int aux;
                for(int j = i+1;j < cantidadDeNumeros; j++)
                {
                    if(numerosEnteros[i] < numerosEnteros[j])
                    {
                        aux = numerosEnteros[i];
                        numerosEnteros[i] = numerosEnteros[j];
                        numerosEnteros[j] = aux;
                    }
                }
            }
            Console.WriteLine("\nORDENADO SOLO LOS POSITIVOS DE FORMA DECRECIENTE\n");

            foreach(int item in numerosEnteros)
            {
                if(item > 0)
                {
                    Console.WriteLine($"NUMERO {item}");
                }
            }

            Console.WriteLine("\nORDENADO SOLO LOS NEGATIVOS DE FORMA CRECIENTE\n");

            foreach (int item in numerosEnteros)
            {
                if(item < 0)
                {
                    Console.WriteLine($"NUMERO {item}");
                }
            }
        }
    }
}
