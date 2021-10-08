using System;

namespace Entidades
{
    public class Cliente
    {
        #region Atributos
        private string nombre;
        private int numero;
        #endregion

        #region Constructores
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero)
            : this(numero)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Getters y Setters
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }
        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if(c1.numero == c2.numero)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {

            return !(c1 == c2);
        }
        #endregion

    }
}
