using System;
using Entidades;
using Excepciones;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 49";

            #region Instancias
            AutoF1 a1 = new AutoF1(1, "Ferrari",100);
            AutoF1 a2 = new AutoF1(77, "Mercedes", 120);
            AutoF1 a3 = new AutoF1(55, "Alfa Romeo", 100);
            AutoF1 a4 = new AutoF1(22, "Williams", 120);
            AutoF1 a5 = new AutoF1(23, "Haas", 100);
            AutoF1 a6 = new AutoF1(99, "McLaren", 120);
            MotoCross m1 = new MotoCross(77, "Monster", 150);
            TestingAuto testingAuto = new TestingAuto(666, "olbiaD");

            Competencia<AutoF1> competencia = new Competencia<AutoF1>(50, 5, Competencia<AutoF1>.TipoCompetencia.F1);
            Competencia<MotoCross> competenciaMotoCross = new Competencia<MotoCross>(40, 5, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            Competencia<AutoF1> competenciaF1  = new Competencia<AutoF1>(48, 6, Competencia<AutoF1>.TipoCompetencia.F1);
            Competencia<AutoF1> competenciaF1SinLugar = new Competencia<AutoF1>(48, 1, Competencia<AutoF1>.TipoCompetencia.F1);
            bool aux = competenciaF1SinLugar + a2;
            #endregion

            #region Agregar vehiculos a la competencia
            #region Testing normal

            Console.WriteLine("-------Agrego AutosF1 a competencia F1-------");
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

            Console.WriteLine("-------Agrego MotoCross a competencia MotoCross-------");

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

            Console.WriteLine("\n-------Agrego un AutoF1 a una competencia de Motocross-------");
            try
            {
                if (competenciaMotoCross + a1)
                {
                    Console.WriteLine(a1.MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\n-------Agrego un Vehiculo a una competencia sin slots-------");
            try
            {
                if (competenciaF1SinLugar + a1)
                {
                    Console.WriteLine(a1.MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }
            #endregion



            #region Testing tipado Generics

            //competenciaF1 + testingAuto;// ->Con este error podriamos sacar la validacion de los ifs dentro del + e ==: ((c.Tipo == TipoCompetencia.F1 && a.GetType() == typeof(AutoF1)) || (c.Tipo == TipoCompetencia.MotoCross && a is MotoCross))

            #endregion


            //Console.WriteLine(competencia.MostrarDatos());
            //Console.WriteLine(competenciaMotoCross.MostrarDatos());


        }
    }
}
