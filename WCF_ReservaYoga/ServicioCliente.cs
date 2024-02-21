using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        public ClienteDC ConsultarCliente(Int16 strId)
        {
            ReservaYogaEntities MisReservas = new ReservaYogaEntities();
            try
            {
                Tb_Cliente objCliente = (from objCli in MisReservas.Tb_Cliente
                                         join objUbi in MisReservas.Tb_Ubigeo on objCli.Id_Ubigeo equals objUbi.Id_Ubigeo
                                          where objCli.Id_Cliente == strId
                                          select objCli).FirstOrDefault();

                ClienteDC objClienteDC = new ClienteDC();
                objClienteDC.Id_Cliente = Convert.ToInt16(objCliente.Id_Cliente);
                objClienteDC.Nombres = objCliente.Nombres;
                objClienteDC.ApePaterno = objCliente.ApePaterno;
                objClienteDC.ApeMaterno = objCliente.ApeMaterno;
                objClienteDC.Correo = objCliente.Correo;
                objClienteDC.Tel_cli = objCliente.Tel_cli;
                objClienteDC.Dir_cli = objCliente.Dir_cli;
                objClienteDC.Dni_cli = objCliente.Dni_cli;
                objClienteDC.Sexo = objCliente.Sexo;
                objClienteDC.Fec_nac = Convert.ToDateTime(objCliente.Fec_nac);
                objClienteDC.Est_cli = Convert.ToInt16(objCliente.Est_cli);
                objClienteDC.Id_Ubigeo = objCliente.Id_Ubigeo;
                objClienteDC.Departamento = objCliente.Tb_Ubigeo.Departamento;
                objClienteDC.Provincia = objCliente.Tb_Ubigeo.Provincia;
                objClienteDC.Distrito = objCliente.Tb_Ubigeo.Distrito;
                objClienteDC.Fec_reg = Convert.ToDateTime(objCliente.Fec_reg);
                objClienteDC.Usu_reg = objCliente.Usu_reg;
                objClienteDC.Usu_Ult_Mod = objCliente.Usu_Ult_Mod;
                objClienteDC.Fec_Ult_Mod = Convert.ToDateTime(objCliente.Fec_Ult_Mod);

                return objClienteDC;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClienteDC ConsultaClienteDNI(String strDni)
        {
            ReservaYogaEntities MisReservas = new ReservaYogaEntities();
            try
            {
                Tb_Cliente objCliente = (from objCli in MisReservas.Tb_Cliente
                                         where objCli.Dni_cli == strDni
                                         select objCli).FirstOrDefault();

                ClienteDC objClienteDC = new ClienteDC();
                objClienteDC.Id_Cliente = Convert.ToInt16(objCliente.Id_Cliente);
                objClienteDC.Dni_cli = objCliente.Dni_cli;
                objClienteDC.Nombres = objCliente.Nombres;
                objClienteDC.ApePaterno = objCliente.ApePaterno;
                objClienteDC.ApeMaterno = objCliente.ApeMaterno;

                return objClienteDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClienteDC> ListarCliente()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<ClienteDC> objListaClienteDC = new List<ClienteDC>();

                var query = (from miCliente in MisReservas.Tb_Cliente
                             join objUbi in MisReservas.Tb_Ubigeo on miCliente.Id_Ubigeo equals objUbi.Id_Ubigeo
                             orderby miCliente.ApePaterno
                             select miCliente).ToList();

                foreach(var objCliente in query)
                {
                    ClienteDC objClienteDC = new ClienteDC();

                    objClienteDC.Id_Cliente = Convert.ToInt16(objCliente.Id_Cliente);
                    objClienteDC.Nombres = objCliente.Nombres;
                    objClienteDC.ApePaterno = objCliente.ApePaterno;
                    objClienteDC.ApeMaterno = objCliente.ApeMaterno;
                    objClienteDC.Correo = objCliente.Correo;
                    objClienteDC.Tel_cli = objCliente.Tel_cli;
                    objClienteDC.Dir_cli = objCliente.Dir_cli;
                    objClienteDC.Dni_cli = objCliente.Dni_cli;
                    objClienteDC.Sexo = objCliente.Sexo;
                    //Cambio 5
                    if (objClienteDC.Sexo == "M")
                    {
                        objClienteDC.SexoTexto = "Masculino";
                    }
                    else if (objClienteDC.Sexo == "F")
                    {
                        objClienteDC.SexoTexto = "Femenino";
                    }
                    else
                    {
                        objClienteDC.SexoTexto = "No asignado";
                    }

                    objClienteDC.Fec_nac = Convert.ToDateTime(objCliente.Fec_nac);
                    objClienteDC.Est_cli = Convert.ToInt16(objCliente.Est_cli);
                    //Cambio 2
                    if (objClienteDC.Est_cli == 0)
                    {
                        objClienteDC.EstadoTexto = "Inactivo";
                    }
                    else if (objClienteDC.Est_cli == 1)
                    {
                        objClienteDC.EstadoTexto = "Activo";
                    }
                    else
                    {
                        objClienteDC.EstadoTexto = "No asignado";
                    }

                    objClienteDC.Id_Ubigeo = objCliente.Id_Ubigeo;
                    objClienteDC.Departamento = objCliente.Tb_Ubigeo.Departamento;
                    objClienteDC.Provincia = objCliente.Tb_Ubigeo.Provincia;
                    objClienteDC.Distrito = objCliente.Tb_Ubigeo.Distrito;
                    objClienteDC.Fec_reg = Convert.ToDateTime(objCliente.Fec_reg);
                    objClienteDC.Usu_reg = objCliente.Usu_reg;
                    objClienteDC.Usu_Ult_Mod = objCliente.Usu_Ult_Mod;
                    objClienteDC.Fec_Ult_Mod = Convert.ToDateTime(objCliente.Fec_Ult_Mod);

                    objListaClienteDC.Add(objClienteDC);
               
                }
                return objListaClienteDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<ClienteDC> ListarClienteEstado()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<ClienteDC> objListaClienteDC = new List<ClienteDC>();

                var query = (from miCliente in MisReservas.Tb_Cliente
                             join objUbi in MisReservas.Tb_Ubigeo on miCliente.Id_Ubigeo equals objUbi.Id_Ubigeo
                             where miCliente.Est_cli == 1
                             orderby miCliente.Id_Cliente /* CORREGIDO */
                             select miCliente).ToList();

                foreach (var objCliente in query)
                {
                    ClienteDC objClienteDC = new ClienteDC();

                    // Cambio 6 Estado

                    objClienteDC.Est_cli = Convert.ToInt16(objCliente.Est_cli);
                    objClienteDC.EstadoTexto = "Activo";
                    objClienteDC.Id_Cliente = Convert.ToInt16(objCliente.Id_Cliente);
                    objClienteDC.Nombres = objCliente.Nombres;
                    objClienteDC.ApePaterno = objCliente.ApePaterno;
                    objClienteDC.ApeMaterno = objCliente.ApeMaterno;
                    objClienteDC.Correo = objCliente.Correo;
                    objClienteDC.Tel_cli = objCliente.Tel_cli;
                    objClienteDC.Dir_cli = objCliente.Dir_cli;
                    objClienteDC.Dni_cli = objCliente.Dni_cli;
                    objClienteDC.Sexo = objCliente.Sexo;
                    //Cambio 5
                    if (objClienteDC.Sexo == "M")
                    {
                        objClienteDC.SexoTexto = "Masculino";
                    }
                    else if (objClienteDC.Sexo == "F")
                    {
                        objClienteDC.SexoTexto = "Femenino";
                    }
                    else
                    {
                        objClienteDC.SexoTexto = "No asignado";
                    }

                    objClienteDC.Fec_nac = Convert.ToDateTime(objCliente.Fec_nac);

                    objClienteDC.Id_Ubigeo = objCliente.Id_Ubigeo;
                    objClienteDC.Departamento = objCliente.Tb_Ubigeo.Departamento;
                    objClienteDC.Provincia = objCliente.Tb_Ubigeo.Provincia;
                    objClienteDC.Distrito = objCliente.Tb_Ubigeo.Distrito;
                    objClienteDC.Fec_reg = Convert.ToDateTime(objCliente.Fec_reg);
                    objClienteDC.Usu_reg = objCliente.Usu_reg;
                    objClienteDC.Usu_Ult_Mod = objCliente.Usu_Ult_Mod;
                    objClienteDC.Fec_Ult_Mod = Convert.ToDateTime(objCliente.Fec_Ult_Mod);

                    objListaClienteDC.Add(objClienteDC);

                }
                return objListaClienteDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarCliente(ClienteDC objClienteDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                MisReservas.usp_InsertarCliente_TEST(
                    objClienteDC.Nombres, 
                    objClienteDC.ApePaterno, 
                    objClienteDC.ApeMaterno,
                    objClienteDC.Correo,
                    objClienteDC.Tel_cli,
                    objClienteDC.Dir_cli,
                    objClienteDC.Dni_cli,
                    objClienteDC.Sexo,
                    Convert.ToDateTime(objClienteDC.Fec_nac),
                    Convert.ToInt16(objClienteDC.Est_cli),
                    objClienteDC.Id_Ubigeo, 
                    objClienteDC.Usu_reg
                    );

                MisReservas.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarCliente(ClienteDC objClienteDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                MisReservas.usp_ActualizarCliente(
                    objClienteDC.Id_Cliente,
                    objClienteDC.Nombres,
                    objClienteDC.ApePaterno,
                    objClienteDC.ApeMaterno,
                    objClienteDC.Correo,
                    objClienteDC.Tel_cli,
                    objClienteDC.Dir_cli,
                    objClienteDC.Dni_cli,
                    objClienteDC.Sexo,
                    Convert.ToDateTime(objClienteDC.Fec_nac),
                    Convert.ToInt16(objClienteDC.Est_cli),
                    objClienteDC.Id_Ubigeo,
                    objClienteDC.Usu_Ult_Mod
                    );

                MisReservas.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public Boolean EliminarCliente( Int16 strId)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                MisReservas.usp_EliminarCliente(strId);

                MisReservas.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean UpdateClienteEstado(ClienteDC objClienteDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                MisReservas.usp_ActualizarClienteEstado(
                    objClienteDC.Id_Cliente,
                    objClienteDC.Comentario
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
