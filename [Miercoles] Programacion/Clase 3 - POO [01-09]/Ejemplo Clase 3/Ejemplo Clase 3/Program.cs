using Entidades;
using System;

namespace Ejemplo_Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Ale Dionicio", 30);
            Console.WriteLine($"Nombre {p.GetNombre()} tiene años {p.GetEdad()} {p.GetTipo()}");
            Persona.tipo = "Humanoide";
            Console.WriteLine($"Nombre {p.GetNombre()} tiene años {p.GetEdad()} {p.GetTipo()}");
            Console.ReadKey();
        }
    }
}
