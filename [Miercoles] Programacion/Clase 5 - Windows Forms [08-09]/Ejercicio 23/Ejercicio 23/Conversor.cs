using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Billetes;

namespace Ejercicio_23
{
    public partial class Conversor : Form
    {
        private bool locked;
        public Conversor()
        {
            InitializeComponent();
            locked = true;
            btnConvertEuro.Enabled = true;
            btnConvertDolar.Enabled = true;
            btnConvertPeso.Enabled = true;
            btnCotizar.ImageIndex = 0;
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionPeso.Text = Peso.GetCotizacion().ToString();
            txtCotizacionPeso.Enabled = false;
            txtCotizacionEuro.Enabled = false;
            txtCotizacionDolar.Enabled = false;
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if(!(String.IsNullOrEmpty(txtCotizacionEuro.Text)) && !(String.IsNullOrEmpty(txtCotizacionPeso.Text)) && locked == true){
                locked = false;
                btnConvertEuro.Enabled = false;
                btnConvertDolar.Enabled = false;
                btnConvertPeso.Enabled = false;
                btnCotizar.ImageIndex = 1;
                txtCotizacionPeso.Enabled = true;
                txtCotizacionEuro.Enabled = true;
            }
            else
            {
                locked = true;
                btnConvertEuro.Enabled = true;
                btnConvertDolar.Enabled = true;
                btnConvertPeso.Enabled = true;
                btnCotizar.ImageIndex = 0;
                txtCotizacionPeso.Enabled = false;
                txtCotizacionEuro.Enabled = false;
            }
        }
        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (locked == true)
            {
                if (Double.TryParse(EuroA.Text, out double euros))
                {
                    Euro miEuro = euros;
                    Dolar miDolar;
                    Peso miPeso;
                    double dolar;
                    double peso;
                    txtEuro.Text = miEuro.GetCantidad().ToString();
                    miDolar = (Dolar)miEuro;
                    dolar = miDolar.GetCantidad();
                    dolar = Math.Round(dolar, 2);
                    txtEuroADolar.Text = dolar.ToString();
                    miPeso = (Peso)miEuro;
                    peso = miPeso.GetCantidad();
                    peso = Math.Round(peso, 2);
                    txtEuroAPeso.Text = peso.ToString();
                } else
                {
                    MesaggeError("No se ingresaron numeros en la casilla de Euros", "Error");
                }
            }
            else
            {
                MessageBox.Show("Error... Hacen falta llenar los campos de \"Cotizaciones\"");
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (locked == true)
            {
                if (Double.TryParse(DolarA.Text, out double dolar))
                {
                    Dolar miDolar = dolar;
                    Euro miEuro;
                    Peso miPeso;
                    double euro;
                    double peso;
                    txtDolar.Text = dolar.ToString();
                    miEuro = (Euro) miDolar;
                    euro = miEuro.GetCantidad();
                    euro = Math.Round(euro, 2);
                    txtDolarAEuro.Text = euro.ToString();
                    miPeso = (Peso)miDolar;
                    peso = miPeso.GetCantidad();
                    peso = Math.Round(peso, 2);
                    txtDolarAPeso.Text = peso.ToString();
                }
                else
                {
                    MesaggeError("No se ingresaron numeros en la casilla de Dolares", "Error");
                }
            }
            else
            {
                MessageBox.Show("Error... Hacen falta llenar los campos de \"Cotizaciones\"");
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (locked == true)
            {
                if (Double.TryParse(PesoA.Text, out double peso))
                {
                    Peso miPeso = peso;
                    Euro miEuro;
                    Dolar miDolar;
                    double euro;
                    double dolar;
                    txtPeso.Text = peso.ToString();
                    miEuro = (Euro)miPeso;
                    euro = miEuro.GetCantidad();
                    euro = Math.Round(euro, 2);
                    txtPesoAEuro.Text = euro.ToString();
                    miDolar = (Dolar)miPeso;
                    dolar = miDolar.GetCantidad();
                    dolar = Math.Round(dolar, 2);
                    txtPesoADolar.Text = dolar.ToString();
                }
                else
                {
                    MesaggeError("No se ingresaron numeros en la casilla de Pesos", "Error");
                }
            }
            else
            {
                MessageBox.Show("Error... Hacen falta llenar los campos de \"Cotizaciones\"");
            }
        }

        private void txtCotizacionPeso_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCotizacionPeso.Text) && Double.TryParse(txtCotizacionPeso.Text, out double cotizacionNuevaPeso))
            {
                Peso.SetCotizacion(cotizacionNuevaPeso);
            }
            else
            {
                txtCotizacionPeso.Focus();
                MesaggeError("Monto en pesos invalido", "Error");
            }
        }


        private void txtCotizacionEuro_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCotizacionEuro.Text) && Double.TryParse(txtCotizacionEuro.Text, out double cotizacionNuevaEuros))
            {
                Euro.SetCotizacion(cotizacionNuevaEuros);
            }
            else
            {
                txtCotizacionEuro.Focus();
                MesaggeError("Monto en Euros invalido", "Error");
            }
        }

        private static void MesaggeError(string errorMessage, string typeError)
        {
            MessageBox.Show(errorMessage, typeError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region No se usa
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EuroA_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelCotizacion_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
