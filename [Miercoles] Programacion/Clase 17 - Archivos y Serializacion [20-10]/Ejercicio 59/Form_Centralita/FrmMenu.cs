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
    public partial class FrmMenu : Form
    {
        private Centralita centralita;
        FrmMostrar mostrar;
        FrmLlamador llamador;
        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita("Mi centralita");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            llamador = new FrmLlamador(centralita);
            llamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            mostrar = new FrmMostrar(Llamada.TipoLlamada.Todas);
            mostrar.Centralita = llamador.Centralita;
            mostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            mostrar = new FrmMostrar(Llamada.TipoLlamada.Local);
            mostrar.Centralita = llamador.Centralita;
            mostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            mostrar = new FrmMostrar(Llamada.TipoLlamada.Provincial);
            mostrar.Centralita = llamador.Centralita;
            mostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?","Confirmacion",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
