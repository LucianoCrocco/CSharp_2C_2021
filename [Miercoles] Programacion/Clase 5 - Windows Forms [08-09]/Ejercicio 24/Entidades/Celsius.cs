using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Celsius
    {
        #region Atributo
        private double temperatura;
        #endregion

        #region Constructor
        public Celsius(double temperatura)
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
        public static implicit operator Celsius(double temperatura)
        {
            return new Celsius(temperatura);
        }
        #endregion

        #region Sobrecarga Explicita
        public static explicit operator Fahrenheit(Celsius celsius)
        {
            return new Fahrenheit(celsius.GetTemperatura() * 9 / 5 + 32);
        }

        public static explicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.GetTemperatura() - 273.15);
        }

        #endregion

        #region Sobrecarga de Operadores
        public static Celsius operator +(Celsius c1, Fahrenheit f1)
        {
            return new Celsius(c1.GetTemperatura() + ((Celsius)f1).GetTemperatura()); 
        }

        public static Celsius operator +(Celsius c1, Kelvin k1)
        {
            return new Celsius(c1.GetTemperatura() + ((Celsius)k1).GetTemperatura());
        }

        public static Celsius operator -(Celsius c1, Fahrenheit f1)
        {
            return new Celsius(c1.GetTemperatura() - ((Celsius)f1).GetTemperatura());
        }

        public static Celsius operator -(Celsius c1, Kelvin k1)
        {
            return new Celsius(c1.GetTemperatura() - ((Celsius)k1).GetTemperatura());
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            if(c1.GetTemperatura() == c2.GetTemperatura())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Celsius c1, Fahrenheit f1)
        {
            if(c1.GetTemperatura() == ((Celsius)f1).GetTemperatura())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Celsius c1, Fahrenheit f1)
        {
            return !(c1 == f1);
        }

        public static bool operator ==(Celsius c1, Kelvin k1)
        {
            if (c1.GetTemperatura() == ((Celsius)k1).GetTemperatura())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Celsius c1, Kelvin k1)
        {
            return !(c1 == k1);
        }
        #endregion
    }
}
