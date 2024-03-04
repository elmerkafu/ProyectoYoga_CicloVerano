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
            // AQUI: CUANDO EXISTE FORM 1 DE USUARIO, CAMBIAR
            UsuarioMan02 usu01 = new UsuarioMan02();
            usu01.MdiParent = this;
            usu01.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservaMan01 res01 = new ReservaMan01();
            res01.MdiParent = this;
            res01.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = clsCredenciales.Usuario;

            // Manejamos la seguridad por roles 
            // Aqui en Load que es cuando carga la plantilla, vamos a validar el nivel 
            if (clsCredenciales.Nivel == 1 | clsCredenciales.Nivel == 2)
            {
                mantenimientosToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
                reservaToolStripMenuItem.Visible = true;
                salirDelSistemaToolStripMenuItem.Visible = true;
            }
            else if (clsCredenciales.Nivel == 3)
            {
                consultasToolStripMenuItem.Visible = true;
                reservaToolStripMenuItem.Visible = true;
                salirDelSistemaToolStripMenuItem.Visible = true;
                mantenimientosToolStripMenuItem.Visible = false;
            }
            else
            {
                consultasToolStripMenuItem.Visible = true;
                reservaToolStripMenuItem.Visible = false;
                salirDelSistemaToolStripMenuItem.Visible = true;
                mantenimientosToolStripMenuItem.Visible = false;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaInstructor con01 = new ConsultaInstructor();
            con01.MdiParent = this;
            con01.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
