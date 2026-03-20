using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            { 
            int A, B, C;

            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = int.Parse(textBox3.Text);

            if (A >= B && B >= C)
            {
                textBox4.Text = A.ToString();
                textBox5.Text = B.ToString();
                textBox6.Text = C.ToString();
            }
            else if (A >= C && C >= B)
            {
                textBox4.Text = A.ToString();
                textBox5.Text = C.ToString();
                textBox6.Text = B.ToString();
            }
            else if (B >= A && A >= C)
            {
                textBox4.Text = B.ToString();
                textBox5.Text = A.ToString();
                textBox6.Text = C.ToString();
            }
            else if (B >= C && C >= A)
            {
                textBox4.Text = B.ToString();
                textBox5.Text = C.ToString();
                textBox6.Text = A.ToString();
            }
            else if (C >= A && A >= B)
            {
                textBox4.Text = C.ToString();
                textBox5.Text = A.ToString();
                textBox6.Text = B.ToString();
            }
            else
            {
                textBox4.Text = C.ToString();
                textBox5.Text = B.ToString();
                textBox6.Text = A.ToString();
            }
        }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

