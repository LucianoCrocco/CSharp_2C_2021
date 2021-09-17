using System;
using Entidades;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre vT = new VehiculoTerrestre(1, 1, VehiculoTerrestre.Colores.Rojo);
            Automovil a1 = new Automovil(vT.cantidadRuedas, vT.cantidadPuertas, vT.color, 7, 100);
            Moto m1 = new Moto(vT.cantidadRuedas, vT.cantidadPuertas, vT.color, 2, 60);
            Camion c1 = new Camion(vT.cantidadRuedas, vT.cantidadPuertas, vT.color, 10, 200);
        }
    }
}
