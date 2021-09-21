using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {

        #region Enumerados
        public enum Franja{
            Franja_1,
            Franja_2,
            Franja_3
        }
        #endregion

        #region Atributos
        protected Franja franja;
        #endregion

        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franja = miFranja;   
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franja = miFranja;
        }
        #endregion

        #region Setters y Getters
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float precio;
            switch (this.franja)
            {
                case Franja.Franja_1:
                    precio = (float) 0.99;
                    break;
                case Franja.Franja_2:
                    precio = (float) 1.25;
                    break;
                default:
                    precio = (float) 0.66;
                    break;
            }

            return this.Duracion * precio;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("\t DATOS DE LLAMADA PROVINCIAL: ");
            sb.AppendLine("Coste: " + this.CostoLlamada);
            sb.AppendLine("Franja de llamado: " + this.franja);

            return sb.ToString();
        }
        #endregion

    }
}
