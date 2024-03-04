using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuarioRol" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuarioRol : IServicioUsuarioRol
    {
        public Boolean InsertarUsuario(UsuarioRolDC objUsuarioRolDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                MisReservas.usp_InsertarUsuario_Personal(
                    objUsuarioRolDC.Pass_Usuario,
                    Convert.ToInt16(objUsuarioRolDC.Id_Rol),
                    objUsuarioRolDC.Nombres,
                    objUsuarioRolDC.ApePaterno,
                    objUsuarioRolDC.ApeMaterno,
                    objUsuarioRolDC.Dni_Personal,
                    Convert.ToDateTime(objUsuarioRolDC.Fec_nac),
                    objUsuarioRolDC.Correo,
                    objUsuarioRolDC.Telefono,
                    objUsuarioRolDC.Direccion,
                    objUsuarioRolDC.Id_Ubigeo,
                    objUsuarioRolDC.Usu_Reg                
                    
                    );

                MisReservas.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UsuarioRolDC> ListarRol()
        {
            try
            {
                // Instanciamos el modelo 
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<UsuarioRolDC> objListaRolDC = new List<UsuarioRolDC>();

                // con LINQ...
                var query = (from miRol in MisReservas.Tb_Rol
                             select miRol
                    ).ToList();
                foreach (var objRol in query)
                {
                    UsuarioRolDC objListaDC = new UsuarioRolDC();
                    objListaDC.Id_Rol = Convert.ToInt16(objRol.Id_Rol);
                    objListaDC.Nombre = objRol.Nombre;

                    objListaRolDC.Add(objListaDC);
                }
                return objListaRolDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UsuarioRolDC ConsultarUsuario(String Login)

        {
            ReservaYogaEntities MisReservas = new ReservaYogaEntities();
            try
            {
                Tb_Usuario objUsuario = (from objUsu in MisReservas.Tb_Usuario
                                               join objRol in MisReservas.Tb_Rol on objUsu.Id_Rol equals objRol.Id_Rol
                                               where objUsu.Login_Usuario_Correo == Login
                                               select objUsu).FirstOrDefault();

                UsuarioRolDC objUsuarioDC = new UsuarioRolDC();
                objUsuarioDC.Login_Usuario_Correo = objUsuario.Login_Usuario_Correo;
                objUsuarioDC.Pass_Usuario = objUsuario.Pass_Usuario;
                objUsuarioDC.Est_Usuario = Convert.ToInt16(objUsuario.Est_Usuario);
                objUsuarioDC.Fec_Registro = Convert.ToDateTime(objUsuario.Fec_Registro);
                objUsuarioDC.Id_Rol = Convert.ToInt16(objUsuario.Id_Rol);
                objUsuarioDC.Nombre = objUsuario.Tb_Rol.Nombre;
                objUsuarioDC.Nivel = Convert.ToInt16(objUsuario.Tb_Rol.Nivel);
                // quiza falte agregar el Usu_Registro 

                return objUsuarioDC;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
