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
    public partial class Comentario02 : Form
    {
        ProxyInstructor.ServicioInstructorClient objServiceInstructor = new ProxyInstructor.ServicioInstructorClient();
        ProxyInstructor.InstructorDC objInstructorDC = new ProxyInstructor.InstructorDC();
        public Comentario02()
        {
            InitializeComponent();
        }

        public String strId
        {
            get; set;
        }

        private void Comentario02_Load(object sender, EventArgs e)
        {
            try
            {
                objInstructorDC = objServiceInstructor.ConsultarInstructor(strId);
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

                objInstructorDC.Comentario = txtComentario.Text;

                if (objServiceInstructor.UpdateInstructorEstado(objInstructorDC) == true)
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
