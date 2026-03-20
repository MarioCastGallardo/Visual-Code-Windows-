using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rangoinferior , rangosuperior, suma = 0;

            rangoinferior = int.Parse(textBox1.Text);
            rangosuperior = int.Parse(textBox2.Text);
            for(int i = rangoinferior; i <= rangosuperior; i++) 

            {
                listBox1.Items.Add(i);  

                suma += i;
            }
            textBox3.Text = suma.ToString();    
        }
    }
}
