using System;

namespace Entidades
{
    public class PruebaGeometria
    {
        public static void Main()
        {
            Entidades.Punto puntoUno = new Entidades.Punto(10, 5);
            Entidades.Punto puntoDos = new Entidades.Punto(8, 6);
            Entidades.Rectangulo rectangulo = new Entidades.Rectangulo(puntoUno, puntoDos);
            float area = rectangulo.GetArea();
            float perimetro = rectangulo.GetPerimetro();

            Console.WriteLine($"AREA -> {area} PERIMETRO -> {perimetro}");
        }
    }
}
