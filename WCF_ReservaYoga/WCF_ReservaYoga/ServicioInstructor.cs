using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioInstructor" en el código y en el archivo de configuración a la vez.
    public class ServicioInstructor : IServicioInstructor
    {
        public Boolean InsertarInstructor(InstructorDC objInstructorDC)
        {

            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                MisReservas.usp_InsertarInstructor(

                    objInstructorDC.Nombre,
                    objInstructorDC.ApePaterno,
                    objInstructorDC.ApeMaterno,
                    objInstructorDC.Correo,
                    objInstructorDC.Tel_inst,
                    objInstructorDC.Dni_inst,
                    objInstructorDC.Dir_inst,
                    Convert.ToDateTime(objInstructorDC.Fec_nac),
                    objInstructorDC.Id_Ubigeo,
                    Convert.ToInt16(objInstructorDC.Est_ins),
                    objInstructorDC.Usu_reg
                    );

                MisReservas.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarInstructor(InstructorDC objInstructorDC)
        {
            try
            {

                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                MisReservas.usp_ActualizarInstructor(
                    objInstructorDC.Id_Instructor,
                    objInstructorDC.Nombre,
                    objInstructorDC.ApePaterno,
                    objInstructorDC.ApeMaterno,
                    objInstructorDC.Correo,
                    objInstructorDC.Tel_inst,
                    objInstructorDC.Dni_inst,
                    objInstructorDC.Dir_inst,
                    Convert.ToDateTime(objInstructorDC.Fec_nac),
                    objInstructorDC.Id_Ubigeo,
                    objInstructorDC.Usu_Ult_Mod,
                    Convert.ToInt16(objInstructorDC.Est_ins)

                    );

                MisReservas.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public Boolean EliminarInstructor(String strCodigo)
        {
            try
            {

                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                MisReservas.usp_EliminarInstructor(strCodigo);

                MisReservas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public InstructorDC ConsultarInstructor(String strCodigo)

        {
            ReservaYogaEntities MisReservas = new ReservaYogaEntities();
            try
            {


                Tb_Instructor objInstructor = (from objInst in MisReservas.Tb_Instructor
                                               join objUbi in MisReservas.Tb_Ubigeo on objInst.Id_Ubigeo equals objUbi.Id_Ubigeo
                                               where objInst.Id_Instructor == strCodigo
                                               select objInst).FirstOrDefault();

                InstructorDC objInstructorDC = new InstructorDC();
                objInstructorDC.Id_Instructor = objInstructor.Id_Instructor;
                objInstructorDC.Nombre = objInstructor.Nombre;
                objInstructorDC.ApePaterno = objInstructor.ApePaterno;
                objInstructorDC.ApeMaterno = objInstructor.ApeMaterno;
                objInstructorDC.Correo = objInstructor.Correo;
                objInstructorDC.Tel_inst = objInstructor.Tel_inst;
                objInstructorDC.Dni_inst = objInstructor.Dni_inst;
                objInstructorDC.Dir_inst = objInstructor.Dir_inst;
                objInstructorDC.Fec_nac = Convert.ToDateTime(objInstructor.Fec_nac);
                objInstructorDC.Id_Ubigeo = objInstructor.Id_Ubigeo;
                objInstructorDC.Departamento = objInstructor.Tb_Ubigeo.Departamento;
                objInstructorDC.Provincia = objInstructor.Tb_Ubigeo.Provincia;
                objInstructorDC.Distrito = objInstructor.Tb_Ubigeo.Distrito;
                objInstructorDC.Est_ins = Convert.ToInt16(objInstructor.Est_ins);
                objInstructorDC.Fec_reg = Convert.ToDateTime(objInstructor.Fec_reg);
                objInstructorDC.Usu_reg = objInstructorDC.Usu_reg;
                objInstructorDC.Usu_Ult_Mod = objInstructorDC.Usu_Ult_Mod;
                objInstructorDC.Fec_Ult_Mod = Convert.ToDateTime(objInstructor.Fec_Ult_Mod);



                return objInstructorDC;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public List<InstructorDC> ListarInstructor()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<InstructorDC> objListaInstructorDC = new List<InstructorDC>();

                var query = (from miInstructor in MisReservas.Tb_Instructor
                             join objUbi in MisReservas.Tb_Ubigeo on miInstructor.Id_Ubigeo equals objUbi.Id_Ubigeo
                             orderby miInstructor.ApePaterno
                             select miInstructor).ToList();
                foreach (var objInstructor in query)
                {
                    InstructorDC objInstructorDC = new InstructorDC();
                    objInstructorDC.Id_Instructor = objInstructor.Id_Instructor;
                    objInstructorDC.Nombre = objInstructor.Nombre;
                    objInstructorDC.ApePaterno = objInstructor.ApePaterno;
                    objInstructorDC.ApeMaterno = objInstructor.ApeMaterno;
                    objInstructorDC.Correo = objInstructor.Correo;
                    objInstructorDC.Tel_inst = objInstructor.Tel_inst;
                    objInstructorDC.Dni_inst = objInstructor.Dni_inst;
                    objInstructorDC.Dir_inst = objInstructor.Dir_inst;
                    objInstructorDC.Fec_nac = Convert.ToDateTime(objInstructor.Fec_nac);
                    objInstructorDC.Id_Ubigeo = objInstructor.Id_Ubigeo;

                    objInstructorDC.Departamento = objInstructor.Tb_Ubigeo.Departamento;
                    objInstructorDC.Provincia = objInstructor.Tb_Ubigeo.Provincia;
                    objInstructorDC.Distrito = objInstructor.Tb_Ubigeo.Distrito;
                    
                    objInstructorDC.Est_ins = Convert.ToInt16(objInstructor.Est_ins);
                    if (objInstructorDC.Est_ins == 0)
                    {
                        objInstructorDC.EstadoInst = "Inactivo";
                    }
                    else if (objInstructorDC.Est_ins == 1)
                    {
                        objInstructorDC.EstadoInst = "Activo";
                    }
                    else
                    {
                        objInstructorDC.EstadoInst = "No asignado";
                    }
                    objInstructorDC.Fec_reg = Convert.ToDateTime(objInstructor.Fec_reg);
                    objInstructorDC.Usu_reg = objInstructorDC.Usu_reg;
                    objInstructorDC.Usu_Ult_Mod = objInstructorDC.Usu_Ult_Mod;
                    objInstructorDC.Fec_Ult_Mod = Convert.ToDateTime(objInstructor.Fec_Ult_Mod);

                    objListaInstructorDC.Add(objInstructorDC);
                }

                return objListaInstructorDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<InstructorDC> ListarNombreInstructor()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<InstructorDC> objListaNombreInstructor = new List<InstructorDC>();

                var query = (from miInstructor in MisReservas.Tb_Instructor                             
                             select miInstructor).ToList();

                foreach (var objInstructor in query)
                {
                    InstructorDC objInstructorDC = new InstructorDC();
                    objInstructorDC.Id_Instructor = objInstructor.Id_Instructor;
                    objInstructorDC.NombreInstructor = objInstructor.Nombre + ' ' + objInstructor.ApePaterno + ' ' + objInstructor.ApeMaterno;

                    objListaNombreInstructor.Add(objInstructorDC);
                }
                return objListaNombreInstructor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
