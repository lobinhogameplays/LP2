using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        double Altura, Peso;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out Altura) || !double.TryParse(txtPeso.Text, out Peso))
            {
                MessageBox.Show("Valores Inválidos");
            }
            else
            {
                double IMC = Peso / (Altura * Altura);
                txtIMC.Text = IMC.ToString("N2");
                if (IMC < 18.5)
                {
                    MessageBox.Show("Classificação: Magreza");
                }
                if (IMC >= 18.5 && IMC <= 24.9)
                {
                    MessageBox.Show("Classificação: Normal");
                }
                if (IMC >= 25 && IMC <= 29.9)
                {
                    MessageBox.Show("Classificação: Sobrepeso");
                    MessageBox.Show("Obesidade: Grau I");
                }
                if (IMC >= 30 && IMC <= 39.9)
                {
                    MessageBox.Show("Classificação: Obesidade");
                    MessageBox.Show("Obesidade: Grau II");
                }
                if (IMC >= 40)
                {
                    MessageBox.Show("Classificação: Obesidade Grave");
                    MessageBox.Show("Obesidade: Grau III");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelPeso_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
