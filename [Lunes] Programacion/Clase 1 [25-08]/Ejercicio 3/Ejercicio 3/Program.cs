using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string ingreso;
            int contador = 0;
            Console.Title = "Ejercicio 3";
            do
            {
                Console.Write("Ingrese un numero MAYOR a 0 para mostrar TODOS los numeros primos hasta ese numero: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out numero) == false)
                {
                    Console.Write("ERROR... INGRESE SOLO NUMEROS! -> Ingrese un numero MAYOR a 0 para mostrar TODOS los numeros primos hasta ese numero: ");
                    ingreso = Console.ReadLine();
                }
            } while (numero < 1);

            for(int i = 1; i <= numero; i++)
            {
                contador = 0;

                for(int j = 1; j <= i; j++){
                    if(i % j == 0)
                    {
                        contador++;
                    }
                }
                if(contador == 2)
                {
                    Console.Write($"{i} es primo\n");
                }
            }   
            
        }
    }
}
