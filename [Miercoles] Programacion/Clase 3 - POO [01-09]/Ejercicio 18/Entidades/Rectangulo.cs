using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area;
        private float perimetro;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            int baseRectangulo = Math.Abs(vertice1.GetCoordenadaX()) + Math.Abs(vertice3.GetCoordenadaX());
            int altura = Math.Abs(vertice1.GetCoordenadaY()) + Math.Abs(vertice3.GetCoordenadaY());
            this.area = baseRectangulo * altura;
            this.perimetro = (baseRectangulo + altura) * 2;
        }

        public float GetArea()
        {
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }



    }
}
