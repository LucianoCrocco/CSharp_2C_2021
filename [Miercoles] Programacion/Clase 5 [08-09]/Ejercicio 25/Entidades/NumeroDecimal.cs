using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        #region Atributos
        private double numero;
        #endregion

        #region Constructores
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        #endregion

        #region Getters
        public double GetNumeroDecimal()
        {
            return this.numero;
        }
        #endregion

        #region Sobrecarga implicita
        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        #endregion

        #region Sobrecarga explicita
        public static explicit operator NumeroDecimal(NumeroBinario numero)
        {
            return new NumeroDecimal(Conversor.BinarioDecimal(numero.GetBinario()));
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(NumeroDecimal numero, NumeroBinario binario)
        {
            if (numero.GetNumeroDecimal() == Conversor.BinarioDecimal(binario.GetBinario()))
            {
                return true;
            }
            return false;
        }
        
        public static bool operator !=(NumeroDecimal numero, NumeroBinario binario)
        {
            return !(numero == binario);
        }

        public static NumeroDecimal operator +(NumeroDecimal numero, NumeroBinario binario)
        {
            double auxBinario = Conversor.BinarioDecimal(binario.GetBinario());
            return numero.GetNumeroDecimal() + auxBinario;
        }

        public static NumeroDecimal operator -(NumeroDecimal numero, NumeroBinario binario)
        {
            double auxBinario = Conversor.BinarioDecimal(binario.GetBinario());
            return numero.GetNumeroDecimal() - auxBinario;
        }
        #endregion
    }
}
