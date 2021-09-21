using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        #region Atributos
        protected float costo;
        #endregion

        #region Getters y Setters
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string nroOrigen, float costo)
            : base(duracion, origen, nroOrigen)
        {
            this.costo = costo;
        }
        #endregion

        #region Metodos
        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("\t DATOS DE LLAMADA LOCAL: ");
            sb.AppendLine("Coste: " + this.CostoLlamada);

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }
        #endregion
    }
}
