using System;

namespace Entidades
{
    public class AutoF1
    {
        private string escuderia;
        private int posicion;
        private int puntoPartida;
        private int velocidad;

        public AutoF1() { }

        public AutoF1(string escuderia, int velocidad, int puntoPartida)
        {
            this.Escuderia = escuderia;
            this.Velocidad = velocidad;
            this.puntoPartida = puntoPartida;
        }

        public string Escuderia { get => escuderia; set => escuderia = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public int UbicacionEnPista { get => puntoPartida; set => puntoPartida = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }

        public void Acelerar()
        {
            this.UbicacionEnPista += this.Velocidad;
        }

        public override string ToString()
        {
            return $"Escuderia: {this.Escuderia} - Posicion: {this.Posicion}";
        }
    }
}
