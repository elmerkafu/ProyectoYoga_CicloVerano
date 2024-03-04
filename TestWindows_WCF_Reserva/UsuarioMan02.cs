using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TestWindows_WCF_Reserva
{
    public partial class UsuarioMan02 : Form
    {

        ProxyUsuarioRol.ServicioUsuarioRolClient objServiceUsuarioRol = new ProxyUsuarioRol.ServicioUsuarioRolClient();
        ProxyUsuarioRol.UsuarioRolDC objUsuarioRolDC = new ProxyUsuarioRol.UsuarioRolDC();
        public UsuarioMan02()
        {
            InitializeComponent();
            lblUsuario.Enabled = false;
        }

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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objUsuarioRolDC.Dni_Personal = mskDNI.Text;
                objUsuarioRolDC.Nombres = txtNombres.Text.Trim();
                objUsuarioRolDC.ApePaterno = txtApePaterno.Text.Trim();
                objUsuarioRolDC.ApeMaterno = txtApeMaterno.Text.Trim();
                objUsuarioRolDC.Fec_nac = Convert.ToDateTime(dtpFecNac.Value.Date);
                objUsuarioRolDC.Correo = txtCorreo.Text.Trim();
                objUsuarioRolDC.Telefono = mskTelefono.Text;
                objUsuarioRolDC.Direccion = txtDireccion.Text.Trim();
                objUsuarioRolDC.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                    cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();
                objUsuarioRolDC.Usu_Reg = "Leslye";
                objUsuarioRolDC.Pass_Usuario = txtPass.Text.Trim();
                objUsuarioRolDC.Id_Rol = Convert.ToInt16(cboRol.SelectedValue);

                if (objServiceUsuarioRol.InsertarUsuario(objUsuarioRolDC) == true)
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

        private void UsuarioMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");

                // Codificamos la carga del combo cboRoles...
                cboRol.DataSource = objServiceUsuarioRol.ListarRol();
                cboRol.DisplayMember = "Nombre";
                cboRol.ValueMember = "Id_Rol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnBuscarDatosReniec_Click(object sender, EventArgs e)
        {
            int tipoRespuesta = 2;
            string mensajeRespuesta = "";

            txtApePaterno.Text = "";
            txtApeMaterno.Text = "";
            txtNombres.Text = "";

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
                                            txtNombres.Text = arrResultado[1];

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

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnValidar_Click(object sender, EventArgs e)
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
                    txtCorreo.ReadOnly = true;
                    // Copiamos el campo txtCorreo en el campo lblUsuario.
                    lblUsuario.Text = txtCorreo.Text;
                }
            }
            else
            {
                result = MessageBox.Show("Reenviar correo", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private bool AlgoritmoContrasenaSegura(String password)
        {
            //bool mayuscula = false, minuscula = false, numero = false, carespecial = false;
            chkMayus.Checked = false; chkMinus.Checked = false; chkNum.Checked = false; chkEspecial.Checked = false; chkMinCaracter.Checked = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length >= 8)
                {
                    chkMinCaracter.Checked = true;
                }
                if (char.IsUpper(password, i))
                {
                    chkMayus.Checked = true;
                }
                else if (char.IsLower(password, i))
                {
                    chkMinus.Checked = true;
                }
                else if (char.IsDigit(password, i))
                {
                    chkNum.Checked = true;
                }
                else
                {
                    chkEspecial.Checked = true;
                }
            }
            if (chkMayus.Checked && chkMayus.Checked && chkNum.Checked && chkEspecial.Checked && password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (AlgoritmoContrasenaSegura(txtPass.Text))
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }
    }
}
