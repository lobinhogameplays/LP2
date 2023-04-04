using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LblDescIRPF_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salarioBruto, INSS = 0, descINSS, IRPF = 0, descIRPF = 0, salarioLiquido, salarioFamilia = 0;
            string nome = txtNome.Text, estadoCivil, sexo, dependentes = cbxDependentes.Text;

            if (!double.TryParse(mskbxSalBruto.Text, out salarioBruto) || salarioBruto == 0)
            {
                MessageBox.Show("Salário bruto inválido");
            }
            else
            {
                if (ckbxCasamento.Checked)
                {
                    estadoCivil = "casado(a)";

                }
                else
                {
                    estadoCivil = "solteiro(a)";
                }

                if (rbtnMasc.Checked)
                {
                    sexo = "masculino";
                    lblDados.Text = $"Os descontos do salário do Sr {nome} que é {estadoCivil} e que tem {dependentes} filhos";
                }
                else if (rbtnFem.Checked)
                {
                    sexo = "feminino";
                    lblDados.Text = $"Os descontos do salário da Sra {nome} que é {estadoCivil} e que tem {dependentes} filhos";
                }

                if (salarioBruto <= 800.47)
                {
                    INSS = 100 * 0.0765;
                    descINSS = salarioBruto * 0.0765;
                }
                else if (salarioBruto <= 1050)
                {
                    INSS = 100 * 0.0865;
                    descINSS = salarioBruto * 0.0865;
                }
                else if (salarioBruto <= 1400.77)
                {
                    INSS = 100 * 0.09;
                    descINSS = salarioBruto * 0.09;
                }
                else if (salarioBruto <= 2801.56)
                {
                    INSS = 100 * 0.11;
                    descINSS = salarioBruto * 0.11;
                }
                else
                {
                    descINSS = 308.17;
                }

                int numdependentes;
                if (int.TryParse(dependentes, out numdependentes))
                {
                    if (salarioBruto <= 435.52)
                    {
                        salarioFamilia = numdependentes * 22.33;
                    }
                    else if (salarioBruto <= 654.61)
                    {
                        salarioFamilia = numdependentes * 15.74;
                    }
                    else
                    {
                        salarioFamilia = 0;
                    }
                }

                if (salarioBruto < 1257.13)
                {
                    IRPF = 0;
                    descIRPF = 0;
                }
                else if (salarioBruto >= 1257.13 && salarioBruto <= 2512.08)
                {
                    IRPF = 100 * 0.15;
                    descIRPF = salarioBruto * 0.15;
                }
                else if (salarioBruto > 2512.08)
                {
                    IRPF = 100 * 0.275;
                    descIRPF = salarioBruto * 0.275;
                }

                salarioLiquido = salarioBruto - descINSS - descIRPF + salarioFamilia;

                txtDescIRPF.Text = $"{descIRPF}";
                txtIRPF.Text = $"{IRPF}%";
                txtDescINSS.Text = $"{descINSS}";
                txtINSS.Text = $"{INSS}%";
                txtSalFam.Text = $"{salarioFamilia}";
                txtSalLiq.Text = $"{salarioLiquido}";

            }
            
            }
        }
    }
