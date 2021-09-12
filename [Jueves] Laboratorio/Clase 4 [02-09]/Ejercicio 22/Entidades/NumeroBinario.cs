using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        #region Atributos
        private string numero;
        #endregion

        #region Constructores
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        #endregion

        #region Getters 
        public string GetBinario()
        {
            return this.numero;
        }

        #endregion

        #region Sobrecarga Implicita
        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }
        #endregion

        #region Sobrecarga explicita
        public static explicit operator NumeroBinario(NumeroDecimal numero)
        {
            NumeroBinario nuevoBinario = new NumeroBinario(Conversor.DecimalBinario(numero.GetNumeroDecimal()));
            return nuevoBinario;
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(NumeroBinario binario, NumeroDecimal numero)
        {
            if(Conversor.BinarioDecimal(binario.GetBinario()) == numero.GetNumeroDecimal())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(NumeroBinario binario, NumeroDecimal numero)
        {
            return !(binario == numero);
        }

        public static NumeroBinario operator +(NumeroBinario binario, NumeroDecimal numero)
        {
            double auxBinario = Conversor.BinarioDecimal(binario.GetBinario());
            NumeroBinario retorno = new NumeroBinario(Conversor.DecimalBinario(auxBinario + numero.GetNumeroDecimal()));
            return retorno;
        }
        public static NumeroBinario operator -(NumeroBinario binario, NumeroDecimal numero)
        {
            double auxBinario = Conversor.BinarioDecimal(binario.GetBinario());
            NumeroBinario retorno = new NumeroBinario(Conversor.DecimalBinario(auxBinario - numero.GetNumeroDecimal()));
            return retorno;
        }
        #endregion
    }
}
