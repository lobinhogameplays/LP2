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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exercício2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmExercicio5 objfrm5 = new frmExercicio5();
            objfrm5.MdiParent = this;
            objfrm5.WindowState = FormWindowState.Maximized;
            objfrm5.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Ctrl + C");
        }

        private void ColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Ctrl + V");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 objfrm2 = new frmExercicio2();
            objfrm2.MdiParent = this;
            objfrm2.WindowState = FormWindowState.Maximized;
            objfrm2.Show();
        }

        private void Exercício2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExercicio3 objfrm3 = new frmExercicio3();
            objfrm3.MdiParent = this;
            objfrm3.WindowState = FormWindowState.Maximized;
            objfrm3.Show();
        }

        private void exercício2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmExercicio4 objfrm4 = new frmExercicio4();
            objfrm4.MdiParent = this;
            objfrm4.WindowState = FormWindowState.Maximized;
            objfrm4.Show();
        }
    }
}
