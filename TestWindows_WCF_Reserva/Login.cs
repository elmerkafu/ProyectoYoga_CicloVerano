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
    public partial class Login : Form
    {
        // Declaramos tiempo de intento... 
        Int16 intentos = 0;

        ProxyUsuarioRol.ServicioUsuarioRolClient objServiceUsuarioRol = new ProxyUsuarioRol.ServicioUsuarioRolClient();
        ProxyUsuarioRol.UsuarioRolDC objUsuarioRolDC = new ProxyUsuarioRol.UsuarioRolDC();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != String.Empty & txtPass.Text.Trim() != String.Empty)
            {
                // Obtenemos la informacion del usuario que se pretende loguear                
                String strLogin = txtLogin.Text.Trim();
                objUsuarioRolDC = objServiceUsuarioRol.ConsultarUsuario(strLogin);

                if (objUsuarioRolDC.Login_Usuario_Correo == null) // Si el login ingresado no existe
                {
                    intentos += 1;
                    ValidaAccesos();
                }
                else if (objUsuarioRolDC.Login_Usuario_Correo == txtLogin.Text.Trim() &&
                                            objUsuarioRolDC.Pass_Usuario == txtPass.Text.Trim())
                {
                    // Si se verifico el usuario y contraseña correctas ...
                    this.Hide();
                    //timer1.Enabled = false;
                    clsCredenciales.Usuario = objUsuarioRolDC.Login_Usuario_Correo;
                    clsCredenciales.Password = objUsuarioRolDC.Pass_Usuario;
                    clsCredenciales.Nivel = objUsuarioRolDC.Nivel;
                    // AQUI UNA VEZ ESTE EL MDI DENTRO DEL GUI DESCOMENTAR LO DE ABAJO:
                    MDIPrincipal objMDI = new MDIPrincipal();
                    objMDI.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();
                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }
        }
        

        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

    }
}
