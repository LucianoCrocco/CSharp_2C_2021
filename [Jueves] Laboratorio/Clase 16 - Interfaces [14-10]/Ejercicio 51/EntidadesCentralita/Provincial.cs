using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCentralita.Interfaces;

namespace EntidadesCentralita
{
    public class Provincial : Llamada, IGuardar<string>
    {

        #region Enumerados
        public enum Franja
        {
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
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franja = miFranja;
        }
        #endregion

        #region Setters y Getters
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
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

        #region Metodos
        private float CalcularCosto()
        {
            float precio;
            switch (this.franja)
            {
                case Franja.Franja_1:
                    precio = (float)0.99;
                    break;
                case Franja.Franja_2:
                    precio = (float)1.25;
                    break;
                default:
                    precio = (float)0.66;
                    break;
            }

            return this.Duracion * precio;
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
            sb.AppendLine("\t DATOS DE LLAMADA PROVINCIAL: ");
            sb.AppendLine("Coste: " + this.CostoLlamada);
            sb.AppendLine("Franja de llamado: " + this.franja);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }

        public override string ToString()
        {
            return base.Mostrar();
        }
        #endregion
    }
}
