using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioReserva" en el código y en el archivo de configuración a la vez.
    public class ServicioReserva : IServicioReserva
    {
        public Int16 ContarReservasTotales()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                Int16 cantReservas = Convert.ToInt16
                    (
                        (from objResv in MisReservas.Tb_Reserva
                         select objResv).Count()
                    );
                return cantReservas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Int16 ContarReservasCliente(Int16 strCodigo)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                Int16 cantReservas = Convert.ToInt16
                    (
                        (from objResv in MisReservas.Tb_Reserva
                         where objResv.Id_Cliente == strCodigo
                         select objResv).Count()
                    );
                return cantReservas;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DateTime? ObtenerFechaReservaPorCodigo(string codigoReserva)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                int numeroReserva = int.Parse(codigoReserva.Substring(2));

                var reserva = MisReservas.Tb_Reserva.FirstOrDefault(r => r.Cod_resv == codigoReserva);

                if (reserva != null && reserva.Fec_resv.HasValue)
                {
                    return reserva.Fec_resv.Value;
                }
                else
                {
                    throw new Exception("No se encontró ninguna reserva con el código proporcionado o la fecha de reserva es nula.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ReservaDC> ListarReservaClienteFechas(Int16 strCodigo, DateTime fecIni, DateTime fecFin)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<ReservaDC> objReservasCliente = new List<ReservaDC>();

                var query = (from miConsulta in MisReservas.Tb_Reserva
                             join miDetalle in MisReservas.Tb_Cliente
                             on miConsulta.Id_Cliente equals miDetalle.Id_Cliente
                             where miDetalle.Id_Cliente == strCodigo && miConsulta.Fec_resv >= fecIni && miConsulta.Fec_resv <= fecFin
                             select miConsulta).ToList();
                foreach (var objConsulta in query)
                {
                    ReservaDC objConsultaDC = new ReservaDC();
                    objConsultaDC.Cod_resv = objConsulta.Cod_resv;
                    objConsultaDC.Id_Cliente = Convert.ToInt16(objConsulta.Id_Cliente);
                    objConsultaDC.Fec_resv = Convert.ToDateTime(objConsulta.Fec_resv);
                    objConsultaDC.Nombre = objConsulta.Tb_Cliente.Nombres;
                    objConsultaDC.Est_resv = Convert.ToInt16(objConsulta.Est_resv);
                    if (objConsultaDC.Est_resv == 0)
                    {

                        objConsultaDC.EstRev = "Inactivo";

                    }
                    else if (objConsultaDC.Est_resv == 1)
                    {

                        objConsultaDC.EstRev = "Activo";

                    }
                    else
                    {
                        objConsultaDC.EstRev = "Anulada";

                    }
                    objConsultaDC.Observacion = objConsulta.Observacion;


                    objReservasCliente.Add(objConsultaDC);
                }

                //MisReservas.SaveChanges();                
                return objReservasCliente;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarReserva(ReservaDC objReservaDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                MisReservas.usp_RegistrarReserva_TEST(
                    objReservaDC.Id_Cliente,
                    objReservaDC.Usu_reg,
                    objReservaDC.Id_Clase_Prog
                    );

                MisReservas.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ReservaDC> ListarReservasCliente(Int16 intCod)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<ReservaDC> objListarReservasDC = new List<ReservaDC>();

                var query = (from miReserva in MisReservas.Tb_Reserva
                             join miClase in MisReservas.Tb_Clase_Programada on miReserva.Id_Clase_Prog equals miClase.Id_Clase_Prog
                             //oin miSalon in MisReservas.Tb_Salon on miReserva.Id_Clase_Prog 
                             where miReserva.Id_Cliente == intCod
                             select miReserva).ToList();
                             
                foreach (var objReserva in query)
                {
                    ReservaDC objReservaDC = new ReservaDC();
                    objReservaDC.Cod_resv = objReserva.Cod_resv;
                    objReservaDC.Fec_Clase = objReserva.Tb_Clase_Programada1.Fec_Clase;
                    objReservaDC.Hora_Emp = Convert.ToDateTime(objReserva.Tb_Clase_Programada1.Hora_Emp);
                    objReservaDC.Hora_Term = Convert.ToDateTime(objReserva.Tb_Clase_Programada1.Hora_Term);
                    objReservaDC.NombreInstructor = objReserva.Tb_Clase_Programada1.Tb_Instructor_Disciplina.Tb_Instructor.Nombre + ' ' + objReserva.Tb_Clase_Programada1.Tb_Instructor_Disciplina.Tb_Instructor.ApePaterno + ' ' + objReserva.Tb_Clase_Programada1.Tb_Instructor_Disciplina.Tb_Instructor.ApeMaterno;
                    objReservaDC.Disciplina = objReserva.Tb_Clase_Programada1.Tb_Instructor_Disciplina.Tb_Disciplina.Nombre;
                    objReservaDC.Duracion = objReserva.Tb_Clase_Programada1.Tb_Instructor_Disciplina.Tb_Disciplina.Duracion;
                    objReservaDC.Intensidad = objReserva.Tb_Clase_Programada1.Tb_Instructor_Disciplina.Tb_Disciplina.Intensidad;
                    objReservaDC.Salon = objReserva.Tb_Clase_Programada1.Tb_Salon.Nombre;


                    objListarReservasDC.Add(objReservaDC);
                }
                return objListarReservasDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }

    }
}
