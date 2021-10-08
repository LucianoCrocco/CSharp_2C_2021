using System;

namespace Entidades
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int ejeX, int ejeY)
        {
            this.x = ejeX;
            this.y = ejeY;
        }

        public int GetCoordenadaX()
        {
            return this.x;
        }

        public int GetCoordenadaY()
        {
            return this.y;
        }


    }
}
