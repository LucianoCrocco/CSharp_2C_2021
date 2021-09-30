using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hola.nombre);
            Console.WriteLine(Hola.edad);
        }
    }
}


static class Hola{
    public static int edad;
    public static string nombre;

    static Hola() {
        Hola.edad = 21;
        Hola.nombre = "Luciano";
    }

}