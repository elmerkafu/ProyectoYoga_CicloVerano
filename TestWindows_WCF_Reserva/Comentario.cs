using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows_WCF_Reserva
{
    public partial class Comentario : Form
    {
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();
        public Comentario()
        {
            InitializeComponent();
        }

        public Int16 Codigo
        {
            get; set;
        }

        private void Comentario_Load(object sender, EventArgs e)
        {
            try
            {
                objClienteDC = objServiceCliente.ConsultarCliente(Codigo);
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

                objClienteDC.Comentario = txtComentario.Text;

                if (objServiceCliente.UpdateClienteEstado(objClienteDC) == true)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
