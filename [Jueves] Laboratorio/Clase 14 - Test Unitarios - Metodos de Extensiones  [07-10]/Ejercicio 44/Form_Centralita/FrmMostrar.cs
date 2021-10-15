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
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private Llamada.TipoLlamada tipo;
        public FrmMostrar(Llamada.TipoLlamada tipoLlamada)
        {
            InitializeComponent();
            this.tipo = tipoLlamada;
        }

        public Centralita Centralita
        {
            set
            {
                this.centralita = value;
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            foreach(Llamada llamada in this.centralita.Llamadas)
            {
                if(llamada is Local && this.tipo == Llamada.TipoLlamada.Local)
                {
                    rchListaLlamadas.Text += llamada.ToString();
                } else if (llamada is Provincial && this.tipo == Llamada.TipoLlamada.Provincial)
                {
                    rchListaLlamadas.Text += llamada.ToString();
                } else if(this.tipo == Llamada.TipoLlamada.Todas)
                {
                    rchListaLlamadas.Text += llamada.ToString();
                }
            }

            
            if (this.tipo == Llamada.TipoLlamada.Local)
            {
                rchListaLlamadas.Text += $"Ganancia por las llamadas Locales: ${centralita.GananciasPorLocal}";
            }
            else if (this.tipo == Llamada.TipoLlamada.Provincial)
            {
                rchListaLlamadas.Text += $"Ganancia por las llamadas Provinciales: ${centralita.GananciasPorProvincial}";
            }
            else
            {
                rchListaLlamadas.Text += $"Ganancia total por llamdas: ${centralita.GananciasPorTotal}";
            }
        }
    }
}
