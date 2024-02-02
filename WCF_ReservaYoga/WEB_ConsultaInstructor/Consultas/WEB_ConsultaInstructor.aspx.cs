using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Agregar...
using WEB_ConsultaInstructor.ProxyConsultaClase;
using WEB_ConsultaInstructor.ProxyInstructor;


namespace WEB_ConsultaInstructor.Consultas
{
    public partial class WEB_ConsultaInstructor : System.Web.UI.Page
    {
        // Creamos instancias de los servicios...
        ConsultaInstructorClasesClient objServiceInstructorClases = new ConsultaInstructorClasesClient();
        ServicioInstructorClient objServiceInstructor = new ServicioInstructorClient();

        // Creamos una instancia de la data contractual 
        InstructorDC objInstructorDC = new InstructorDC();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                objInstructorDC = objServiceInstructor.ConsultarInstructor(txtCod.Text.Trim());

                if(objInstructorDC.Id_Instructor == "")
                {
                    // si el instructor ingresado no existe, limpiamos las cajas
                    txtNombre.Text = "";
                    txtCorreo.Text = "";
                    txtDNI.Text = "";
                    txtDireccion.Text = "";
                    txtTelef.Text = "";
                    txtUbigeo.Text = "";
                    lblMensaje.Text = "Código de instructor no existe";
                    btnConsultar.Enabled = false;
                }
                else  // si el instructor existe muestro datos...
                {
                    txtNombre.Text = objInstructorDC.Nombre + " " + objInstructorDC.ApePaterno + " " + objInstructorDC.ApeMaterno ;
                    txtCorreo.Text = objInstructorDC.Correo;
                    txtDNI.Text = objInstructorDC.Dni_inst;
                    txtDireccion.Text = objInstructorDC.Dir_inst;
                    txtTelef.Text = objInstructorDC.Tel_inst;
                    txtUbigeo.Text = objInstructorDC.Departamento + "_" + objInstructorDC.Provincia + "_" + objInstructorDC.Distrito;
                    lblMensaje.Text = "";
                    btnConsultar.Enabled = true;
                }
                txtCod.Focus();
                grvClasesProgramadas.DataSource = "";
                grvClasesProgramadas.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtFI.Text.Trim() == "")
                {
                    throw new Exception("Debe ingresar las fechas de inicio y de fin");
                }

                // Mostramos la consulta entre las fechas... 
                grvClasesProgramadas.DataSource = objServiceInstructorClases.ListarClasesProgramadasInstructor(txtCod.Text.Trim(), Convert.ToDateTime(txtFI.Text.Trim()));
                grvClasesProgramadas.DataBind();
                lblMensaje.Text = "El instructor tiene: " + grvClasesProgramadas.Rows.Count.ToString() + " clases programadas";
            }        

            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void grvClasesProgramadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}