using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triângulo
{
    public partial class Form1 : Form
    {
        double ValorA, ValorB, ValorC;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelB_Click(object sender, EventArgs e)
        {

        }

        private void labelC_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVerif_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtValorA.Text, out ValorA) || !double.TryParse(txtValorB.Text, out ValorB) || !double.TryParse(txtValorC.Text, out ValorC))
            {
                MessageBox.Show("Entrada inválida. Todos os valores devem estar preenchidos e ser números.");
            }
            else
            {
                if (ValorA + ValorB <= ValorC || ValorA + ValorC <= ValorB || ValorB + ValorC <= ValorA)
                {
                    MessageBox.Show("Esses valores não podem ser lados de um triângulo.");
                }
                else
                {
                    if (ValorA == ValorB && ValorB == ValorC)
                    {
                        MessageBox.Show("Esses valores formam um triângulo equilátero.");
                    }
                    else if (ValorA == ValorB || ValorA == ValorC || ValorB == ValorC)
                    {
                        MessageBox.Show("Esses valores formam um triângulo isósceles.");
                    }
                    else
                    {
                        MessageBox.Show("Esses valores formam um triângulo escaleno.");
                    }
                }

            }
           
        }
    }
}
