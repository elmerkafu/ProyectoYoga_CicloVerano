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
    public partial class ConsultaInstructor : Form
    {
        ProxyInstructor.ServicioInstructorClient objServiceInstructor = new ProxyInstructor.ServicioInstructorClient();
        ProxyInstructor.InstructorDC objInstructorDC = new ProxyInstructor.InstructorDC();

        ProxyConsulta.ConsultaInstructorClasesClient objServiceConsultas = new ProxyConsulta.ConsultaInstructorClasesClient();
        ProxyConsulta.ConsultaDC objConsultasDC = new ProxyConsulta.ConsultaDC();


        public ConsultaInstructor()
        {
            InitializeComponent();
        }

        private void ConsultaInstructor_Load(object sender, EventArgs e)
        {
            dtgConsulta.AutoGenerateColumns = false;
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            try
            {
                String strCod = txtCod.Text.Trim();
                objInstructorDC = objServiceInstructor.ConsultarInstructor(strCod);

                if (txtCod.Text.Length == 0)
                {
                    throw new Exception("Ingrese un código de instructor válido");
                }
                else
                {
                    lblNombreCompleto.Text = objInstructorDC.Nombre + ' ' + objInstructorDC.ApePaterno + ' ' + objInstructorDC.ApeMaterno;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un código de instructor válido ");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                String strCod = txtCod.Text.Trim();
                DateTime dtpInicio = dtpIni.Value.Date;
                DateTime dtpFinn = dtpFin.Value.Date;

                if (dtpInicio >= DateTime.Now.Date)
                {
                    dtgConsulta.DataSource = objServiceConsultas.ListarClasesProgramadasInstructor(strCod, dtpInicio);
                }
                if (dtpInicio >= DateTime.Now.Date && dtpFinn > dtpInicio)
                {
                    dtgConsulta.DataSource = objServiceConsultas.ListarClasesEntreFechas(strCod, dtpInicio, dtpFinn);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}

