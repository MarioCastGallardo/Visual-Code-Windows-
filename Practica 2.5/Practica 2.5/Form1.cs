using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num= int.Parse(textBox1.Text);
            if (num % 2==0) MessageBox.Show("EL NUMERO ES PAR");
            else
                if (num %3 == 0) MessageBox.Show("El NUMERO ES IMPAR Y ES DIVISIBLE POR 3");
            else MessageBox.Show("EL NUMERO ES IMPAR Y NO ES DIVISIBLE POR 3");
        }
    }
}
