using System;
using System.Text;

namespace Excepciones
{
    public class CompetenciaNoDisponibleException : Exception
    {
        #region Atributos
        private string nombreClase;
        private string nombreMetodo;
        #endregion

        #region Propiedades
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        #endregion

        #region Constructores
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) 
        :this(mensaje, clase, metodo, null)
            { }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) 
            :base(mensaje, innerException)

        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepcion en el metodo {this.NombreMetodo} de la clase {this.NombreClase}");
            sb.AppendLine("Error, revisa los detalles.");
            sb.AppendLine($"Detalles: {this.InnerException}");
            return sb.ToString();
        }
        #endregion
    }
}
