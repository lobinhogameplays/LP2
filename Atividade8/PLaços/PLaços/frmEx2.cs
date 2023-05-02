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
    public partial class frmEx2 : Form
    {
        public frmEx2()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN.Text, out int n) && n > 0)
            {
                double h = 1;

                for (int i = 2; i <= n; i++)
                {
                    h += 1.0 / i;
                }

                MessageBox.Show($"O número H é igual a {h:F2}", "Resultado");
            }
            else
            {
                MessageBox.Show("Digite um valor inteiro maior que zero.", "Erro");
            }
        }
    }
}
