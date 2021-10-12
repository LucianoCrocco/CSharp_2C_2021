using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EntidadesCentralita;
using CentralitaException;



namespace Form_Centralita
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;

        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            this.cmbBoxFranja.Enabled = false;
        }

        #region Propiedades
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }
        #endregion

        #region Metodos
        private void CargarNumero(string numeroIngresado)
        {
            if (this.txtNroDestino.Text == "Numero Destino")
            {
                this.txtNroDestino.Text = string.Empty;
            }
            this.txtNroDestino.Text += numeroIngresado;

        }
        #endregion

        #region Carga de numeros a Numero Destino
        private void button1_Click(object sender, EventArgs e)
        {
            CargarNumero(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarNumero(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarNumero(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarNumero(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CargarNumero(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CargarNumero(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CargarNumero(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CargarNumero(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CargarNumero(button9.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            CargarNumero(button0.Text);
        }
        private void btnNumeral_Click(object sender, EventArgs e)
        {
            CargarNumero(btnNumeral.Text);
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            CargarNumero(btnAsterisco.Text);
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNroDestino.Text.IndexOf('#') == 0){
                this.cmbBoxFranja.Enabled = true;
            } else if(this.txtNroDestino.Text.Length > 0 && this.txtNroDestino.Text != "Numero Destino")
            {
                this.cmbBoxFranja.Enabled = false;
                this.btnNumeral.Enabled = false;
            } else
            {
                this.cmbBoxFranja.Enabled = false;
                this.btnNumeral.Enabled = false;
            }
        }


        #endregion

        #region Llamar
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Llamada llamada;
            short duracionLlamada = (short) random.Next(1, 50);


            try
            {
                if(this.txtNroDestino.Text [0] == '#' && !cmbBoxFranja.SelectedIndex.Equals(null))
                {
                    llamada = new Provincial(txtNroOrigen.Text, (Provincial.Franja)cmbBoxFranja.SelectedIndex, duracionLlamada, txtNroDestino.Text);
                } else
                {
                    float costo = random.Next(1, 100);
                    llamada = new Local(txtNroOrigen.Text, duracionLlamada, txtNroDestino.Text, costo);
                }
                    centralita += llamada;
            } 
            catch (ExcepcionesCentralita ex)
            {
                MessageBox.Show($"Error: {ex.Message}, ocurrio en la clase {ex.Clase}, dentro del metodo {ex.Metodo}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #endregion

        #region Otros Botones

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Numero Destino";
            this.txtNroOrigen.Text = "Numero Origen";
            this.btnNumeral.Enabled = true;
        }
        private void txtNroOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingrese SOLO Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion


    }
}
