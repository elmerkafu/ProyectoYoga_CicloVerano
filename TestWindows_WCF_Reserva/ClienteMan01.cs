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
    public partial class ClienteMan01 : Form
    {

        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();

        public ClienteMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgCliente.DataSource = objServiceCliente.ListarClienteEstado();
            lblRegistros.Text = dtgCliente.Rows.Count.ToString();
        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCliente.AutoGenerateColumns = false;
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
                ClienteMan02 objCli02 = new ClienteMan02();
                objCli02.ShowDialog();

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
                ClienteMan03 objCli03 = new ClienteMan03();

                Int16 strId = Convert.ToInt16(dtgCliente.CurrentRow.Cells[0].Value.ToString());
                objCli03.strId = strId;
                objCli03.ShowDialog();

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

        //Cambio 4
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtgCliente.SelectedRows.Count > 0)
                {

                    DialogResult result = MessageBox.Show("¿Estás seguro de querer eliminar al cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {

                        Comentario comentario1 = new Comentario();
                        Int16 Codigo = Convert.ToInt16(dtgCliente.CurrentRow.Cells[0].Value.ToString());
                        comentario1.Codigo = Codigo;
                        comentario1.ShowDialog();

                        CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un cliente antes de intentar eliminarlo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtgCliente_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}
