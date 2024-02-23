using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
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
        
        public List<SalonDC> ListarSalon_Grid()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<SalonDC> objListaSalonDC = new List<SalonDC>();

                var query = (from miSalon in MisReservas.Tb_Salon
                             where miSalon.Estado == 1
                             select miSalon).ToList();

                foreach(var objSalon in query)
                {
                    SalonDC objSalonDC = new SalonDC();

                    objSalonDC.Id_Salon = Convert.ToInt16(objSalon.Id_Salon);
                    objSalonDC.Nombre = objSalon.Nombre;
                    objSalonDC.Area = objSalon.Area;
                    objSalonDC.Capacidad = Convert.ToInt16(objSalon.Capacidad);
                    objSalonDC.Estado = Convert.ToInt16(objSalon.Estado);
                    objSalonDC.EstadoTexto = "Activo";
                    objSalonDC.Descripcion = objSalon.Descripcion;                   

                    objListaSalonDC.Add(objSalonDC);
                }
                return objListaSalonDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarSalon(SalonDC objSalonDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                MisReservas.usp_InsertarSalon(                    
                    objSalonDC.Nombre,
                    objSalonDC.Area,
                    Convert.ToInt16(objSalonDC.Capacidad),
                    Convert.ToInt16(objSalonDC.Estado),
                    objSalonDC.Descripcion                    
                    );

                MisReservas.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarSalon(SalonDC objSalonDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                MisReservas.usp_ActualizarSalon(
                    objSalonDC.Id_Salon,
                    objSalonDC.Nombre,
                    objSalonDC.Area,
                    Convert.ToInt16(objSalonDC.Capacidad),                    
                    Convert.ToInt16(objSalonDC.Estado),
                    objSalonDC.Descripcion);

                MisReservas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SalonDC ConsultarSalon(Int16 strId)
        {
            ReservaYogaEntities MisReservas = new ReservaYogaEntities();

            try
            {
                Tb_Salon objSalon = (from objSal in MisReservas.Tb_Salon
                                     where objSal.Id_Salon == strId
                                     select objSal).FirstOrDefault();              
                    
                SalonDC objSalonDC = new SalonDC();

                objSalonDC.Id_Salon = Convert.ToInt16(objSalon.Id_Salon);
                objSalonDC.Nombre = objSalon.Nombre;
                objSalonDC.Area = objSalon.Area;
                objSalonDC.Capacidad = Convert.ToInt16(objSalon.Capacidad);
                objSalonDC.Estado = Convert.ToInt16(objSalon.Estado);
                objSalonDC.Descripcion = objSalon.Descripcion;

                return objSalonDC;
            }            
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public Boolean UpdateSalonEstado(SalonDC objSalonDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                MisReservas.usp_ActualizarSalonEstado(
                    objSalonDC.Id_Salon,
                    objSalonDC.Comentario
                    );

                MisReservas.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

