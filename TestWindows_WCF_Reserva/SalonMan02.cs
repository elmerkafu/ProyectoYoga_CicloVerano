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
    public partial class SalonMan02 : Form
    {
        ProxySalon.ServicioSalonClient objServiceSalon = new ProxySalon.ServicioSalonClient();
        ProxySalon.SalonDC objSalonDC = new ProxySalon.SalonDC();

        public SalonMan02()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objSalonDC.Nombre = txtNombre.Text.Trim();
                objSalonDC.Area = txtArea.Text.Trim();
                objSalonDC.Capacidad = Convert.ToInt16(txtCapacidad.Text.Trim());
                objSalonDC.Estado = Convert.ToInt16(chkEstado.Checked);
                objSalonDC.Descripcion = txtDescripcion.Text.Trim();
                
                if (objServiceSalon.InsertarSalon(objSalonDC) == true)
                    
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
    }
}
