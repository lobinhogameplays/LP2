using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double N1, N2, Result;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
        }

        private void TxtN2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtN2.Text, out N2))
            {
                MessageBox.Show("Numero Inválido");
            }
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtN1.Text, out N1)) && (double.TryParse(txtN2.Text, out N2)))
            {
                Result = N1 + N2;
                txtN3.Text = Result.ToString();
            }
            else {
                MessageBox.Show("Valor Inválido");
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtN1.Text, out N1)) && (double.TryParse(txtN2.Text, out N2)))
            {
                Result = N1 - N2;
                txtN3.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("Valor Inválido");
            }
        }

        private void BtnMpy_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtN1.Text, out N1)) && (double.TryParse(txtN2.Text, out N2)))
            {
                Result = N1 * N2;
                txtN3.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("Valor Inválido");
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtN1.Text, out N1)) && (double.TryParse(txtN2.Text, out N2) && (N2 != 0)))

            {
                Result = N1 / N2;
                txtN3.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("Valor Inválido");
            }
        }

        private void txtN3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtN1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtN1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtN1.Text, out N1))
            {
                MessageBox.Show("Numero Inválido");
            }
                
        }
    }
}
