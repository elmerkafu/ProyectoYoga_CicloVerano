using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Consulta Reniec
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.VisualBasic;

namespace TestWindows_WCF_Reserva
{
    public partial class InstructorMan02 : Form
    {

        ProxyInstructor.ServicioInstructorClient objServiceInstructor = new ProxyInstructor.ServicioInstructorClient();
        ProxyInstructor.InstructorDC objInstructorDC = new ProxyInstructor.InstructorDC();
        public InstructorMan02()
        {
            InitializeComponent();
        }

        //Guardar datos de la web - Inicio
        private string ExtraerContenidoEntreNombreString(string cadena, int posicion, string nombreInicio, string nombreFin, StringComparison reglaComparacion = StringComparison.OrdinalIgnoreCase)
        {
            string respuesta = "";
            int posicionInicio = cadena.IndexOf(nombreInicio, posicion, reglaComparacion);
            if (posicionInicio > -1)
            {
                posicionInicio += nombreInicio.Length;
                int posicionFin = cadena.IndexOf(nombreFin, posicionInicio, reglaComparacion);
                if (posicionFin > -1)
                    respuesta = cadena.Substring(posicionInicio, posicionFin - posicionInicio);
            }

            return respuesta;
        }
        private string[] ExtraerContenidoEntreNombre(string cadena, int posicion, string nombreInicio, string nombreFin, StringComparison reglaComparacion = StringComparison.OrdinalIgnoreCase)
        {
            string[] arrRespuesta = null;
            int posicionInicio = cadena.IndexOf(nombreInicio, posicion, reglaComparacion);
            if (posicionInicio > -1)
            {
                posicionInicio += nombreInicio.Length;
                int posicionFin = cadena.IndexOf(nombreFin, posicionInicio, reglaComparacion);
                if (posicionFin > -1)
                {
                    posicion = posicionFin + nombreFin.Length;
                    arrRespuesta = new string[2];
                    arrRespuesta[0] = posicion.ToString();
                    arrRespuesta[1] = cadena.Substring(posicionInicio, posicionFin - posicionInicio);
                }
            }

            return arrRespuesta;
        }

        private class DatoSolicitudDNI
        {
            public string _token { get; set; }
            public string dni { get; set; }
        }

        //Guardar datos de la web - Fin

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Length == 0)
                {
                    throw new Exception("El campo Nombres no puede estar vacio.");
                }

                if (txtApePaterno.Text.Length == 0)
                {
                    throw new Exception("El apellido Paterno no puede estar vacio.");
                }

