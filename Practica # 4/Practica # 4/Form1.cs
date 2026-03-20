using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica___4
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,b,c,d;

            a= int.Parse(textBox1.Text);    
            b= int.Parse(textBox2.Text);
            c= int.Parse(textBox3.Text);
            d= int.Parse(textBox4.Text);

           textBox5.Text= d.ToString();
           textBox6.Text= c.ToString();  
           textBox7.Text = b.ToString();
           textBox8.Text = a.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
