using System;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {


        short cantidadRuedas;
        short cantidadPuertas;
        Colores color;
        short cantidadMarchas;
        int cantidadPasajeros;


        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            :base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
