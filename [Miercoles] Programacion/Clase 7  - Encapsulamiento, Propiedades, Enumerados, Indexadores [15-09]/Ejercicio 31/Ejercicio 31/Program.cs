using System;
using Entidades;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 31";
            Cliente c1 = new Cliente("Pedro", 1);
            Cliente c2 = new Cliente("Juan", 2);
            Cliente c3 = new Cliente("Jose", 3);
            Cliente c4 = new Cliente("Pedro", 1);
            Negocio negocio = new Negocio("Farmacia Dr. Oga");

            //Comparacion de clientes
            Console.WriteLine("\tComparacion de clientes");
            Console.WriteLine(c1 == c4);
            Console.WriteLine(c2 == c3);

            //Agrego clientes al negocio
            Console.WriteLine("\tAgrego clientes al negocio");
            Console.WriteLine(negocio + c1);
            Console.WriteLine(negocio + c2);
            Console.WriteLine(negocio + c3);
            Console.WriteLine(negocio + c4);
            //Verifico que existan esos clientes en la cola
            Console.WriteLine("\tVerifico que existan esos clientes en la cola");
            Cliente c5 = new Cliente("Rigoberto", 5);
            Console.WriteLine(negocio == c1);
            Console.WriteLine(negocio == c2);
            Console.WriteLine(negocio == c3);
            Console.WriteLine(negocio == c4);
            Console.WriteLine(negocio == c5);

            Console.WriteLine("\tAtiendo clientes");
            Console.WriteLine(~negocio);
            Console.WriteLine(~negocio);

            Console.WriteLine("\tVerifico clientes restantes en la cola");
            Console.WriteLine(negocio == c1);
            Console.WriteLine(negocio == c2);
            Console.WriteLine(negocio == c3);
        }
    }
}
