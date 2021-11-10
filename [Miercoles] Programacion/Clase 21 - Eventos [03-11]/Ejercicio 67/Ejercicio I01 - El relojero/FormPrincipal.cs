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
            //Asocio un metodo al delegado que a su vez lo asocia al evento.
            temporizador.EventoTiempo += ActualizarHora;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Inicializo mi hilo con sus metodos asociados.
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
            //Asignar hora se esta ejecutando en un hilo secundario, por lo tanto tengo que volver a llamarlo para que se ejecute en el principal para modificar mi hilo principal
            if (lblHora.InvokeRequired)
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
