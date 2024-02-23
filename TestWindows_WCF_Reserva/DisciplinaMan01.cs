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
    public partial class DisciplinaMan01 : Form
    {
        ProxyDisciplina.ServicioDisciplinaClient objServiceDisciplina = new ProxyDisciplina.ServicioDisciplinaClient();

        public DisciplinaMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgDisciplina.DataSource = objServiceDisciplina.ListarDisciplina();
            lblRegistros.Text = dtgDisciplina.Rows.Count.ToString();

        }

        private void DisciplinaMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDisciplina.AutoGenerateColumns = false;
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
                DisciplinaMan02 objDisciplina02 = new DisciplinaMan02();
                objDisciplina02.ShowDialog();

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DisciplinaMan03 objDisciplina03 = new DisciplinaMan03();

            String strCodigo = dtgDisciplina.CurrentRow.Cells[0].Value.ToString();
            objDisciplina03.strCodigo = strCodigo;
            objDisciplina03.ShowDialog();

            // Refrescamos...
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtgDisciplina.SelectedRows.Count > 0)
                {

                    DialogResult result = MessageBox.Show("¿Estás seguro de querer eliminar la disciplina?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {

                        Comentario05 comentario5 = new Comentario05();
                        String Codigo = dtgDisciplina.CurrentRow.Cells[0].Value.ToString();
                        comentario5.Codigo = Codigo;
                        comentario5.ShowDialog();

                        CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una disciplina antes de intentar eliminarlo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtgDisciplina_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }



    }

}
