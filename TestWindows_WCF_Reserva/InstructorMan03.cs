using ServiceReference1;
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
    public partial class InstructorMan03 : Form
    {

        ProxyInstructor.ServicioInstructorClient objServiceInstructor = new ProxyInstructor.ServicioInstructorClient();
        ProxyInstructor.InstructorDC objInstructorDC = new ProxyInstructor.InstructorDC();
        public InstructorMan03()
        {
            InitializeComponent();
        }

        public String strId
        {
            get; set;
        }

        private void InstructorMan03_Load(object sender, EventArgs e)
        {

            try
            {
                objInstructorDC = objServiceInstructor.ConsultarInstructor(strId);

                lblCodigo.Text = objInstructorDC.Id_Instructor.ToString();
                txtNombre.Text = objInstructorDC.Nombre;
                txtApePaterno.Text = objInstructorDC.ApePaterno;
                txtApeMaterno.Text = objInstructorDC.ApeMaterno;
                txtCorreo.Text = objInstructorDC.Correo;
                mskTelefono.Text = objInstructorDC.Tel_inst;
                mskDNI.Text = objInstructorDC.Dni_inst;
                txtDireccion.Text = objInstructorDC.Dir_inst;
                dtpFecNac.Value = Convert.ToDateTime(objInstructorDC.Fec_nac);
                chkActivo.Checked = Convert.ToBoolean(objInstructorDC.Est_ins);
                string Id_Ubigeo = objInstructorDC.Id_Ubigeo;
                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Length == 0)
                {
                    throw new Exception("El campo Nombres no puede estar vacio.");
                }

                if (txtApePaterno.Text.Length == 0)
                {
                    throw new Exception("El apellido Paterno no puede estar vacio.");
                }

                if (txtApeMaterno.Text.Length == 0)
                {
                    throw new Exception("El apellido Materno no puede estar vacio.");
                }

                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres.");

                }

                if (mskTelefono.MaskFull == false)
                {
                    throw new Exception("El Teléfono debe tener 9 caracteres.");

                }

                objInstructorDC.Id_Instructor = lblCodigo.Text;
                objInstructorDC.Nombre = txtNombre.Text.Trim();
                objInstructorDC.ApePaterno = txtApePaterno.Text.Trim();
                objInstructorDC.ApeMaterno = txtApeMaterno.Text.Trim();
                objInstructorDC.Correo = txtCorreo.Text.Trim();
                objInstructorDC.Tel_inst = mskTelefono.Text;
                objInstructorDC.Dni_inst = mskDNI.Text;
                objInstructorDC.Dir_inst = txtDireccion.Text.Trim();
                objInstructorDC.Fec_nac = Convert.ToDateTime(dtpFecNac.Value.Date);
                objInstructorDC.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                    cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();
                objInstructorDC.Usu_reg = "Caja";
                objInstructorDC.Est_ins = Convert.ToInt16(chkActivo.Checked);

                if (objServiceInstructor.ActualizarInstructor(objInstructorDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizo el registro, contacte con soporte técnico");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            ServicioUbigeoClient objServiceUbigeo = new ServicioUbigeoClient();

            cboDepartamento.DataSource = objServiceUbigeo.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objServiceUbigeo.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objServiceUbigeo.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }
    }
}
