using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(radioCirc.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);
            areaCir.Text = area1.ToString();
            VolumenCir.Text = volumen1.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            {
                double basetri, alturatri, areatri;

                basetri = double.Parse(txtBaseTri.Text);
                alturatri = double.Parse(txtAlturaTri.Text);

                areatri = (basetri * alturatri) / 2;

                txtAreaTri.Text = areatri.ToString();
            }
        }
        private void btnCalcularTri_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularCubo_Click(object sender, EventArgs e)
        {

            {
                double lado, area, volumen;

                lado = double.Parse(txtLadoCubo.Text);

                area = 6 * Math.Pow(lado, 2);
                volumen = Math.Pow(lado, 3);

                txtAreaCubo.Text = area.ToString();
                txtVolumenCubo.Text = volumen.ToString();
            }
        }

        private void btnCalcularCil_Click(object sender, EventArgs e)


        {
            double radio, altura, area, volumen;
            double pi = 3.1416;

            radio = double.Parse(txtRadioCil.Text);
            altura = double.Parse(txtAlturaCil.Text);

            area = 2 * pi * Math.Pow(radio, 2) + 2 * pi * radio * altura;
            volumen = pi * Math.Pow(radio, 2) * altura;

            txtAreaCil.Text = area.ToString();
            txtVolumenCil.Text = volumen.ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularRombo_Click(object sender, EventArgs e)
        {
            double D, d, area;

            D = double.Parse(txtDiagMayor.Text);
            d = double.Parse(txtDiagMenor.Text);

            area = (D * d) / 2;

            txtAreaRombo.Text = area.ToString();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularOct_Click(object sender, EventArgs e)
        {
            double lado, area, volumen;

            lado = double.Parse(txtLadoOct.Text);

            area = 2 * Math.Sqrt(3) * Math.Pow(lado, 2);
            volumen = (Math.Sqrt(2) / 3) * Math.Pow(lado, 3);

            txtAreaOct.Text = area.ToString();
            txtVolumenOct.Text = volumen.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarTri_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }
    }
}

