using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";
            int dia = 0;
            int mes = 0;
            int anio = 0;
            int diaDateTime;
            int mesDateTime;
            int anioDateTime;
            int diasVividos;
            string ingreso;

            do
            {
                Console.Write("Ingrese un dia de nacimiento valido: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out dia) == false)
                {
                    Console.Write("ERROR... INGRESE SOLO NUMEROS! -> Ingrese un dia de nacimiento valido: ");
                    ingreso = Console.ReadLine();
                }
            } while (dia < 1 && dia > 31);


            do
            {
                Console.Write("Ingrese un mes de nacimiento valido: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out mes) == false)
                {
                    Console.Write("ERROR... INGRESE SOLO NUMEROS! -> Ingrese un mes de nacimiento valido: ");
                    ingreso = Console.ReadLine();
                }
            } while (mes < 1 && mes > 13);


            do
            {
                Console.Write("Ingrese un año de nacimiento valido: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out anio) == false)
                {
                    Console.Write("ERROR... INGRESE SOLO NUMEROS! -> Ingrese un año de nacimiento valido: ");
                    ingreso = Console.ReadLine();
                }
            } while (anio < 0 && anio > 2022);

            var today = DateTime.Now;
            Console.Write($"{today}");

            anioDateTime = (today.Year - anio) * 365 ;
            mesDateTime = (today.Month - mes) * 30;
            diaDateTime = (today.Day - dia);

            diasVividos = anioDateTime + mesDateTime + diaDateTime;

            Console.Write($"Usted vivio un total de: {diasVividos} dias");



        }



    }
}
