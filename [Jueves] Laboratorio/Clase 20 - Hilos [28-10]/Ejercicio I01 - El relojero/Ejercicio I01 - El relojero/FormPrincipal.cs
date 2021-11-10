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

namespace Ejercicio_I01___El_relojero
{
    public partial class FormPrincipal : Form
    {
        public delegate void MiDelegado();
        Task tarea;
        public FormPrincipal()
        {
            InitializeComponent();
            tarea = new Task(ActualizarHora);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //this.timer1.Enabled = true;
            //this.timer1.Interval = 1000;
            tarea.Start();
        }

        public void ActualizarHora()
        {
            while(true)
            {
                AsignarHora();
                Thread.Sleep(1000);
            }
        }

        public void AsignarHora()
        {
            if (lblHora.InvokeRequired)
            {
                //Action action = AsignarHora;
                //MiDelegado miDelegado = new MiDelegado(AsignarHora);
                MiDelegado miDelegado = AsignarHora;
                this.Invoke(miDelegado);
            } 
            else
            {
                this.lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    this.AsignarHora();
        //}
    }
}
