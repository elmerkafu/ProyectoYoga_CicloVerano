using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioSalon" en el código y en el archivo de configuración a la vez.
    public class ServicioSalon : IServicioSalon
    {
        public List<SalonDC> ListarSalon()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<SalonDC> objListaSalonDC = new List<SalonDC>();

                var query = (from miSalon in MisReservas.Tb_Salon
                             select miSalon).ToList();

                foreach(var objSalon in query)
                {
                    SalonDC objSalonDC = new SalonDC();

                    objSalonDC.Id_Salon = Convert.ToInt16(objSalon.Id_Salon);
                    objSalonDC.Nombre = objSalon.Nombre;

                    objListaSalonDC.Add(objSalonDC);
                }
                return objListaSalonDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }       
    }
}
