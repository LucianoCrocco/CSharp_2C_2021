using System;
using Entidades;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 30";
            AutoF1 a1 = new AutoF1(1, "Ferrari");
            AutoF1 a2 = new AutoF1(77, "Mercedes");
            AutoF1 a3 = new AutoF1(55, "Alfa Romeo");
            AutoF1 a4 = new AutoF1(22, "Williams");
            AutoF1 a5 = new AutoF1(23, "Haas");
            AutoF1 a6 = new AutoF1(99, "McLaren");
            Competencia competencia = new Competencia(50, 5);

            Console.WriteLine(competencia + a1);
            Console.WriteLine(competencia + a2);
            Console.WriteLine(competencia + a3);
            Console.WriteLine(competencia + a1);
            Console.WriteLine(competencia + a4);
            Console.WriteLine(competencia + a5);
            Console.WriteLine(competencia + a6);

            Console.WriteLine(competencia.MostrarDatos());
            Console.WriteLine(a1.MostrarDatos());
            Console.WriteLine(a2.MostrarDatos());
            Console.WriteLine(a3.MostrarDatos());
            Console.WriteLine(a4.MostrarDatos());
            Console.WriteLine(a5.MostrarDatos());
            Console.WriteLine(a6.MostrarDatos());


        }
    }
}
