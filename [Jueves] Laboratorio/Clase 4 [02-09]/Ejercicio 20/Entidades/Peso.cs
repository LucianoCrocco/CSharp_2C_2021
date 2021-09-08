using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        static Peso()
        {
            Peso.cotizRespectoDolar = 68;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga Implicita
        public static implicit operator Peso(double peso)
        {
            return new Peso(peso);
        }
        #endregion

        #region Sobrecarga Explicita
        public static explicit operator Dolar(Peso peso)
        {
            return new Dolar(peso.GetCantidad() / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso peso)
        {
            return (Euro)((Dolar)peso); //Reutilizacion de codigo
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Peso p1, Peso p2)
        {
            if(p1.GetCantidad() == p2.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator != (Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso p1, Dolar d1)
        {
            if (p1.GetCantidad() == ((Peso)d1).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Peso p1, Dolar d1)
        {
            return !(p1 == d1);
        }

        public static bool operator ==(Peso p1, Euro e1)
        {
            if (p1.GetCantidad() == ((Peso)e1).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Peso p1, Euro e1)
        {
            return !(p1 == e1);
        }

        public static Peso operator +(Peso p1, Dolar d1)
        {
            return new Peso(p1.GetCantidad() + ((Peso)d1).GetCantidad());
        }

        public static Peso operator -(Peso p1, Dolar d1)
        {
            return new Peso(p1.GetCantidad() - ((Peso)d1).GetCantidad());
        }

        public static Peso operator +(Peso p1, Euro e1)
        {
            return new Peso(p1.GetCantidad() + ((Peso)e1).GetCantidad());
        }

        public static Peso operator -(Peso p1, Euro e1)
        {
            return new Peso(p1.GetCantidad() - ((Peso)e1).GetCantidad());
        }
        #endregion
    }
}
