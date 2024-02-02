using ProxyInstructorDisciplina;
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
    public partial class ClaseProgramadaMan02 : Form
    {
        ProxyClaseProgramada.ServicioClaseProgramadaClient objServiceClaseProg = new ProxyClaseProgramada.ServicioClaseProgramadaClient();
        ProxyClaseProgramada.ClaseProgramadaDC objClaseProgDC = new ProxyClaseProgramada.ClaseProgramadaDC();

        ProxyInstructor.ServicioInstructorClient objServiceInstructor = new ProxyInstructor.ServicioInstructorClient();
        ProxyInstructor.InstructorDC objInstructorDC = new ProxyInstructor.InstructorDC();

        ProxySalon.ServicioSalonClient objServiceSalon = new ProxySalon.ServicioSalonClient();


        public ClaseProgramadaMan02()
        {
            InitializeComponent();
        }

        private void ClaseProgramadaMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarInsDsp("I01", "D04");

                // cargamos combo salon 
                cboSalon.DataSource = objServiceSalon.ListarSalon();
                cboSalon.DisplayMember = "Nombre";
                cboSalon.ValueMember = "Id_Salon";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objClaseProgDC.Id_Inst_Disp = cboInstructor.SelectedValue.ToString() + cboDisciplina.SelectedValue.ToString();
                objClaseProgDC.Id_Salon = Convert.ToInt16(cboSalon.SelectedValue);
                objClaseProgDC.Fec_Clase = Convert.ToDateTime(dtpFecha.Value.Date);
                objClaseProgDC.Hora_Emp = Convert.ToDateTime(dtpHoraIni.Value);
                objClaseProgDC.Hora_Term = Convert.ToDateTime(dtpHoraFin.Value);
                objClaseProgDC.Est_clase = Convert.ToInt16(chkEstado.Checked);
                objClaseProgDC.Usu_reg = "Elmer";

                if (objServiceClaseProg.InsertarClaseProgramada(objClaseProgDC) == true)
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
                throw new Exception(ex.Message);
            }
        }

        private void CargarInsDsp(String Id_Instructor, String Cod_disp)
        {
            ServicioInstructorDisciplinaClient objServiceInsDsp = new ServicioInstructorDisciplinaClient();

            cboInstructor.DataSource = objServiceInsDsp.Instructor();
            cboInstructor.ValueMember = "Id_Instructor";
            cboInstructor.DisplayMember = "NombreInstructor";
            cboInstructor.SelectedValue = Id_Instructor;

            cboDisciplina.DataSource = objServiceInsDsp.Instructor_Disciplina_Combo(Id_Instructor);
            cboDisciplina.ValueMember = "Cod_disp";
            cboDisciplina.DisplayMember = "NombreDisciplina";
            cboDisciplina.SelectedValue = Cod_disp;
        }

        private void cboInstructor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarInsDsp(cboInstructor.SelectedValue.ToString(), "I01");
        }
    }
}
