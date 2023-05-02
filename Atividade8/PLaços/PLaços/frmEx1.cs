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
    public partial class frmEx1 : Form
    {
        string texto = "";
        public frmEx1()
        {
            InitializeComponent();
        }

        private void BtnBrancos_Click(object sender, EventArgs e)
        {
            texto = rtbxTexto.Text;
            int numEspacos = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ')
                {
                    numEspacos++;
                }
            }

            MessageBox.Show(numEspacos.ToString());
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            texto = rtbxTexto.Text;
            int numR = 0;

            foreach (char c in texto)
            {
                if (c == 'R' || c == 'r')
                {
                    numR++;
                }
            }
            MessageBox.Show(numR.ToString());
        }

        private void BtnPares_Click(object sender, EventArgs e)
        {
            texto = rtbxTexto.Text;
            int numPares = 0;

            for (int i = 0; i < texto.Length - 1; i++)
            {
                if (texto[i] == texto[i + 1])
                {
                    numPares++;
                }
            }
            MessageBox.Show(numPares.ToString());
        }
    }
}
