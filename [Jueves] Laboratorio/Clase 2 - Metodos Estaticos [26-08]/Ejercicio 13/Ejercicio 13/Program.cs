using System;

using Entidades;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";
            Console.WriteLine(Conversor.DecimalBinario(7));
            Console.WriteLine(Conversor.BinarioDecimal("10001"));
        }
    }
}
