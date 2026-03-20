using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;
            cal= double.Parse(textBox1.Text);
            if (cal<7) MessageBox.Show("Reprobado");
            else if (cal>=7 && cal<=10) MessageBox.Show("Aprobado");
           
        }
    }
}
