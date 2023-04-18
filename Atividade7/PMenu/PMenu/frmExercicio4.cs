using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (int i = 0; i < rchtxtInput.Text.Length; i++)
            {
                if (Char.IsNumber(rchtxtInput.Text[i]))
                {
                    contador++;
                }
            }
            MessageBox.Show($"Foram encontrados {contador} caracteres numéricos.");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int posicao = 0;
            while (posicao < rchtxtInput.Text.Length && !Char.IsWhiteSpace(rchtxtInput.Text[posicao]))
            {
                posicao++;
            }
            MessageBox.Show($"O primeiro caracter em branco está na posição {posicao}.");
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (char c in rchtxtInput.Text)
            {
                if (Char.IsLetter(c))
                {
                    contador++;
                }
            }
            MessageBox.Show($"Foram encontrados {contador} caracteres alfabéticos.");
        }
    }
}
