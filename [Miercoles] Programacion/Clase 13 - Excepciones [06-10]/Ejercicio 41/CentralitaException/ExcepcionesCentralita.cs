using System;

namespace CentralitaException
{
    public class ExcepcionesCentralita : Exception
    {
        private string clase;
        private string metodo;

        public ExcepcionesCentralita(string message, string clase, string metodo) : base(message)
        {
            this.clase = clase;
            this.metodo = metodo;
        }

        public ExcepcionesCentralita(string message, string clase, string metodo, Exception innerException) : base(message, innerException)
        {
            this.clase = clase;
            this.metodo = metodo;
        }

        public string Clase
        {
            get
            {
                return this.clase;
            }
        }

        public string Metodo
        {
            get
            {
                return this.metodo;
            }
        }
    }
}
