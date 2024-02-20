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
    public partial class UsuarioMan03 : Form
    {
        ProxyUsuario.ServicioUsuarioClient objServiceUsuario = new ProxyUsuario.ServicioUsuarioClient();
        ProxyUsuario.UsuarioDC objUsuarioDC = new ProxyUsuario.UsuarioDC();
        public UsuarioMan03()
        {
            InitializeComponent();
        }
        public String strLogin
        { get; set; }

        private void UsuarioMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objUsuarioDC = objServiceUsuario.ConsultarUsuario(strLogin);

                lblUsuario.Text = objUsuarioDC.Login_Usuario;
                txtPassword.Text = objUsuarioDC.Pass_Usuario;

                cboNivel.Items.Add("-Seleccionar-");
                cboNivel.Items.Add("1");
                cboNivel.Items.Add("2");

                string nivelUsuario = objUsuarioDC.Niv_Usuario.ToString();
                if (cboNivel.Items.Contains(nivelUsuario))
                {
                    cboNivel.SelectedItem = nivelUsuario;
                }
                else
                {
                    cboNivel.SelectedItem = "-Seleccionar-";
                }

                chkEstado.Checked = Convert.ToBoolean(objUsuarioDC.Est_Usuario);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtPassword.Text.Length == 0)
                {
                    throw new Exception("El campo Password no puede estar vacio.");
                }

                //Si todo está validado...

                objUsuarioDC.Pass_Usuario = txtPassword.Text;

                if (cboNivel.SelectedItem != null)
                {
                    objUsuarioDC.Niv_Usuario = Convert.ToInt16(cboNivel.SelectedItem.ToString());
                }
                else 
                {
                    throw new Exception("Por favor, seleccione un nivel de usuario");
                }

                objUsuarioDC.Est_Usuario = Convert.ToInt16(chkEstado.Checked);
                objUsuarioDC.Usu_Registro = "Rivera";

                if (objServiceUsuario.ActualizarUsuario(objUsuarioDC) == true)
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

                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
        }
    }
}
