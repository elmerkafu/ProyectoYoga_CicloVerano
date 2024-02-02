using ProxyInstructorDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows_WCF_Reserva
{
    public partial class ClaseProgramadaMan03 : Form
    {

        ProxyClaseProgramada.ServicioClaseProgramadaClient objServiceClaseProgramada = new ProxyClaseProgramada.ServicioClaseProgramadaClient();
        ProxyClaseProgramada.ClaseProgramadaDC objClaseProgramadaDC = new ProxyClaseProgramada.ClaseProgramadaDC();

        ProxySalon.ServicioSalonClient objServiceSalon = new ProxySalon.ServicioSalonClient();
        ProxySalon.SalonDC objSalonDC = new ProxySalon.SalonDC();
        public ClaseProgramadaMan03()
        {
            InitializeComponent();
        }

        public Int16 strId
        {
            get; set;
        }

        private void ClaseProgramadaMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos el combo Salon 
                cboSalon.DataSource = objServiceSalon.ListarSalon();
                cboSalon.DisplayMember = "Nombre";
                cboSalon.ValueMember = "Id_Salon";

                objClaseProgramadaDC = objServiceClaseProgramada.ConsultarClaseProgramada(strId);

                lblCodigo.Text = objClaseProgramadaDC.Id_Clase_Prog.ToString();

                // AQUI REVISAR DEVOLVER DATOS 
                String Id_Inst_Disp = objClaseProgramadaDC.Id_Inst_Disp;
                CargarInsDsp(Id_Inst_Disp.Substring(0, 1), Id_Inst_Disp.Substring(1, 2));

                cboSalon.SelectedValue = objClaseProgramadaDC.Id_Salon;
                dtpFecha.Value = Convert.ToDateTime(objClaseProgramadaDC.Fec_Clase);
                dtpHoraIni.Value = Convert.ToDateTime(objClaseProgramadaDC.Hora_Emp);
                dtpHoraFin.Value = Convert.ToDateTime(objClaseProgramadaDC.Hora_Term);
                chkEstado.Checked = Convert.ToBoolean(objClaseProgramadaDC.Est_clase);

            }
            catch (Exception)
            {
                throw;
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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSalon.Text.Length == 0)
                {
                   throw new Exception("Debe escoger un aula.");
                }
                if (dtpFecha.Text.Length == 0)
                {
                    throw new Exception("Debe escoger una fecha");
                }

                objClaseProgramadaDC.Id_Clase_Prog = Convert.ToInt16(lblCodigo.Text);
                objClaseProgramadaDC.Id_Salon = Convert.ToInt16(cboSalon.SelectedValue);
                objClaseProgramadaDC.Id_Inst_Disp = cboInstructor.SelectedValue.ToString() + cboDisciplina.SelectedValue.ToString();
                objClaseProgramadaDC.Fec_Clase = Convert.ToDateTime(dtpFecha.Value.Date);
                objClaseProgramadaDC.Hora_Emp = Convert.ToDateTime(dtpHoraIni.Value);
                objClaseProgramadaDC.Hora_Term = Convert.ToDateTime(dtpHoraFin.Value);
                objClaseProgramadaDC.Est_clase = Convert.ToInt16(chkEstado.Checked);
                objClaseProgramadaDC.Usu_Ult_Mod = "Roy";

                if (objServiceClaseProgramada.ActualizarClaseProgramada(objClaseProgramadaDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizo el registro, contacte con soporte técnico");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
