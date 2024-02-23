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
    public partial class UsuarioMan02 : Form
    {
        ProxyUsuario.ServicioUsuarioClient objServiceUsuario = new ProxyUsuario.ServicioUsuarioClient();
        ProxyUsuario.UsuarioDC objUsuarioDC = new ProxyUsuario.UsuarioDC();
        public UsuarioMan02()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Length == 0)
                {
                    throw new Exception("El campo Usuario no puede estar vacio.");
                }

                if (txtPassword.Text.Length == 0)
                {
                    throw new Exception("El campo Password no puede estar vacio.");
                }

                //Si todo está validado...

                objUsuarioDC.Login_Usuario = txtUsuario.Text;
                objUsuarioDC.Pass_Usuario = txtPassword.Text;
                objUsuarioDC.Niv_Usuario = Convert.ToInt16(cboNivel.SelectedValue);
                objUsuarioDC.Est_Usuario = Convert.ToInt16(chkEstado.Checked);
                objUsuarioDC.Usu_Registro = "Rivera";
                

                if (objServiceUsuario.InsertarUsuario(objUsuarioDC) == true)
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

        private void UsuarioMan02_Load(object sender, EventArgs e)
        {
            try
            {
                cboNivel.Items.Add("-Seleccionar-");
                cboNivel.Items.Add("1");
                cboNivel.Items.Add("2");

                cboNivel.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los niveles de usuario: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
