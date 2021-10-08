using System;
using Entidades;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(10);
            Sumador s2 = new Sumador(10);
            Sumador s3 = new Sumador();

            Console.WriteLine(s1 | s2);
            Console.WriteLine(s1 + s2);

            Console.WriteLine(s3.Sumar((int)s1, 30));
            Console.WriteLine(s1 | s3);
            Console.WriteLine(s1 + s3);

            Console.WriteLine(s1.Sumar("Hola", " Mundo"));
            Console.WriteLine(s2.Sumar("Hola", " Chicos"));
            Console.WriteLine(s3.Sumar((int)s1, (int)s2));
            Console.WriteLine(s2.Sumar((int)s1, (int)s2, (int)s3));
        }
    }
}
