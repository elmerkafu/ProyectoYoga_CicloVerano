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
    public partial class SalonMan03 : Form
    {
        ProxySalon.ServicioSalonClient objServiceSalon = new ProxySalon.ServicioSalonClient();
        ProxySalon.SalonDC objSalonDC = new ProxySalon.SalonDC();

        public SalonMan03()
        {
            InitializeComponent();
        }

        public Int16 strId
        {
            get; set;
        }
        private void SalonMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objSalonDC = objServiceSalon.ConsultarSalon(strId);

                lblCodigo.Text = objSalonDC.Id_Salon.ToString();
                txtNombre.Text = objSalonDC.Nombre;
                txtArea.Text = objSalonDC.Area;
                txtCapacidad.Text = objSalonDC.Capacidad.ToString();
                chkEstado.Checked = Convert.ToBoolean(objSalonDC.Estado);
                txtDescripcion.Text = objSalonDC.Descripcion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Agregar validaciones
                if (txtNombre.Text.Length == 0)
                {
                    throw new Exception("El campo Nombre no puede estar vacío.");
                }

                if (txtArea.Text.Length == 0)
                {
                    throw new Exception("El campo área no puede estar vacío.");
                }

                if (txtCapacidad.Text.Length == 0)
                {
                    throw new Exception("El campo capacidad no puede estar vacío.");
                }

                // Validaciones de negocio ???

                // si todo está validado 
                objSalonDC.Id_Salon = Convert.ToInt16(lblCodigo.Text);
                objSalonDC.Nombre = txtNombre.Text;
                objSalonDC.Area = txtArea.Text;
                objSalonDC.Capacidad = Convert.ToInt16(txtCapacidad.Text);
                objSalonDC.Estado = Convert.ToInt16(chkEstado.Checked);
                objSalonDC.Descripcion = txtDescripcion.Text;
                
                // Se invoca la operacion de actualizacion 
                if (objServiceSalon.ActualizarSalon(objSalonDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó el registro, contacte con TI");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
