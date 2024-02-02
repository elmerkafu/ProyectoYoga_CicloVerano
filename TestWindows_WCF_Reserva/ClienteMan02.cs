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
    public partial class ClienteMan02 : Form
    {
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();


        public ClienteMan02()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombres.Text.Length == 0)
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

                objClienteDC.Nombres = txtNombres.Text.Trim();
                objClienteDC.ApePaterno = txtApePaterno.Text.Trim();
                objClienteDC.ApeMaterno = txtApeMaterno.Text.Trim();
                objClienteDC.Correo = txtCorreo.Text.Trim();
                objClienteDC.Tel_cli = mskTelefono.Text;
                objClienteDC.Dni_cli = mskDNI.Text;
                objClienteDC.Dir_cli = txtDireccion.Text.Trim();
                objClienteDC.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                    cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();


                //Cambio 1
                if (optMasculino.Checked == true)
                {
                    objClienteDC.Sexo = "M";
                }
                else
                {
                    objClienteDC.Sexo = "F";
                }

                objClienteDC.Fec_nac = Convert.ToDateTime(dtpFecNac.Value.Date);

                objClienteDC.Usu_reg = "Rivera";
                objClienteDC.Est_cli = Convert.ToInt16(chkActivo.Checked);

                if (objServiceCliente.InsertarCliente(objClienteDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se insertó el registro, contacte con soporte técnico");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void ClienteMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
