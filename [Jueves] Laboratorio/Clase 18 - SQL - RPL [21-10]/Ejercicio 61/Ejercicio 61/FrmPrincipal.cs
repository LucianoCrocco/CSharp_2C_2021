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


namespace Ejercicio_61
{
    public partial class FrmPrincipal : Form
    {
        PersonaDAO personaDAO;
        Persona persona;
        public FrmPrincipal()
        {
            InitializeComponent();
            personaDAO = new PersonaDAO();
            persona = new Persona("", "");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNombre.Text) && !String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                persona.Apellido = txtApellido.Text;
                persona.Nombre = txtNombre.Text;
               personaDAO.Guardar(persona);
                ActualizarLista();
            }
        }

        private void ActualizarLista()
        {

            string aux;
            this.lstPersonas.Items.Clear();
            foreach(Persona persona in personaDAO.Leer())
            {
                aux = $"{persona.Id}, {persona.Nombre}, {persona.Apellido}";
                this.lstPersonas.Items.Add(aux);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(lstPersonas.SelectedItem is not null)
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.Id = persona.BuscarID(lstPersonas.SelectedItem.ToString());
                personaDAO.Modificar(persona);
                ActualizarLista();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (lstPersonas.SelectedItem is not null)
            {
                id = persona.BuscarID(lstPersonas.SelectedItem.ToString());
                personaDAO.Borrar(id);
                ActualizarLista();
            }
        }
    }
}
