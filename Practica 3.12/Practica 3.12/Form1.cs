using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double sueldo = double.Parse(textBox1.Text);
            listBox1.Items.Add(sueldo);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double nomina = 0;
            foreach (var item in listBox1.Items)

            {
                nomina += Convert.ToDouble(item);
            }
            labelResultado.Text = "Nomina =" + nomina;
        }
    }
}
