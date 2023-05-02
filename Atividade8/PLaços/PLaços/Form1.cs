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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx1 objfrm1 = new frmEx1();
            objfrm1.MdiParent = this;
            objfrm1.WindowState = FormWindowState.Maximized;
            objfrm1.Show();
        }

        private void Ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx2 objfrm2 = new frmEx2();
            objfrm2.MdiParent = this;
            objfrm2.WindowState = FormWindowState.Maximized;
            objfrm2.Show();
        }

        private void Ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx3 objfrm3 = new frmEx3();
            objfrm3.MdiParent = this;
            objfrm3.WindowState = FormWindowState.Maximized;
            objfrm3.Show();
        }

        private void Ex4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx4 objfrm4 = new frmEx4();
            objfrm4.MdiParent = this;
            objfrm4.WindowState = FormWindowState.Maximized;
            objfrm4.Show();
        }
    }
}
