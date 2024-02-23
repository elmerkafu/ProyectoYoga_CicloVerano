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
    public partial class Comentario03 : Form
    {
        ProxySalon.ServicioSalonClient objServiceSalon = new ProxySalon.ServicioSalonClient();
        ProxySalon.SalonDC objSalonDC = new ProxySalon.SalonDC();
        public Comentario03()
        {
            InitializeComponent();
        }
        public Int16 Codigo
        {
            get; set;
        }

        private void Comentario03_Load(object sender, EventArgs e)
        {
            try
            {
                objSalonDC = objServiceSalon.ConsultarSalon(Codigo);
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

                objSalonDC.Comentario = txtComentario.Text;

                if (objServiceSalon.UpdateSalonEstado(objSalonDC) == true)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
