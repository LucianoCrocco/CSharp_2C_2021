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

namespace Downloader
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Descargar(object sender, string url)
        {
            Descargador descargador = new Descargador();
            descargador.FinDescarga += FinDescargaJson;
            descargador.Descargar(url, sender);
        }

        private void FinDescargaJson(string json, object originalSender)
        {
            if(originalSender == btnDescargar)
            {
                this.rchDescarga.Text = json;
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            this.Descargar(sender, txtLink.Text);
        }
    }
}
