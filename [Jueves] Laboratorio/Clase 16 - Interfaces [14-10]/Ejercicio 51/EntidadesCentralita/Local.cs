using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public class Local : Llamada
    {
        #region Atributos
        protected float costo;
        #endregion

        #region Getters y Setters
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public string RutaDeArchivo
        {
            get
            {
                return "Ruta de Archivo";
            }
            set
            {

            }
        }
        #endregion

        #region Constructores
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo)
            : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Sobreescribiendo Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("\t DATOS DE LLAMADA LOCAL: ");
            sb.AppendLine("Coste: " + this.CostoLlamada);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Local);
        }

        public override string ToString()
        {
            return base.Mostrar();
        }
        #endregion
    }
}
