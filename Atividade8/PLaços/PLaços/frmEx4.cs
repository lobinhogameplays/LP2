using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLaços
{
    public partial class frmEx4 : Form
    {
        public frmEx4()
        {
            InitializeComponent();
        }

        private void BtnCalculo_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cargo = txtCargo.Text;
            string matricula = txtMatricula.Text;
            int producao = int.Parse(txtProducao.Text);
            decimal salario = decimal.Parse(txtSalario.Text);
            decimal gratificacao = decimal.Parse(txtGratificacao.Text);

            decimal salarioBruto = salario + salario * (0.05m * (producao >= 100 ? 1 : 0) +
                                                         0.1m * (producao >= 120 ? 1 : 0) +
                                                         0.1m * (producao >= 150 ? 1 : 0)) +
                                                         gratificacao;

            if (salarioBruto > 7000.00m && producao < 150)
            {
                MessageBox.Show("O salário bruto não pode ser superior a R$ 7.000,00 para funcionários com produção abaixo de 150 unidades.");
            }
            else
            {
                MessageBox.Show($"Nome: {nome}\nCargo: {cargo}\nMatrícula: {matricula}\nSalário Bruto: R$ {salarioBruto:F2}");
            }
        }
    }
}
