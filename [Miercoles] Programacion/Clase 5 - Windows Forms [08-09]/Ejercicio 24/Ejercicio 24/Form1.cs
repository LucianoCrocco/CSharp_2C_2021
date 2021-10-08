using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Temperatura;
namespace Ejercicio_24
{
    public partial class Conversor_Temperatura : Form
    {
        public Conversor_Temperatura()
        {
            InitializeComponent();
        }

        private static void MessageEror(string mensaje, string error)
        {
            MessageBox.Show(mensaje, error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtIngresoFahrenheit.Text) && double.TryParse(txtIngresoFahrenheit.Text, out double temperaturaIngresada)){
                Fahrenheit miTemperatura = temperaturaIngresada;
                Celsius celsius = ((Celsius)miTemperatura).GetTemperatura();
                Kelvin kelvin = ((Kelvin)miTemperatura).GetTemperatura();
                txtFahrenheit.Text = temperaturaIngresada.ToString();
                txtFahrenheitACelsius.Text = celsius.GetTemperatura().ToString();
                txtFahrenheitAKelvin.Text = kelvin.GetTemperatura().ToString();
            } else
            {
                MessageEror("Mal ingreso de temperatura", "Error");
            }
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtIngresoCelsius.Text) && double.TryParse(txtIngresoCelsius.Text, out double temperaturaIngresada))
            {
                Celsius miTemperatura = temperaturaIngresada;
                Kelvin kelvin = ((Kelvin)miTemperatura).GetTemperatura();
                Fahrenheit fahrenheit = ((Fahrenheit)miTemperatura).GetTemperatura();
                txtCelsius.Text = temperaturaIngresada.ToString();
                txtCelsiusAFahrenheit.Text = fahrenheit.GetTemperatura().ToString();
                txtCelsiusAKelvin.Text = kelvin.GetTemperatura().ToString();
            }
            else
            {
                MessageEror("Mal ingreso de temperatura", "Error");
            }
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtIngresoKelvin.Text) && double.TryParse(txtIngresoKelvin.Text, out double temperaturaIngresada))
            {
                Kelvin miTemperatura = temperaturaIngresada;
                Fahrenheit fahrenheit = ((Fahrenheit)miTemperatura).GetTemperatura();
                Celsius celsius = ((Celsius)miTemperatura).GetTemperatura();
                txtKelvin.Text = temperaturaIngresada.ToString();
                txtKelvinACelsius.Text = celsius.GetTemperatura().ToString();
                txtKelvinAFahrenheit.Text = fahrenheit.GetTemperatura().ToString();
            }
            else
            {
                MessageEror("Mal ingreso de temperatura", "Error");
            }
        }
    }
}
