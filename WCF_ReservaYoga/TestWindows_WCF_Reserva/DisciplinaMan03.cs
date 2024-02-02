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
    public partial class DisciplinaMan03 : Form
    {
        ProxyDisciplina.ServicioDisciplinaClient objServiceDisciplina = new ProxyDisciplina.ServicioDisciplinaClient();
        ProxyDisciplina.DisciplinaDC objDisciplinaDC = new ProxyDisciplina.DisciplinaDC();

        public DisciplinaMan03()
        {
            InitializeComponent();
        }
        public String strCodigo
        {
            get; set;
        }

        private void DisciplinaMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos el combo Categoria 
                cboCategoria.DataSource = objServiceDisciplina.ListarCategoria();
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.ValueMember = "Id_Cat";

                // Mostramos los datos del vendedor que se va a actualizar
                objDisciplinaDC = objServiceDisciplina.ConsultarDisciplina(strCodigo);

                lblCodigo.Text = objDisciplinaDC.Cod_disp;
                txtNombre.Text = objDisciplinaDC.Nombre;
                txtDuracion.Text = objDisciplinaDC.Duracion;
                txtIntensidad.Text = objDisciplinaDC.Intensidad;
                mskPrecio.Text = objDisciplinaDC.Precio.ToString();
                cboCategoria.SelectedValue = objDisciplinaDC.Id_Cat;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Agregar validaciones
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

                // Validaciones de negocio ???

                // si todo está validado 
                objDisciplinaDC.Cod_disp = lblCodigo.Text;
                objDisciplinaDC.Nombre = txtNombre.Text;
                objDisciplinaDC.Duracion = txtDuracion.Text;
                objDisciplinaDC.Intensidad = txtIntensidad.Text;
                objDisciplinaDC.Precio = Convert.ToSingle(mskPrecio.Text);
                objDisciplinaDC.Id_Cat = Convert.ToInt16(cboCategoria.SelectedValue);

                // Se invoca la operacion de actualizacion 
                if (objServiceDisciplina.ActualizarDisciplina(objDisciplinaDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó el registro, contacte con TI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
