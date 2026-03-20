using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = ""; 
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double c1, c2, c3, c4, promedio;

                if (!double.TryParse(textBox1.Text, out c1) ||
                    !double.TryParse(textBox2.Text, out c2) ||
                    !double.TryParse(textBox3.Text, out c3) ||
                    !double.TryParse(textBox4.Text, out c4))
                {
                    MessageBox.Show("Ingresa calificaciones válidas.");
                    return;
                }

                promedio = (c1 + c2 + c3 + c4) / 4;

                if (promedio >= 6 && c1 >= 6 && c2 >= 6 && c3 >= 6 && c4 >= 6)
                {
                    MessageBox.Show("Promedio: " + promedio.ToString("0.00") + "\nAprobado");
                }
                else
                {
                    MessageBox.Show("Promedio: " + promedio.ToString("0.00") + "\nReprobado");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
