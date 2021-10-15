using System;
using System.Text;

namespace EntidadesCentralita
{
    public abstract class Llamada
    {
        #region Enumerados
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        #endregion

        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Getters y Setters

        public abstract float CostoLlamada{
            get;
        }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tDATOS LLAMADA");
            sb.AppendLine("Duracion: " + this.Duracion);
            sb.AppendLine("Numero Destino: " + this.NroDestino);
            sb.AppendLine("Numero Origen: " + this.NroOrigen);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                retorno = -1;
            }

            return retorno;
        }
        #endregion

        #region Sobrecarga
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;
            if (l1 is not null && l2 is not null && l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen) {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        #endregion
    }
}
