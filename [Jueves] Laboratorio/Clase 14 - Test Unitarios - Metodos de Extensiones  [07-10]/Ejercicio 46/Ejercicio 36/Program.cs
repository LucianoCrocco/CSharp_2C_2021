using System;
using Entidades;
using Excepciones;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 43";

            #region Instancias
            AutoF1 a1 = new AutoF1(1, "Ferrari",100);
            AutoF1 a2 = new AutoF1(77, "Mercedes", 120);
            AutoF1 a3 = new AutoF1(55, "Alfa Romeo", 100);
            AutoF1 a4 = new AutoF1(22, "Williams", 120);
            AutoF1 a5 = new AutoF1(23, "Haas", 100);
            AutoF1 a6 = new AutoF1(99, "McLaren", 120);
            MotoCross m1 = new MotoCross(77, "Monster", 150);
            Competencia competencia = new Competencia(50, 5, Competencia.TipoCompetencia.F1);
            Competencia competenciaMotoCross = new Competencia(40, 5, Competencia.TipoCompetencia.MotoCross);
            Competencia competenciaF1  = new Competencia(48, 6, Competencia.TipoCompetencia.F1);
            #endregion

            #region Agregar vehiculos a la competencia
            #region Testing normal
            /*
            try
            {
                if(competencia + a1)
                {
                    Console.WriteLine(a1.MostrarDatos());
                }
            } catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                if (competencia + a2)
                {
                    Console.WriteLine(a2.MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                if (competencia + a3)
                {
                    Console.WriteLine(a3.MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                if (competencia + a4)
                {
                    Console.WriteLine(a4.MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                if (competencia + a5)
                {
                    Console.WriteLine(a5.MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                if (competencia + a6)
                {
                    Console.WriteLine(a6.MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                if (competenciaMotoCross + m1)
                {
                    Console.WriteLine(m1.MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\n-------Testing comun hecho hasta ahora sin excepciones-------\n\n\n");
            Console.ReadKey();
            Console.Clear();
            */
            #endregion


            Console.WriteLine("\n-------Agrego un Motocross a una competencia de F1-------");
            try
            {
                if (competenciaF1 + m1)
                {
                    Console.WriteLine(m1.MostrarDatos());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            #endregion

            //Console.WriteLine(competencia.MostrarDatos());
            //Console.WriteLine(competenciaMotoCross.MostrarDatos());


        }
    }
}
