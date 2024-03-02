﻿using System;
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

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClaseProgramadaMan01 clas01 = new ClaseProgramadaMan01();
            clas01.MdiParent = this;
            clas01.Show();
        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalonMan01 sal01 = new SalonMan01();
            sal01.MdiParent = this;
            sal01.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UsuarioMan01 usu01 = new UsuarioMan01();
            //usu01.MdiParent = this;
            //usu01.Show();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservaMan01 res01 = new ReservaMan01();
            res01.MdiParent = this;
            res01.Show();
        }
    }
}
