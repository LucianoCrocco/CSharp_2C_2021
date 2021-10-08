using System;
using Entidades;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 23";

            NumeroBinario b1 = "1";
            NumeroDecimal d1 = 1;
            NumeroBinario b2 = "101";
            NumeroDecimal d2 = 9;

            Console.WriteLine(((NumeroBinario)d2).GetBinario());
            Console.WriteLine(((NumeroDecimal)b2).GetNumeroDecimal());

            Console.WriteLine(d1 == b1);
            Console.WriteLine(d2 == b2);
            d2 += b1;
            Console.WriteLine(d2.GetNumeroDecimal());
            b1 -= d1;
            Console.WriteLine(b1.GetBinario());

            Console.WriteLine(d1.GetNumeroDecimal());
            Console.WriteLine(b2.GetBinario());

        }
    }
}
