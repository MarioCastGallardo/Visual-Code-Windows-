using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBoxEdad.Text = "";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEvaluar_Click(object sender, EventArgs e)
        {
            {
                int edad;

                if (!int.TryParse(textBoxEdad.Text, out edad))
                {
                    MessageBox.Show("Ingresa una edad válida");
                    return;
                }

                if (edad < 12)
                {
                    labelResultado.Text = "Es un Niño";
                }
                else if (edad < 18)
                {
                    labelResultado.Text = "Es un Adolescente";
                }
                else if (edad < 60)
                {
                    labelResultado.Text = "Es un Adulto";
                }
                else
                {
                    labelResultado.Text = "Es un Adulto Mayor";
                }
            }
        }
    }
}
