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
    public partial class frmEx3 : Form
    {
        public frmEx3()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text.Trim().ToLower().Replace(" ", "");
            string textoInvertido = new string(texto.Reverse().ToArray());

            if (texto == textoInvertido)
            {
                MessageBox.Show("A sequência é um palíndromo.", "Resultado");
            }
            else
            {
                MessageBox.Show("A sequência não é um palíndromo.", "Resultado");
            }
        }

        private void TxtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
