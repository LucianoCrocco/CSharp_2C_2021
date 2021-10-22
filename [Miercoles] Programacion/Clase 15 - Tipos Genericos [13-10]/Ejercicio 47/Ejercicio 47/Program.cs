using System;
using Entidades;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo Basquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo Futbol");

            EquipoBasquet e1 = new EquipoBasquet("Lakers", new DateTime(1950, 02, 25));
            EquipoBasquet ebIgualeb1 = new EquipoBasquet("Lakers", new DateTime(1950, 02, 25));
            EquipoBasquet e2 = new EquipoBasquet("Hornets", new DateTime(1980, 02, 25));
            EquipoBasquet e3 = new EquipoBasquet("Celtics", new DateTime(2000, 02, 25));
            EquipoBasquet e4 = new EquipoBasquet("Warrios", new DateTime(2011, 02, 25));

            EquipoFutbol f1 = new EquipoFutbol("San Lorenzo", new DateTime(2020, 02, 25));
            EquipoFutbol fr1Igualef1 = new EquipoFutbol("San Lorenzo", new DateTime(2020, 02, 25));
            EquipoFutbol f2 = new EquipoFutbol("River Plate", new DateTime(2019, 02, 25));
            EquipoFutbol f3 = new EquipoFutbol("Racing", new DateTime(2018, 02, 25));
            EquipoFutbol f4 = new EquipoFutbol("Boca Juniors", new DateTime(2021, 02, 25));

            Console.WriteLine("\t-------REGION BASQUET---------------\n");
            Console.WriteLine("\t--Añadir a la lista--\n");
            try
            {
                torneoBasquet += f1;
            }
            catch (Exception)
            {
                Console.WriteLine("\t\aEl equipo no pertenece a este torneo");
                Console.ReadKey();
            }
            torneoBasquet += e1;
            torneoBasquet += ebIgualeb1;
            torneoBasquet += e2;
            torneoBasquet += e3;
            torneoBasquet += e4;
            Console.WriteLine("\t--Comparar dos iguales--\n");
            Console.WriteLine(e1 == ebIgualeb1);
            Console.WriteLine("\t--Mostrar datos--\n");
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine("\t--Jugar partido--\n");
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.WriteLine("\t-------REGION Futbol---------------\n");
            Console.WriteLine("\t--Añadir a la lista--\n");
            torneoFutbol += f1;
            torneoFutbol += fr1Igualef1;
            torneoFutbol += f2;
            torneoFutbol += f3;
            torneoFutbol += f4;
            Console.WriteLine("\t--Comparar dos iguales--\n");
            Console.WriteLine(f1 == fr1Igualef1);
            Console.WriteLine("\t--Mostrar datos--\n");
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine("\t--Jugar partido--\n");
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

        }
    }
}
