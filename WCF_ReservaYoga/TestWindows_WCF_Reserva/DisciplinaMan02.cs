using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security.Tokens;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows_WCF_Reserva
{
    public partial class DisciplinaMan02 : Form
    {
        ProxyDisciplina.ServicioDisciplinaClient objServiceDisciplina = new ProxyDisciplina.ServicioDisciplinaClient();
        ProxyDisciplina.DisciplinaDC objDisciplinaDC = new ProxyDisciplina.DisciplinaDC();

        public DisciplinaMan02()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisciplinaMan02_Load(object sender, EventArgs e)
        {
            try
            {
                // Codificamos la carga del combo cboCategorias... 
                cboCategoria.DataSource = objServiceDisciplina.ListarCategoria();
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.ValueMember = "Id_Cat";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Length == 0)
                {
                    throw new Exception("El campo Nombre no puede estar vacio.");
                }

                if (txtDuracion.Text.Length == 0)
                {
                    throw new Exception("La duración no puede estar vacía.");
                }

                if (txtIntensidad.Text.Length == 0)
                {
                    throw new Exception("La duración no puede estar vacía.");
                }

                if (mskPrecio.Text == "")
                {
                    throw new Exception("Se debe ingresar un precio.");
                }

                // Si todo está validado... 
                objDisciplinaDC.Nombre = txtNombre.Text;
                objDisciplinaDC.Duracion = txtDuracion.Text;
                objDisciplinaDC.Intensidad = txtIntensidad.Text;
                objDisciplinaDC.Precio = Convert.ToSingle(mskPrecio.Text);
                objDisciplinaDC.Id_Cat = Convert.ToInt16(cboCategoria.SelectedValue);

                // Se invoca a la operación de inserción 
                if (objServiceDisciplina.InsertarDisciplina(objDisciplinaDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se insertó el registro, conecte con TI");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }
    }
}
