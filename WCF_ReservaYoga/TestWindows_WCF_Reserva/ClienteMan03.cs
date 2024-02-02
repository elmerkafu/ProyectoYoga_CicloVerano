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
    public partial class ClienteMan03 : Form
    {
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();

        public ClienteMan03()
        {
            InitializeComponent();
        }

        public Int16 strId
        {
            get; set;
        }

        private void ClienteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objClienteDC = objServiceCliente.ConsultarCliente(strId);

                txtId.Text = objClienteDC.Id_Cliente.ToString();
                txtNombres.Text = objClienteDC.Nombres;
                txtApePaterno.Text = objClienteDC.ApePaterno;
                txtApeMaterno.Text = objClienteDC.ApeMaterno;
                txtCorreo.Text = objClienteDC.Correo;
                mskTelefono.Text = objClienteDC.Tel_cli;
                mskDNI.Text = objClienteDC.Dni_cli;
                txtDireccion.Text = objClienteDC.Dir_cli;
                dtpFecNac.Value = Convert.ToDateTime(objClienteDC.Fec_nac);
                string Id_Ubigeo = objClienteDC.Id_Ubigeo;
                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));


                //Cambio 3
                if (objClienteDC.Sexo == "M")
                {
                    optMasculino.Checked = true;
                }
                else if (objClienteDC.Sexo == "F")
                {
                    optFemenino.Checked = true;
                }
                else
                {

                }

                chkActivo.Checked = Convert.ToBoolean(objClienteDC.Est_cli);
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

                objClienteDC.Id_Cliente = Convert.ToInt16(txtId.Text);
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

                //Cambio 3
                if (optMasculino.Checked == true)
                {
                    objClienteDC.Sexo = "M";
                }
                else
                {
                    objClienteDC.Sexo = "F";
                }

                objClienteDC.Fec_nac = Convert.ToDateTime(dtpFecNac.Value.Date);
                objClienteDC.Usu_Ult_Mod = "Rivera";
                objClienteDC.Est_cli = Convert.ToInt16(chkActivo.Checked);

                if (objServiceCliente.ActualizarCliente(objClienteDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó el registro, contacte con soporte técnico");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
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
