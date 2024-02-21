﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioClaseProgramada" en el código y en el archivo de configuración a la vez.
    public class ServicioClaseProgramada : IServicioClaseProgramada
    {
        public List<ClaseProgramadaDC> ListarClaseProgramada()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<ClaseProgramadaDC> objListaClaseProgramadaDC = new List<ClaseProgramadaDC>();

                var query = (from miClaseProgramada in MisReservas.Tb_Clase_Programada
                             join objSalon in MisReservas.Tb_Salon on miClaseProgramada.Id_Salon equals objSalon.Id_Salon
                             join objInsDisciplina in MisReservas.Tb_Instructor_Disciplina on miClaseProgramada.Id_Inst_Disp equals objInsDisciplina.Id_Inst_Disp
                             //join objInstructor in MisReservas.Tb_Instructor on miClaseProgramada.Tb_Instructor_Disciplina.Id_Instructor equals objInstructor.Id_Instructor
                             //join objDisciplina in MisReservas.Tb_Disciplina on miClaseProgramada.Tb_Instructor_Disciplina.Cod_disp equals objDisciplina.Cod_disp
                             select miClaseProgramada).ToList();

                foreach (var objClaseProgramada in query)
                {
                    ClaseProgramadaDC objClaseProgramadaDC = new ClaseProgramadaDC();

                    objClaseProgramadaDC.Id_Clase_Prog = Convert.ToInt16(objClaseProgramada.Id_Clase_Prog);
                    objClaseProgramadaDC.Id_Salon = Convert.ToInt16(objClaseProgramada.Id_Salon);
                    objClaseProgramadaDC.NombreSalon = objClaseProgramada.Tb_Salon.Nombre;
                    objClaseProgramadaDC.Capacidad = Convert.ToInt16(objClaseProgramada.Tb_Salon.Capacidad);
                    objClaseProgramadaDC.NombreInstructor = objClaseProgramada.Tb_Instructor_Disciplina.Tb_Instructor.Nombre + ' ' + objClaseProgramada.Tb_Instructor_Disciplina.Tb_Instructor.ApePaterno + ' ' + objClaseProgramada.Tb_Instructor_Disciplina.Tb_Instructor.ApeMaterno;
                    objClaseProgramadaDC.Id_Inst_Disp = objClaseProgramada.Id_Inst_Disp;
                    objClaseProgramadaDC.Fec_Clase = objClaseProgramada.Fec_Clase;
                    objClaseProgramadaDC.Hora_Emp = Convert.ToDateTime(objClaseProgramada.Hora_Emp);
                    objClaseProgramadaDC.Hora_Term = Convert.ToDateTime(objClaseProgramada.Hora_Term);
                    objClaseProgramadaDC.Est_clase = Convert.ToInt16(objClaseProgramada.Est_clase);
                    objClaseProgramadaDC.NombreDisciplina = objClaseProgramada.Tb_Instructor_Disciplina.Tb_Disciplina.Nombre;
                    objClaseProgramadaDC.Duracion = objClaseProgramada.Tb_Instructor_Disciplina.Tb_Disciplina.Duracion;
                    objClaseProgramadaDC.Intensidad = objClaseProgramada.Tb_Instructor_Disciplina.Tb_Disciplina.Intensidad;
                    objClaseProgramadaDC.Fec_reg = Convert.ToDateTime(objClaseProgramada.Fec_reg);
                    objClaseProgramadaDC.Usu_reg = objClaseProgramada.Usu_reg;
                    objClaseProgramadaDC.Usu_Ult_Mod = objClaseProgramada.Usu_Ult_Mod;
                    objClaseProgramadaDC.Fec_Ult_Mod = Convert.ToDateTime(objClaseProgramada.Fec_Ult_Mod);

                    if (objClaseProgramadaDC.Est_clase == 1)
                    {
                        objClaseProgramadaDC.Estado = "Activo";
                    }
                    else if (objClaseProgramadaDC.Est_clase == 0)
                    {
                        objClaseProgramadaDC.Estado = "Inactivo";
                    }

                    objListaClaseProgramadaDC.Add(objClaseProgramadaDC);
                }
                return objListaClaseProgramadaDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClaseProgramadaDC ConsultarClaseProgramada(Int16 strId)
        {
            ReservaYogaEntities MisReservas = new ReservaYogaEntities();
            try
            {
                Tb_Clase_Programada objClaseProgramada = (from objClase in MisReservas.Tb_Clase_Programada
                                                          join objInstDsp in MisReservas.Tb_Instructor_Disciplina on objClase.Id_Inst_Disp equals objInstDsp.Id_Inst_Disp
                                                          join objSalon in MisReservas.Tb_Salon on objClase.Id_Salon equals objSalon.Id_Salon
                                                          where objClase.Id_Clase_Prog == strId
                                                          select objClase).FirstOrDefault();

                ClaseProgramadaDC objClaseProgramadaDC = new ClaseProgramadaDC();

                objClaseProgramadaDC.Id_Clase_Prog = Convert.ToInt16(objClaseProgramada.Id_Clase_Prog);
                objClaseProgramadaDC.Id_Salon = Convert.ToInt16(objClaseProgramada.Id_Salon);
                objClaseProgramadaDC.Nombre = objClaseProgramada.Tb_Salon.Nombre;
                objClaseProgramadaDC.Id_Inst_Disp = objClaseProgramada.Id_Inst_Disp;
                objClaseProgramadaDC.Nombre = objClaseProgramada.Tb_Instructor_Disciplina.Tb_Instructor.Nombre;
                objClaseProgramadaDC.ApellidoPInstructor = objClaseProgramada.Tb_Instructor_Disciplina.Tb_Instructor.ApePaterno;
                objClaseProgramadaDC.ApellidoMInstructor = objClaseProgramada.Tb_Instructor_Disciplina.Tb_Instructor.ApeMaterno;
                objClaseProgramadaDC.Fec_Clase = Convert.ToDateTime(objClaseProgramada.Fec_Clase);
                objClaseProgramadaDC.Hora_Emp = Convert.ToDateTime(objClaseProgramada.Hora_Emp);
                objClaseProgramadaDC.Hora_Term = Convert.ToDateTime(objClaseProgramada.Hora_Term);
                objClaseProgramadaDC.Est_clase = Convert.ToInt16(objClaseProgramada.Est_clase);
                objClaseProgramadaDC.Fec_reg = Convert.ToDateTime(objClaseProgramada.Fec_reg);
                objClaseProgramadaDC.Usu_reg = objClaseProgramada.Usu_reg;
                objClaseProgramadaDC.Usu_Ult_Mod = objClaseProgramada.Usu_Ult_Mod;
                objClaseProgramadaDC.Fec_Ult_Mod = Convert.ToDateTime(objClaseProgramada.Fec_Ult_Mod);

                return objClaseProgramadaDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarClaseProgramada(ClaseProgramadaDC objClaseProgramadaDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                MisReservas.usp_InsertarClaseProgramada(
                    Convert.ToInt16(objClaseProgramadaDC.Id_Salon),
                    objClaseProgramadaDC.Id_Inst_Disp,
                    Convert.ToDateTime(objClaseProgramadaDC.Fec_Clase),
                    Convert.ToDateTime(objClaseProgramadaDC.Hora_Emp),
                    Convert.ToDateTime(objClaseProgramadaDC.Hora_Term),
                    Convert.ToInt16(objClaseProgramadaDC.Est_clase),
                    objClaseProgramadaDC.Usu_reg
                    );

                //FALTA TODAS LAS VALIDACIONES 

                MisReservas.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarClaseProgramada(ClaseProgramadaDC objClaseProgramadaDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                MisReservas.usp_ActualizarClaseProgramada_TEST(
                    objClaseProgramadaDC.Id_Clase_Prog,
                    objClaseProgramadaDC.Id_Salon,
                    objClaseProgramadaDC.Id_Inst_Disp,
                    Convert.ToDateTime(objClaseProgramadaDC.Fec_Clase),
                    Convert.ToDateTime(objClaseProgramadaDC.Hora_Emp),
                    Convert.ToDateTime(objClaseProgramadaDC.Hora_Term),
                    Convert.ToInt16(objClaseProgramadaDC.Est_clase),
                    objClaseProgramadaDC.Usu_Ult_Mod
                    );

                MisReservas.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClaseProgramadaDC> ListarNombreInstructor()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<ClaseProgramadaDC> objListaNombreInstructor = new List<ClaseProgramadaDC>();

                var query = (from miClaseProgramada in MisReservas.Tb_Clase_Programada
                             join objInstructorDisciplina in MisReservas.Tb_Instructor_Disciplina on miClaseProgramada.Id_Inst_Disp equals objInstructorDisciplina.Id_Inst_Disp
                             join objInstructor in MisReservas.Tb_Instructor on miClaseProgramada.Tb_Instructor_Disciplina.Tb_Instructor.Id_Instructor equals objInstructor.Id_Instructor
                             select miClaseProgramada).ToList();

                foreach (var objInstructor in query)
                {
                    ClaseProgramadaDC objClaseProgramadaDC = new ClaseProgramadaDC();
                    objClaseProgramadaDC.Id_Instructor = objInstructor.Tb_Instructor_Disciplina.Tb_Instructor.Id_Instructor;
                    objClaseProgramadaDC.NombreInstructor = objInstructor.Tb_Instructor_Disciplina.Tb_Instructor.Nombre + ' ' + objInstructor.Tb_Instructor_Disciplina.Tb_Instructor.ApePaterno + ' ' + objInstructor.Tb_Instructor_Disciplina.Tb_Instructor.ApeMaterno;

                    objListaNombreInstructor.Add(objClaseProgramadaDC);
                }
                return objListaNombreInstructor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClaseProgramadaDC ConsultarClase_PorFecha(DateTime strId)
        {
            ReservaYogaEntities MisReservas = new ReservaYogaEntities();
            try
            {
                Tb_Clase_Programada objClaseProgramada = (from objClase in MisReservas.Tb_Clase_Programada
                                                          join objInstDsp in MisReservas.Tb_Instructor_Disciplina on objClase.Id_Inst_Disp equals objInstDsp.Id_Inst_Disp
                                                          join objSalon in MisReservas.Tb_Salon on objClase.Id_Salon equals objSalon.Id_Salon
                                                          where objClase.Fec_Clase == strId
                                                          select objClase).FirstOrDefault();

                ClaseProgramadaDC objClaseProgramadaDC = new ClaseProgramadaDC();

                objClaseProgramadaDC.Id_Clase_Prog = Convert.ToInt16(objClaseProgramada.Id_Clase_Prog);
                objClaseProgramadaDC.Id_Salon = Convert.ToInt16(objClaseProgramada.Id_Salon);
                objClaseProgramadaDC.Nombre = objClaseProgramada.Tb_Salon.Nombre;
                objClaseProgramadaDC.NombreInstructor = objClaseProgramada.Tb_Instructor_Disciplina.Tb_Instructor.Nombre + ' ' + objClaseProgramada.Tb_Instructor_Disciplina.Tb_Instructor.ApePaterno + ' ' + objClaseProgramada.Tb_Instructor_Disciplina.Tb_Instructor.ApeMaterno;
                objClaseProgramadaDC.Fec_Clase = Convert.ToDateTime(objClaseProgramada.Fec_Clase);
                objClaseProgramadaDC.Hora_Emp = Convert.ToDateTime(objClaseProgramada.Hora_Emp);
                objClaseProgramadaDC.Hora_Term = Convert.ToDateTime(objClaseProgramada.Hora_Term);
                objClaseProgramadaDC.Est_clase = Convert.ToInt16(objClaseProgramada.Est_clase);
                objClaseProgramadaDC.Fec_reg = Convert.ToDateTime(objClaseProgramada.Fec_reg);
                objClaseProgramadaDC.Usu_reg = objClaseProgramada.Usu_reg;
                objClaseProgramadaDC.Usu_Ult_Mod = objClaseProgramada.Usu_Ult_Mod;
                objClaseProgramadaDC.Fec_Ult_Mod = Convert.ToDateTime(objClaseProgramada.Fec_Ult_Mod);

                return objClaseProgramadaDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClaseProgramadaDC> ListarClasesPorFecha(DateTime strId)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<ClaseProgramadaDC> objListarClasesProgramadasDC = new List<ClaseProgramadaDC>();

                var query = (from miClase in MisReservas.Tb_Clase_Programada

                             join miDetalle in MisReservas.Tb_Instructor_Disciplina on miClase.Id_Inst_Disp equals miDetalle.Id_Inst_Disp
                             join miSalon in MisReservas.Tb_Salon on miClase.Id_Salon equals miSalon.Id_Salon
                             where miClase.Fec_Clase == strId
                             select miClase).ToList();

                foreach (var objClase in query)
                {
                    ClaseProgramadaDC objClaseDC = new ClaseProgramadaDC();
                    objClaseDC.Id_Clase_Prog = Convert.ToInt16(objClase.Id_Clase_Prog);
                    objClaseDC.Nombre = objClase.Tb_Salon.Nombre;
                    objClaseDC.NombreInstructor = objClase.Tb_Instructor_Disciplina.Tb_Instructor.Nombre + ' ' + objClase.Tb_Instructor_Disciplina.Tb_Instructor.ApePaterno + ' ' + objClase.Tb_Instructor_Disciplina.Tb_Instructor.ApeMaterno;
                    objClaseDC.Fec_Clase = Convert.ToDateTime(objClase.Fec_Clase);
                    objClaseDC.Hora_Emp = Convert.ToDateTime(objClase.Hora_Emp);
                    objClaseDC.Hora_Term = Convert.ToDateTime(objClase.Hora_Term);
                    objClaseDC.Est_clase = Convert.ToInt16(objClase.Est_clase);
                    objClaseDC.Capacidad = Convert.ToInt16(objClase.Tb_Salon.Capacidad);

                    objListarClasesProgramadasDC.Add(objClaseDC);
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
