using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace Ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void mensajeError(string mensaje, string tipoError)
        {
            MessageBox.Show(mensaje, tipoError, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void btnConvertirBinarioADecimal_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxBinarioADecimal.Text) && Conversor.VerificarEsBinario(txtBoxBinarioADecimal.Text))
            {
                NumeroBinario miBinario = txtBoxBinarioADecimal.Text;
                NumeroDecimal miDecimal = ((NumeroDecimal)miBinario).GetNumeroDecimal();
                txtDecimalConvertido.Text = miDecimal.GetNumeroDecimal().ToString();
            }
            else
            {
                mensajeError("No se ingreso correctamente el campo Binario", "Error");
            }
        }

        private void btnConvertirDecimalABinario_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtBoxDecimalABinario.Text) && double.TryParse(txtBoxDecimalABinario.Text, out double numero))
            {
                NumeroDecimal numeroDecimal = numero;
                NumeroBinario numeroBinario = ((NumeroBinario)numeroDecimal).GetBinario();
                txtBinarioConvertido.Text = numeroBinario.GetBinario();
            } else
            {
                mensajeError("No se ingreso correctamente el campo Decimal", "Error");
            }
        }
    }
}
