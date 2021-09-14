using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        static Euro()
        {
            Euro.cotizRespectoDolar = 1.18;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        #endregion

        #region Setters
        public static void SetCotizacion(double cotizRespectoDolar)
        {
            Euro.cotizRespectoDolar = cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga Implicita
        public static implicit operator Euro(double euro)
        {
            return new Euro(euro);
        }
        #endregion

        #region Sobrecarga Explicita
        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Euro euro)
        {
            return (Peso)((Dolar)euro); //Reutilizacion de codig
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Euro e1, Euro e2)
        {
            if (e1.GetCantidad() == e2.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e1, Dolar d1)
        {
            if (e1.GetCantidad() == ((Euro)d1).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Euro e1, Dolar d1)
        {
            return !(e1 == d1);
        }

        public static bool operator ==(Euro e1, Peso p1)
        {
            if (e1.GetCantidad() == ((Euro)p1).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Euro e1, Peso p1)
        {
            return !(e1 == p1);
        }

        public static Euro operator +(Euro e1, Dolar d1)
        {
            return new Euro(e1.GetCantidad() + ((Euro)d1).GetCantidad());
        }

        public static Euro operator -(Euro e1, Dolar d1)
        {
            return new Euro(e1.GetCantidad() - ((Euro)d1).GetCantidad());
        }

        public static Euro operator +(Euro e1, Peso p1)
        {
            return new Euro(e1.GetCantidad() + ((Euro)p1).GetCantidad());
        }

        public static Euro operator -(Euro e1, Peso p1)
        {
            return new Euro(e1.GetCantidad() - ((Euro)p1).GetCantidad());
        }
        #endregion
    }
}
