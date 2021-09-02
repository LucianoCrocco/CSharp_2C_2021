using System;
using Entidades;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("Juan Pablo", "Fulano", 1500);
            Alumno a2 = new Alumno("Ricardo", "De Perez", 1000);
            string mensaje;

            a1.Estudiar(4, 10);
            a1.CalcularFinal();
            mensaje = a1.Mostrar();
            Console.WriteLine(mensaje);
            a2.Estudiar(2, 2);
            a2.CalcularFinal();
            mensaje = a2.Mostrar();
            Console.WriteLine(mensaje);
        }
    }
}
