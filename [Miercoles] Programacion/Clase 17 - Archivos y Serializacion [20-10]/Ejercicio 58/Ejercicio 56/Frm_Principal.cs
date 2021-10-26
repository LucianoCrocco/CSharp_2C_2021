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
using IO;

namespace Ejercicio_56
{
    public partial class Frm_Principal : Form
    {
        ArchivoTexto archivoTexto;
        PuntoTXT puntoTxt;
        PuntoDAT puntoDat;

        private string path = null;
        public Frm_Principal()
        {
            InitializeComponent();
            archivoTexto = new ArchivoTexto();
            puntoTxt = new PuntoTXT();
            puntoDat = new PuntoDAT();
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione el archivo a abrir";
            openFileDialog.Filter = "Archivos de texto (.txt) |*.txt|Archivos de datos (.dat)|*.dat||*.*";
            string lectura;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                try {
                    lectura = archivoTexto.Leer(path);
                    rchTextBox.Text = lectura;
                    MessageBox.Show("Cargado con exito", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void rchTextBox_TextChanged(object sender, EventArgs e)
        {
            StatusLabel.Text = $"{rchTextBox.Text.Length} caracteres";
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Seleccione el archivo a guardar";
            saveFileDialog1.Filter = "Archivos de texto (.txt) |*.txt|Archivos de datos (.dat)|*.dat||*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                try
                {
                    archivoTexto.Guardar(rchTextBox.Text, path);
                    MessageBox.Show("Guardado con exito", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(path == null)
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                try
                {
                    archivoTexto.Guardar(rchTextBox.Text, path);
                    MessageBox.Show("Guardado con exito", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }
    }
}
