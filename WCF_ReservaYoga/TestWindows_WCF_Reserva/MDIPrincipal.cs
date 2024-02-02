using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows_WCF_Reserva
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteMan01 cli01 = new ClienteMan01();
            cli01.MdiParent = this;
            cli01.Show();
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructorMan01 inst01 = new InstructorMan01();
            inst01.MdiParent = this;
            inst01.Show();

        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisciplinaMan01 disc01 = new DisciplinaMan01();
            disc01.MdiParent = this;
            disc01.Show();
        }
    }
}