                if (txtApeMaterno.Text.Length == 0)
                {
                    throw new Exception("El apellido Materno no puede estar vacio.");
                }

                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres.");

                }

                if (mskTelefono.MaskFull == false)
                {
                    throw new Exception("El Teléfono debe tener 9 caracteres.");

                }

                DateTime fechaNacimiento = dtpFecNac.Value.Date;
                DateTime fechaLimite = DateTime.Today.AddYears(-18);

                if (fechaNacimiento > fechaLimite)
                {
                    throw new Exception("La edad mínima para registrarse es 18 años");
                }

                objInstructorDC.Nombre = txtNombre.Text.Trim();
                objInstructorDC.ApePaterno = txtApePaterno.Text.Trim();
                objInstructorDC.ApeMaterno = txtApeMaterno.Text.Trim();
                objInstructorDC.Correo = txtCorreo.Text.Trim();
                objInstructorDC.Tel_inst = mskTelefono.Text;
                objInstructorDC.Dni_inst = mskDNI.Text;
                objInstructorDC.Dir_inst = txtDireccion.Text.Trim();
                objInstructorDC.Fec_nac = Convert.ToDateTime(dtpFecNac.Value.Date);
                objInstructorDC.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                    cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();

                objInstructorDC.Usu_reg = "Rivera";
                objInstructorDC.Est_ins = Convert.ToInt16(chkActivo.Checked);

                if (objServiceInstructor.InsertarInstructor(objInstructorDC) == true)
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

                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            ServicioUbigeoClient objServiceUbigeo = new ServicioUbigeoClient();

            cboDepartamento.DataSource = objServiceUbigeo.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objServiceUbigeo.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objServiceUbigeo.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }

        private void InstructorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private async void btnBuscarDatosReniec_Click(object sender, EventArgs e)
        {
            int tipoRespuesta = 2;
            string mensajeRespuesta = "";

            txtApePaterno.Text = "";
            txtApeMaterno.Text = "";
            txtNombre.Text = "";

            string numeroDNI = mskDNI.Text;
            if (string.IsNullOrWhiteSpace(numeroDNI))
                return;

            Stopwatch oCronometro = new Stopwatch();
            oCronometro.Start();

            btnBuscarDatosReniec.Enabled = false;

            CookieContainer cookies = new CookieContainer();
            HttpClientHandler controladorMensaje = new HttpClientHandler();
            controladorMensaje.CookieContainer = cookies;
            controladorMensaje.UseCookies = true;
            using (HttpClient cliente = new HttpClient(controladorMensaje))
            {
                cliente.DefaultRequestHeaders.Add("Host", "eldni.com");
                cliente.DefaultRequestHeaders.Add("sec-ch-ua", "\" Not A;Brand\";v=\"99\", \"Chromium\";v=\"90\", \"Google Chrome\";v=\"90\"");
                cliente.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "document");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "navigate");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Site", "none");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-User", "?1");
                cliente.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
                cliente.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.93 Safari/537.36");

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 |
                                                       SecurityProtocolType.Tls12;

                string url = "https://eldni.com/pe/buscar-por-dni";
                using (HttpResponseMessage resultadoConsultaToken = await cliente.GetAsync(new Uri(url)))
                {
                    if (resultadoConsultaToken.IsSuccessStatusCode)
                    {
                        mensajeRespuesta = await resultadoConsultaToken.Content.ReadAsStringAsync();

                        string token = ExtraerContenidoEntreNombreString(mensajeRespuesta, 0, "name=\"_token\" value=\"", "\">");

                        cliente.DefaultRequestHeaders.Remove("Sec-Fetch-Site");

                        cliente.DefaultRequestHeaders.Add("Origin", "https://eldni.com");
                        cliente.DefaultRequestHeaders.Add("Referer", "https://eldni.com/pe/buscar-por-dni");
                        cliente.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");

                        DatoSolicitudDNI oDatoSolicitudDNI = new DatoSolicitudDNI();
                        oDatoSolicitudDNI._token = token;
                        oDatoSolicitudDNI.dni = numeroDNI;
                        using (HttpResponseMessage resultadoConsultaDatos = await cliente.PostAsJsonAsync(url, oDatoSolicitudDNI))
                        {
                            if (resultadoConsultaDatos.IsSuccessStatusCode)
                            {
                                string contenidoHTML = await resultadoConsultaDatos.Content.ReadAsStringAsync();
                                string nombreInicio = "<table class=\"table table-striped table-scroll\">";
                                string nombreFin = "</table>";
                                string contenidoDNI = ExtraerContenidoEntreNombreString(contenidoHTML, 0, nombreInicio, nombreFin);
                                if (contenidoDNI == "")
                                {
                                    nombreInicio = "<h3 class=\"text-error\">";
                                    nombreFin = "</h3>";
                                    mensajeRespuesta = ExtraerContenidoEntreNombreString(contenidoHTML, 0, nombreInicio, nombreFin);
                                    mensajeRespuesta = mensajeRespuesta == ""
                                        ? string.Format(
                                            "No se pudo realizar la consulta del número de DNI {0}.", numeroDNI)
                                        : string.Format(
                                            "No se pudo realizar la consulta del número de DNI {0}.\r\nDetalle: {1}",
                                            numeroDNI,
                                            mensajeRespuesta);
                                }
                                else
                                {
                                    nombreInicio = "<td>";
                                    nombreFin = "</td>";
                                    string[] arrResultado = ExtraerContenidoEntreNombre(contenidoDNI, 0,
                                        nombreInicio,
                                        nombreFin);
                                    if (arrResultado != null)
                                    {
                                        // Nombres
                                        arrResultado = ExtraerContenidoEntreNombre(contenidoDNI,
                                            Convert.ToInt32(arrResultado[0]),
                                            nombreInicio, nombreFin);
                                        if (arrResultado != null)
                                        {
                                            txtNombre.Text = arrResultado[1];

                                            // Apellido Paterno
                                            arrResultado = ExtraerContenidoEntreNombre(contenidoDNI,
                                                Convert.ToInt32(arrResultado[0]),
                                                nombreInicio, nombreFin);

                                            if (arrResultado != null)
                                            {
                                                txtApePaterno.Text = arrResultado[1];

                                                // Apellido Materno
                                                arrResultado = ExtraerContenidoEntreNombre(contenidoDNI,
                                                    Convert.ToInt32(arrResultado[0]),
                                                    nombreInicio, nombreFin);

                                                if (arrResultado != null)
                                                {
                                                    txtApeMaterno.Text = arrResultado[1];
                                                    tipoRespuesta = 1;
                                                    mensajeRespuesta = string.Format("Se realizó exitosamente la consulta del número de DNI {0}",
                                                                numeroDNI);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                mensajeRespuesta = await resultadoConsultaDatos.Content.ReadAsStringAsync();
                                mensajeRespuesta =
                                    string.Format(
                                        "Ocurrió un inconveniente al consultar los datos del DNI {0}.\r\nDetalle:{1}",
                                        numeroDNI, mensajeRespuesta);
                            }
                        }
                    }
                    else
                    {
                        mensajeRespuesta = await resultadoConsultaToken.Content.ReadAsStringAsync();
                        mensajeRespuesta =
                            string.Format(
                                "Ocurrió un inconveniente al consultar el número de DNI {0}.\r\nDetalle:{1}",
                                numeroDNI, mensajeRespuesta);
                    }
                }
            }

            oCronometro.Stop();


            if (tipoRespuesta > 1)
                MessageBox.Show(mensajeRespuesta, "Consultar DNI"
                    , MessageBoxButtons.OK
                    , tipoRespuesta == 2 ? MessageBoxIcon.Warning : MessageBoxIcon.Error);

            //lblMensaje.Text = string.Format("Procesado en {0} seg.", oCronometro.Elapsed.TotalSeconds);

            btnBuscarDatosReniec.Enabled = true;
            mskDNI.Focus();
            mskDNI.SelectAll();
        }


        private void btnValidar_Click_1(object sender, EventArgs e)
        {
            EnviarEmail email = new EnviarEmail();
            string txtEmisor = "gestionyogacomunicados@gmail.com";
            string txtPass = "simxtipmaglmdeok";
            int numero = email.Enviar(txtCorreo.Text, txtEmisor, txtPass);
            int resultado = 0;

            DialogResult result = DialogResult.OK;

            if (numero != 0)
            {
                try
                {
                    resultado = Convert.ToInt32(Interaction.InputBox("Ingresa el codigo enviado al cliente", "Verificacion"));


                }
                catch (Exception)
                {
                    MessageBox.Show("Codigo ingresado no valido");

                }
                if (numero == resultado)
                {
                    MessageBox.Show("Correo validado");
                    btnGrabar.Enabled = true;
                }
            }
            else
            {
                result = MessageBox.Show("Reenviar correo", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
    }
}
