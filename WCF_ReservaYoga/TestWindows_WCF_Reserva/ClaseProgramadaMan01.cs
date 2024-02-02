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
    public partial class ClaseProgramadaMan01 : Form
    {
        ProxyClaseProgramada.ServicioClaseProgramadaClient objServiceClaseProgramada = new ProxyClaseProgramada.ServicioClaseProgramadaClient();

        public ClaseProgramadaMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgClaseProgramada.DataSource = objServiceClaseProgramada.ListarClaseProgramada();
            lblRegistros.Text = dtgClaseProgramada.Rows.Count.ToString();
        }

        private void ClaseProgramadaMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgClaseProgramada.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseProgramadaMan02 objClaseP02 = new ClaseProgramadaMan02();
                objClaseP02.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
