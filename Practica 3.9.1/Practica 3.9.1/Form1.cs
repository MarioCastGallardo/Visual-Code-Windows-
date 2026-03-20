using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._9._1
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong numero = ulong.Parse(textBox1.Text);
            ulong factorial = 1;
            for (ulong i = 1; i <= numero; i++)
            {
              listBox1.Items.Add(i);
                factorial = factorial * i;
            }
        textBox2.Text = numero.ToString();
            textBox3.Text = factorial.ToString();
        }

    }
}
