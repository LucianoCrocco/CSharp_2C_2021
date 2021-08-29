using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;
            int numero = 1;
            Console.Title = "Ejercicio 4";
            do
            {
                for(int i = 1; i < numero; i++)
                {
                    if((numero % i) == 0)
                    {
                        acumulador += i;
                    }
                }

                if (acumulador == numero)
                {
                    Console.WriteLine("Numero perfecto: {0}", numero);
                    Console.WriteLine($"Cosole Write con el signo pesos -> Numero perfecto: {numero}");
                    contador++;
                }
                numero++;
                acumulador = 0;

            } while (contador < 4);
        }
    }
}
