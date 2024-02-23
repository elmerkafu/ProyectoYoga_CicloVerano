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
    public partial class SalonMan01 : Form
    {
        ProxySalon.ServicioSalonClient objServiceSalon = new ProxySalon.ServicioSalonClient();

        public SalonMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgSalon.DataSource = objServiceSalon.ListarSalon_Grid();
            lblRegistros.Text = dtgSalon.Rows.Count.ToString();
        }

        private void SalonMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgSalon.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtgSalon_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                SalonMan02 objSalon = new SalonMan02();
                objSalon.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SalonMan03 objSalon03 = new SalonMan03();

            Int16 strId = Convert.ToInt16(dtgSalon.CurrentRow.Cells[0].Value.ToString());
            objSalon03.strId = strId;
            objSalon03.ShowDialog();

            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgSalon.SelectedRows.Count > 0)
                {

                    DialogResult result = MessageBox.Show("¿Estás seguro de querer eliminar el salón?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {

                        Comentario03 comentario3 = new Comentario03();
                        Int16 Codigo = Convert.ToInt16(dtgSalon.CurrentRow.Cells[0].Value.ToString());
                        comentario3.Codigo = Codigo;
                        comentario3.ShowDialog();

                        CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un salón antes de intentar eliminarlo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
