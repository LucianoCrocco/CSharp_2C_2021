using System;
using Entidades;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.Metodo();
            } catch(MiExpecion ex)
            {
                Console.WriteLine(ex.Message);

                Exception e = ex.InnerException;

                while(e is not null)
                {
                    Console.WriteLine(e.Message);
                    e = e.InnerException;
                }
                
            }
        }
    }
}
