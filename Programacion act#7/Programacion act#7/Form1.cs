using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_act_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, farh1;
            v1 = double.Parse(Valor.Text);
            farh1 = (v1 * 9.0 / 5.0) + 32.0;  
            Resultado.Text= farh1.ToString();
            label2.Text = "Fahrenheit";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(Valor.Text);
            cent1 = (v1 - 32.0) * (5.0 / 9.0);
            Resultado.Text = cent1.ToString();
            label2.Text = "Centrigados";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Valor.Text = "";
            Resultado.Text = "Resultado";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
