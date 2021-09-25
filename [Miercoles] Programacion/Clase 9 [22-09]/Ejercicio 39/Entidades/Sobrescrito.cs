using System;

namespace Entidades
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public abstract string MiPropiedad
        {
            get;
        }

        public override string ToString()
        {
            return "Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

        public abstract string MiMetodo();
    }
}
