using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(richTextPalabras.Text))
            {
                Dictionary<string, int> diccionarioPalabras = new Dictionary<string, int>();
                List<string> topPalabaras = new List<string>();

                string palabras = richTextPalabras.Text;
                string[] palabrasArray;
                palabras = palabras.ToLower();
                palabrasArray = palabras.Split('\n');

                StringBuilder sb = new StringBuilder();

                int contador = 0;
                int segundoContador = 0;
                int tercerContador = 0;

                foreach (string palabra in palabrasArray)
                {
                    if (!diccionarioPalabras.ContainsKey(palabra))
                    {
                        diccionarioPalabras.Add(palabra, 1);
                    } else
                    {
                        diccionarioPalabras[palabra] += 1;
                    }
                }

                foreach (KeyValuePair<string, int> palabra in diccionarioPalabras)
                {
                    if (palabra.Value > contador)
                    {
                        contador = palabra.Value;
                        topPalabaras.Insert(0, palabra.Key);
                    }
                    else if (palabra.Value > segundoContador)
                    {
                        segundoContador = palabra.Value;
                        segundoContador++;
                        topPalabaras.Insert(1, palabra.Key);
                    }
                    else if (palabra.Value > tercerContador)
                    {
                        tercerContador = palabra.Value;
                        tercerContador++;
                        topPalabaras.Insert(2, palabra.Key);
                    }
                }

                for(int i = 0; i < 3; i++)
                {
                    sb.AppendLine(topPalabaras[i]);
                }
                richTextPalabras.Text = "\tLa lista de palabras mas utlizadas\n" + sb.ToString();
            } else
            {
                MessageBox.Show("Ingrese palabras para calcular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
