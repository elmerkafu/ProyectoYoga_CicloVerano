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
    public partial class ReservaMan02 : Form
    {
        ProxyReserva.ServicioReservaClient objServiceReserva = new ProxyReserva.ServicioReservaClient();
        public ReservaMan02()
        {
            InitializeComponent();
        }

        public Int16 intCod
        {
            get; set;
        }

        public void CargarDatos()
        {
            dtgClienteReserva.DataSource = objServiceReserva.ListarReservasCliente(intCod);  // aqui pasamos intCod
            //lblRegistros.Text = dtgCliente.Rows.Count.ToString();
        }



        private void ReservaMan02_Load(object sender, EventArgs e)
        {
            try
            {
                dtgClienteReserva.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
