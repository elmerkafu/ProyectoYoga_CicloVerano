using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ConsultaInstructorClases" en el código y en el archivo de configuración a la vez.
    public class ConsultaInstructorClases : IConsultaInstructorClases
    {
        public List<ConsultaDC> ListarClasesProgramadasInstructor(String strCodigo, DateTime fecIni)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<ConsultaDC> objListarClasesProgramadasDC = new List<ConsultaDC>();

                var query = (from miConsulta in MisReservas.Tb_Clase_Programada
                             join miDetalle in MisReservas.Tb_Instructor_Disciplina
                             on miConsulta.Id_Inst_Disp equals miDetalle.Id_Inst_Disp
                             join miClase in MisReservas.Tb_Salon
                             on miConsulta.Id_Salon equals miClase.Id_Salon
                             where miDetalle.Id_Instructor == strCodigo && miConsulta.Fec_Clase == fecIni
                             select miConsulta).ToList();
                foreach (var objConsulta in query)
                {
                    ConsultaDC objConsultaDC = new ConsultaDC();
                    objConsultaDC.Id_Salon = Convert.ToInt16(objConsulta.Id_Salon);
                    objConsultaDC.NombreSalon = objConsulta.Tb_Salon.Nombre;
                    objConsultaDC.Fec_Clase = Convert.ToDateTime(objConsulta.Fec_Clase);
                    objConsultaDC.Hora_Emp = Convert.ToDateTime(objConsulta.Hora_Emp);
                    objConsultaDC.Hora_Term = Convert.ToDateTime(objConsulta.Hora_Term);
                    objConsultaDC.Est_clase = Convert.ToInt16(objConsulta.Est_clase);
                    if (objConsultaDC.Est_clase == 0)
                    {
                        objConsultaDC.EstadoClase = "Inactivo";
                    }else if (objConsultaDC.Est_clase == 1)
                    {
                        objConsultaDC.EstadoClase = "Activo";
                    }
                    else
                    {
                        objConsultaDC.EstadoClase = "Anulado";
                    }

                    objListarClasesProgramadasDC.Add(objConsultaDC);
                }

                //MisReservas.SaveChanges();                
                return objListarClasesProgramadasDC;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
