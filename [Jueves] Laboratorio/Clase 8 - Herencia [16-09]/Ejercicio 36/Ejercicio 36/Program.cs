using System;
using Entidades;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 36";
            AutoF1 a1 = new AutoF1(1, "Ferrari",100);
            AutoF1 a2 = new AutoF1(77, "Mercedes", 120);
            AutoF1 a3 = new AutoF1(55, "Alfa Romeo", 100);
            AutoF1 a4 = new AutoF1(22, "Williams", 120);
            AutoF1 a5 = new AutoF1(23, "Haas", 100);
            AutoF1 a6 = new AutoF1(99, "McLaren", 120);
            MotoCross m1 = new MotoCross(77, "Monster", 150);
            Competencia competencia = new Competencia(50, 5, Competencia.TipoCompetencia.F1);
            Competencia competenciaMotoCross = new Competencia(40, 5, Competencia.TipoCompetencia.MotoCross);

            Console.WriteLine(competencia + a1);
            Console.WriteLine(competencia + a2);
            Console.WriteLine(competencia + a3);
            Console.WriteLine(competencia + a1);
            Console.WriteLine(competencia + a4);
            Console.WriteLine(competencia + a5);
            Console.WriteLine(competencia + a6);

            Console.WriteLine(competenciaMotoCross + m1);
            Console.WriteLine(competenciaMotoCross + m1);
            Console.WriteLine(competenciaMotoCross + a1);
            Console.WriteLine(competenciaMotoCross == a1);
            Console.WriteLine(competenciaMotoCross == m1);
            Console.WriteLine(m1.MostrarDatos());

            Console.WriteLine(competencia.MostrarDatos());
            Console.WriteLine(competenciaMotoCross.MostrarDatos());
            //Console.WriteLine(a1.MostrarDatos());
            //Console.WriteLine(a2.MostrarDatos());
            //Console.WriteLine(a3.MostrarDatos());
            //Console.WriteLine(a4.MostrarDatos());
            //Console.WriteLine(a5.MostrarDatos());
            //Console.WriteLine(a6.MostrarDatos());


        }
    }
}
