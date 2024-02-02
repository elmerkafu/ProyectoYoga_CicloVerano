using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_ConsultaInstructor.ProxyCliente;
using WEB_ConsultaInstructor.ProxyReserva;


namespace WEB_ConsultaInstructor.Consultas
{
    public partial class ConsultarReservas : System.Web.UI.Page
    {
        ServicioClienteClient objServiceCliente = new ServicioClienteClient();
        ServicioReservaClient objServiceReserva = new ServicioReservaClient();

        ClienteDC objClienteDC = new ClienteDC();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                objClienteDC = objServiceCliente.ConsultarCliente(Convert.ToInt16(txtCod.Text.Trim()));

                if (objClienteDC.Id_Cliente == 0)
                {
                    // Si el cliente ingresado no existe, limpiamos las cajas...
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDNI.Text = "";
                    txtDireccion.Text = "";
                    txtUbigeo.Text = "";
                    lblMensaje.Text = "Codigo de cliente no existe";
                    btnConsultar.Enabled = false;
                }
                else // Si el cliente existe muestro sus datos....
                {
                    txtNombre.Text = objClienteDC.Nombres;
                    txtApellido.Text = objClienteDC.ApePaterno + " " + objClienteDC.ApeMaterno;
                    txtDNI.Text = objClienteDC.Dni_cli;
                    txtCorreo.Text = objClienteDC.Correo;
                    txtDireccion.Text = objClienteDC.Dir_cli;
                    txtTelef.Text = objClienteDC.Tel_cli;
                    txtUbigeo.Text = objClienteDC.Departamento + "_" + objClienteDC.Provincia + "_" + objClienteDC.Distrito;
                    lblMensaje.Text = "";
                    btnConsultar.Enabled = true;


                }
                txtCod.Focus();
                grvReservas.DataSource = "";
                grvReservas.DataBind();
            }
            catch (Exception ex)
            {

                lblMensaje.Text = "Error: " + ex.Message ;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFI.Text.Trim() == "" | txtFF.Text.Trim() == "")
                {
                    throw new Exception("Debe ingresar las fechas de inicio y de fin");

                }

                // Mostramos facturacion entre las fechas...
                grvReservas.DataSource = objServiceReserva.ListarReservaClienteFechas(Convert.ToInt16(txtCod.Text.Trim()),
                                                                          Convert.ToDateTime(txtFI.Text.Trim()), Convert.ToDateTime(txtFF.Text.Trim()));
                grvReservas.DataBind();
                lblMensaje.Text = "El cliente tiene : " + grvReservas.Rows.Count.ToString() + " reservas en el periodo seleccionado";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;

            }


        }

        protected void grvReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}