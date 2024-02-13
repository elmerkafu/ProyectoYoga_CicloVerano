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
    public partial class InstructorMan01 : Form
    {

        ProxyInstructor.ServicioInstructorClient objServiceInstructor = new ProxyInstructor.ServicioInstructorClient();
        public InstructorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgInstructor.DataSource = objServiceInstructor.ListarInstructorEstado();
            lblRegistros.Text = dtgInstructor.Rows.Count.ToString();
        }

        private void InstructorMan01_Load(object sender, EventArgs e)
        {

            try
            {
                dtgInstructor.AutoGenerateColumns = false;
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
                InstructorMan02 objIns02 = new InstructorMan02();
                objIns02.ShowDialog();

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
                InstructorMan03 objIns03 = new InstructorMan03();

                String strId = dtgInstructor.CurrentRow.Cells[0].Value.ToString();
                objIns03.strId = strId;
                objIns03.ShowDialog();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {

                if (dtgInstructor.SelectedRows.Count > 0)
                {

                    DialogResult result = MessageBox.Show("¿Estás seguro de querer eliminar al instructor?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        Comentario02 Comentario02 = new Comentario02();
                        String strId = dtgInstructor.CurrentRow.Cells[0].Value.ToString();
                        Comentario02.strId = strId;
                        Comentario02.ShowDialog();

                        CargarDatos();
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un instructor antes de intentar eliminarlo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dtgInstructor_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}
