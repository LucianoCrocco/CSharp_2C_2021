using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }

        #region Propiedades
        ConsoleColor IAcciones.Color { get => ConsoleColor.Gray; set => throw new NotImplementedException(); }


        float IAcciones.UnidadesDeEscritura { get => this.tamanioMina;
            set {
                if(value > 0)
                {
                    this.tamanioMina = value;
                }
            } 
        }
        #endregion

        #region Metodos

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if (!String.IsNullOrWhiteSpace(texto))
            {
                ((IAcciones)this).UnidadesDeEscritura -= (float)(texto.Length * 0.1);
            }
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura += unidades;
            return true;
        }
        public override string ToString()
        {
            return $"Es: {this.GetType().Name}, color de escritura: {((IAcciones)this).Color}, nivel de tinta {((IAcciones)this).UnidadesDeEscritura}";
        }

        #endregion
    }
}
