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
    public partial class Comentario05 : Form
    {
        ProxyDisciplina.ServicioDisciplinaClient objServiceDisciplina = new ProxyDisciplina.ServicioDisciplinaClient();
        ProxyDisciplina.DisciplinaDC objDisciplinaDC = new ProxyDisciplina.DisciplinaDC();
        public Comentario05()
        {
            InitializeComponent();
        }

        public String Codigo
        {
            get; set;
        }

        private void Comentario05_Load(object sender, EventArgs e)
        {
            try
            {
                objDisciplinaDC = objServiceDisciplina.ConsultarDisciplina(Codigo);
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

                objDisciplinaDC.Comentario = txtComentario.Text;  // agrega

                if (objServiceDisciplina.UpdateDisciplinaEstado(objDisciplinaDC) == true)
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
