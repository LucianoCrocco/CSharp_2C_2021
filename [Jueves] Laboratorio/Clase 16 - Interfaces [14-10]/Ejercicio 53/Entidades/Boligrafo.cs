using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        #region Propiedades
        public ConsoleColor Color 
        {
            get => this.colorTinta; 
            set => this.colorTinta = value; 
        }
        public float UnidadesDeEscritura { get => this.tinta;
            set {
                //if(value > 0)
                //{
                    this.tinta = value;
                //}
            }
        }
        #endregion

        #region Metodos
        public EscrituraWrapper Escribir(string texto)
        {
            if (!String.IsNullOrWhiteSpace(texto))
            {
                this.UnidadesDeEscritura -= (float) (texto.Length * 0.3);
            }
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }


        public override string ToString()
        {
            return $"Es: {this.GetType().Name}, color de escritura: {this.Color}, nivel de tinta {this.UnidadesDeEscritura}";
        }
        #endregion
    }
}
