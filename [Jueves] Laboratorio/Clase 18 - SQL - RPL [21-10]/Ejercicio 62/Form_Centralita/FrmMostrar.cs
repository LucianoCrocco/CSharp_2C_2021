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
using EntidadesDAO;

namespace Form_Centralita
{
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private Llamada.TipoLlamada tipo;
        private ProvincialDAO provincialDAO;
        private LocalDAO localDAO;
        List<Llamada> llamadasLocalesBdd;
        List<Llamada> llamadasProvicialesBdd;

        public FrmMostrar(Llamada.TipoLlamada tipoLlamada)
        {
            InitializeComponent();
            this.tipo = tipoLlamada;
            provincialDAO = new ProvincialDAO("DESKTOP-", "Centralita");
            localDAO = new LocalDAO("DESKTOP-", "Centralita");
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
            List<Llamada> llamadasLocalesBdd = localDAO.Leer();
            List<Llamada> llamadasProvicialesBdd = provincialDAO.Leer();
            foreach (Llamada llamada in this.centralita.Llamadas)
            {
                if(llamada is Local && this.tipo == Llamada.TipoLlamada.Local)
                {
                    foreach (Llamada llamadaLocal in llamadasLocalesBdd)
                    {
                        if(llamadaLocal is not null)
                        {
                            rchListaLlamadas.Text += llamadaLocal.ToString();
                        }
                    }
                    rchListaLlamadas.Text += llamada.ToString();
                } 
                else if (llamada is Provincial && this.tipo == Llamada.TipoLlamada.Provincial)
                {
                    foreach (Llamada llamadaProvincial in llamadasProvicialesBdd)
                    {
                        if (llamadaProvincial is not null)
                        {
                            rchListaLlamadas.Text += llamadaProvincial.ToString();
                        }
                    }
                    rchListaLlamadas.Text += provincialDAO.Leer();
                    rchListaLlamadas.Text += llamada.ToString();
                } 
                else if(this.tipo == Llamada.TipoLlamada.Todas)
                {
                    foreach (Llamada llamadaLocal in llamadasLocalesBdd)
                    {
                        if (llamadaLocal is not null)
                        {
                            rchListaLlamadas.Text += llamadaLocal.ToString();
                        }
                    }
                    foreach (Llamada llamadaProvincial in llamadasProvicialesBdd)
                    {
                        if (llamadaProvincial is not null)
                        {
                            rchListaLlamadas.Text += llamadaProvincial.ToString();
                        }
                    }
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
