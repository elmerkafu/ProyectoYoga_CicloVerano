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
    public partial class UsuarioMan01 : Form
    {
        ProxyUsuario.ServicioUsuarioClient objServiceUsuario = new ProxyUsuario.ServicioUsuarioClient();
        public UsuarioMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgUsuarios.DataSource = objServiceUsuario.ListarUsuario();
            lblRegistros.Text = dtgUsuarios.Rows.Count.ToString();
        }

        private void UsuarioMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgUsuarios.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioMan02 objUsu02 = new UsuarioMan02();
                objUsu02.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioMan03 objUsu03 = new UsuarioMan03();
                String strLogin = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
                objUsu03.strLogin = strLogin;
                objUsu03.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgUsuarios_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}
