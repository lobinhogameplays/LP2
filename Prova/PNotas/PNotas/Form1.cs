using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            char[,] alunos = new char[10, 10];
            char[] gabarito = new char[10] { 'A', 'B', 'C', 'D', 'A', 'B', 'C', 'D', 'A', 'B'};

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    if (!char.TryParse(Microsoft.VisualBasic.Interaction.InputBox($"Digite a {j + 1}º resposta para o {i + 1}º aluno:"), out alunos[i, j]))
                    {
                        MessageBox.Show("Entrada inválida");
                        j--;
                    }
                    else if(alunos[i, j] != 'A' && alunos[i, j] != 'B' && alunos[i, j] != 'C' && alunos[i, j] != 'D' && alunos[i, j] != 'E')
                    {
                        MessageBox.Show("Entrada inválida");
                        j--;
                    }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (alunos[i, j] == gabarito[j])
                        lbxRespostas.Items.Add($"O aluno:{i+1} acertou a questão {j+1} era {gabarito[j]} escolheu {alunos[i, j]}");
                    else
                        lbxRespostas.Items.Add($"O aluno:{i+1} errou a questão {j+1} era {gabarito[j]} escolheu {alunos[i, j]}");
                }

            }
        }

        private void LbxRespostas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
