using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ejercicio_I01___El_relojero
{
    public partial class FormPrincipal : Form
    {
        Temporizador temporizador;
        public FormPrincipal()
        {
            InitializeComponent();
            temporizador = new Temporizador();
            temporizador.EventoTiempo += ActualizarHora;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            temporizador.Activo = true;
            temporizador.Intervalo = 1000;
        }

        public void ActualizarHora()
        {
            while(true)
            {
                AsignarHora();
            }
        }

        public void AsignarHora()
        {
            if (this.InvokeRequired)
            {
                EncargadoTiempo callback = new EncargadoTiempo(AsignarHora);
                this.Invoke(callback);
            } 
            else
            {
                this.lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }
    }
}
