using System;

namespace Entidades
{
    public abstract class Trooper
    {
        #region Atributos
        protected Blaster armamento;
        protected bool esClon;
        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve el tipo de enumardo del atributo armamento.
        /// </summary>
        public Blaster Armamento
        {
            get
            {
                return this.armamento;
            }
        }
        /// <summary>
        /// Devuelve el valor booleano del atributo esClon
        /// </summary>
        public bool EsClon
        {
            get
            {
                return this.esClon;
            }
        }
        /// <summary>
        /// Metodo abstracto, se aplica en la herencia de la clase. Depende del tipo de Trooper devuelve su funcion "en batalla".
        /// </summary>
        public abstract string Tipo
        {
            get;
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor con un parametro de Trooper, por defecto el trooper NO es clon
        /// </summary>
        /// <param name="armamento">Tipo de blaster del trooper</param>
        //Nota: Se que si llamo con :this() al constructor por defecto me va a inicializar el esClon en false. No me gusta como queda en tiempo de diseño:$
        public Trooper(Blaster armamento)
        {
            this.esClon = false;
            this.armamento = armamento;
        }

        /// <summary>
        /// Constructor con dos parametro de Trooper, se puede especificar si es clon o no.
        /// </summary>
        /// <param name="armamento">Tipo de blaster del trooper</param>
        /// <param name="esClon">true o false si es clon</param>
        public Trooper(Blaster armamento, bool esClon)
            : this(armamento)
        {
            this.esClon = esClon;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Devuelve un string de la informacion del trooper.
        /// </summary>
        /// <returns></returns>
        public virtual string InfoTrooper()
        {
            string retorno = $"{Tipo} armado con {Armamento}, {EsClon} es clone.";
            //No tengo idea como usar el String.Format
            return retorno;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Verifica que el object recibido por parametros sea del mismo tipo que la instancia actual.
        /// </summary>
        /// <param name="obj">Objeto a comparar con la instancia actual.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }
        #endregion

    }
}
