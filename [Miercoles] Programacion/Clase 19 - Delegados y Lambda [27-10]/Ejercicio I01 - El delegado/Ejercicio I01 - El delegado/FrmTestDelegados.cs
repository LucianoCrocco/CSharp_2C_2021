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
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizarNombreDelegado(string nombre);
        private ActualizarNombreDelegado actualizarNombreDelegado;

        public FrmTestDelegados(ActualizarNombreDelegado actualizarNombreDelegado)
        {
            InitializeComponent();
            this.actualizarNombreDelegado = actualizarNombreDelegado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarNombreDelegado.Invoke(txtNombre.Text);
        }
    }
}
