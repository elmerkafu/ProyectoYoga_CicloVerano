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
    public partial class Comentario04 : Form
    {
        ProxyUsuario.ServicioUsuarioClient objServiceUsuario = new ProxyUsuario.ServicioUsuarioClient();
        ProxyUsuario.UsuarioDC objUsuarioDC = new ProxyUsuario.UsuarioDC();
        public Comentario04()
        {
            InitializeComponent();
        }

        public String Codigo
        {
            get; set;
        }

        private void Comentario04_Load(object sender, EventArgs e)
        {
            try
            {
                objUsuarioDC = objServiceUsuario.ConsultarUsuario(Codigo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtComentario.Text.Length == 0)
                {
                    throw new Exception("Debe ingresar un comentario.");
                }

                objUsuarioDC.Comentario = txtComentario.Text;  // Actualizar Modelo BD y Proxy

                if (objServiceUsuario.UpdateUsuarioEstado(objUsuarioDC) == true)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
