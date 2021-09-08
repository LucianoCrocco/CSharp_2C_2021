using System;

namespace Temperatura
{
    public class Fahrenheit
    {
        #region Atributo
        private double temperatura;
        #endregion

        #region Constructor
        public Fahrenheit(double temperatura)
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
        public static implicit operator Fahrenheit(double temperatura)
        {
            return new Fahrenheit(temperatura);
        }
        #endregion

        #region Sobrecarga Explicita
        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            return new Celsius((fahrenheit.GetTemperatura() - 32) * 9/5);
        }

        public static explicit operator Kelvin(Fahrenheit fahrenheit)
        {
            return new Kelvin((fahrenheit.GetTemperatura() + 459.67) * 5/9);
        }

        #endregion

        #region Sobrecarga de Operadores
        public static Fahrenheit operator +(Fahrenheit f1, Celsius c1)
        {
            return new Fahrenheit(f1.GetTemperatura() + ((Fahrenheit)c1).GetTemperatura());
        }
        public static Fahrenheit operator +(Fahrenheit f1, Kelvin k1)
        {
            return new Fahrenheit(f1.GetTemperatura() + ((Fahrenheit)k1).GetTemperatura());
        }

        public static Fahrenheit operator -(Fahrenheit f1, Celsius c1)
        {
            return new Fahrenheit(f1.GetTemperatura() - ((Fahrenheit)c1).GetTemperatura());
        }
        public static Fahrenheit operator -(Fahrenheit f1, Kelvin k1)
        {
            return new Fahrenheit(f1.GetTemperatura() - ((Fahrenheit)k1).GetTemperatura());
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            if(f1.GetTemperatura() == f2.GetTemperatura())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static bool operator ==(Fahrenheit f1, Celsius c1)
        {
            if(f1.GetTemperatura() == ((Fahrenheit)c1).GetTemperatura())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Fahrenheit f1, Celsius c1)
        {
            return !(f1 == c1);
        }

        public static bool operator ==(Fahrenheit f1, Kelvin k1)
        {
            if (f1.GetTemperatura() == ((Fahrenheit)k1).GetTemperatura())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Fahrenheit f1, Kelvin k1)
        {
            return !(f1 == k1);
        }
        #endregion
    }
}
