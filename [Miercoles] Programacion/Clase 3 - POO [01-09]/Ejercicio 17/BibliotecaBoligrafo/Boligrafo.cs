using System;

namespace BibliotecaBoligrafo
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;


        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void setTinta (short tinta)
        {
            short tintaActual = GetTinta();

            tintaActual += tinta;
            if(tintaActual >= 0 && tintaActual <= cantidadTintaMaxima)
            {
               this.tinta = tintaActual;
            } else if (tintaActual < 0)
            {
                this.tinta = 0;
            } else
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

        public void Recargar()
        {
            setTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short tintaActual = GetTinta();
            short cantidadImpresa;
            char simbolo = '*';

            cantidadImpresa = (short) (tintaActual - gasto);

            if (cantidadImpresa > 0){
                dibujo = new String(simbolo, gasto);
                setTinta((short)-gasto);
                return true;
            } else
            {
                dibujo = new String(simbolo, tintaActual);
                setTinta((short)-gasto);
                return false;
            }
        }
    }
}
