using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01___El_delegado
{
    public partial class FrmPrincipal : Form
    {
        private FrmMostrar frmMostrar;
        private FrmTestDelegados frmTestDelegados;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
            frmTestDelegados.MdiParent = this;
            mostrarToolStripMenuItem.Enabled = false;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }
    }
}
