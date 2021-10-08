using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Kelvin
    {
        #region Atributo
        private double temperatura;
        #endregion

        #region Constructor
        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }
        #endregion

        #region Getters
        public double GetTemperatura()
        {
            return this.temperatura;
        }
        #endregion

        #region Sobrecarga Implicita
        public static implicit operator Kelvin(double temperatura)
        {
            return new Kelvin(temperatura);
        }
        #endregion

        #region Sobrecarga Explicita
        public static explicit operator Fahrenheit(Kelvin kelvin)
        {
            return new Fahrenheit(kelvin.GetTemperatura() * 9 / 5 - 459.67);
        }

        public static explicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.GetTemperatura() - 273.15);
        }

        #endregion

        #region Sobrecarga de Operadores
        public static Kelvin operator +(Kelvin k1, Celsius c1)
        {
            return new Kelvin(k1.GetTemperatura() + ((Kelvin)c1).GetTemperatura());
        }
        public static Kelvin operator +(Kelvin k1, Fahrenheit f1)
        {
            return new Kelvin(k1.GetTemperatura() + ((Kelvin)f1).GetTemperatura());
        }
        public static Kelvin operator -(Kelvin k1, Celsius c1)
        {
            return new Kelvin(k1.GetTemperatura() - ((Kelvin)c1).GetTemperatura());
        }
        public static Kelvin operator -(Kelvin k1, Fahrenheit f1)
        {
            return new Kelvin(k1.GetTemperatura() - ((Kelvin)f1).GetTemperatura());
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            if(k1.GetTemperatura() == k2.GetTemperatura())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        public static bool operator ==(Kelvin k1, Celsius c1)
        {
            if (k1.GetTemperatura() == ((Kelvin)c1).GetTemperatura())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Kelvin k1, Celsius c1)
        {
            return !(k1 == c1);
        }

        public static bool operator ==(Kelvin k1, Fahrenheit f1)
        {
            if (k1.GetTemperatura() == ((Kelvin)f1).GetTemperatura())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Kelvin k1, Fahrenheit f1)
        {
            return !(k1 == f1);
        }

        #endregion
    }
}
