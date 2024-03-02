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
    }
}
