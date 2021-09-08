using System;


namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga Implicita
        public static implicit operator Dolar(double dolar)
        {
            return new Dolar(dolar);
        }
        #endregion

        #region Sobrecarga Explicita
        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(Euro.GetCotizacion() * dolar.GetCantidad());
        }

        public static explicit operator Peso(Dolar dolar)
        {
            return new Peso(Peso.GetCotizacion() * dolar.GetCantidad());
        }
        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if(d1.GetCantidad() == d2.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d1, Euro e1)
        {
            if (d1.GetCantidad() == ((Dolar)e1).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Dolar d1, Euro e1)
        {
            return !(d1 == e1);
        }

        public static bool operator ==(Dolar d1, Peso p1)
        {
            if (d1.GetCantidad() == ((Dolar)p1).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Dolar d1, Peso p1)
        {
            return !(d1 == p1);
        }

        public static Dolar operator +(Dolar d1, Euro e1)
        {
            return new Dolar(d1.GetCantidad() + ((Dolar)e1).GetCantidad());
        }
        public static Dolar operator -(Dolar d1, Euro e1)
        {
            return new Dolar(d1.GetCantidad() - ((Dolar)e1).GetCantidad());
        }

        public static Dolar operator +(Dolar d1, Peso p1)
        {
            return new Dolar(d1.GetCantidad() + ((Dolar)p1).GetCantidad());
        }
        public static Dolar operator -(Dolar d1, Peso p1)
        {
            return new Dolar(d1.GetCantidad() - ((Dolar)p1).GetCantidad());
        }

        #endregion
    }
}
