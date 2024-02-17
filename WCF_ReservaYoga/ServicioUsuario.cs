using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuario : IServicioUsuario
    {
        public Boolean InsertarUsuario(UsuarioDC objUsuarioDC)
        {

            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                Tb_Usuario nuevoUsuario = new Tb_Usuario
                {
                    Login_Usuario = objUsuarioDC.Login_Usuario,
                    Pass_Usuario = objUsuarioDC.Pass_Usuario,
                    Niv_Usuario = objUsuarioDC.Niv_Usuario,
                    Est_Usuario = objUsuarioDC.Est_Usuario,
                    Fec_Registro = objUsuarioDC.Fec_Registro,
                    Usu_Registro = objUsuarioDC.Usu_Registro
                };

                MisReservas.Tb_Usuario.Add(nuevoUsuario);
                MisReservas.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarUsuario(UsuarioDC objUsuarioDC)
        {
            try
            {
                using (ReservaYogaEntities MisReservas = new ReservaYogaEntities())
                {
                    // Buscar el usuario en la base de datos por Login_Usuario
                    Tb_Usuario usuario = MisReservas.Tb_Usuario.FirstOrDefault(u => u.Login_Usuario == objUsuarioDC.Login_Usuario);

                    if (usuario != null)
                    {
                        // Actualizar los datos del usuario con los valores proporcionados
                        usuario.Pass_Usuario = objUsuarioDC.Pass_Usuario;
                        usuario.Niv_Usuario = objUsuarioDC.Niv_Usuario;
                        usuario.Est_Usuario = objUsuarioDC.Est_Usuario;
                        usuario.Fec_Registro = objUsuarioDC.Fec_Registro;
                        usuario.Usu_Registro = objUsuarioDC.Usu_Registro;

                        // Guardar los cambios en la base de datos
                        MisReservas.SaveChanges();
                        return true;
                    }
                    else
                    {
                        // Manejar el caso en que el usuario no sea encontrado
                        throw new Exception("No se encontró el usuario a actualizar");
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                throw new Exception("Error al actualizar usuario: " + ex.Message);
            }
        }

        public UsuarioDC ConsultarUsuario(String strCodigo)
        {
            try
            {
                using (ReservaYogaEntities MisReservas = new ReservaYogaEntities())
                {
                    // Buscar el usuario en la base de datos por su código (por ejemplo, nombre de usuario)
                    Tb_Usuario usuario = MisReservas.Tb_Usuario.FirstOrDefault(u => u.Login_Usuario == strCodigo);

                    if (usuario != null)
                    {
                        // Crear un objeto UsuarioDC y llenarlo con los datos del usuario encontrado
                        UsuarioDC usuarioEncontrado = new UsuarioDC
                        {
                            Login_Usuario = usuario.Login_Usuario,
                            Pass_Usuario = usuario.Pass_Usuario,
                            Niv_Usuario = (short)usuario.Niv_Usuario,
                            Est_Usuario = (short)usuario.Est_Usuario,
                            Fec_Registro = (DateTime)usuario.Fec_Registro,
                            Usu_Registro = usuario.Usu_Registro
                        };

                        return usuarioEncontrado;
                    }
                    else
                    {
                        // Manejar el caso en que el usuario no sea encontrado
                        throw new Exception("No se encontró el usuario con el Login especificado");
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar usuario: " + ex.Message);
            }
        }

        public List<UsuarioDC> ListarUsuario()
        {
            try
            {
                List<UsuarioDC> usuarios = new List<UsuarioDC>();

                using (ReservaYogaEntities MisReservas = new ReservaYogaEntities())
                {
                    var usuariosBD = MisReservas.Tb_Usuario.ToList();

                    foreach (var usuario in usuariosBD)
                    {
                        usuarios.Add(new UsuarioDC
                        {
                            Login_Usuario = usuario.Login_Usuario,
                            Pass_Usuario = usuario.Pass_Usuario,
                            Niv_Usuario = (short)usuario.Niv_Usuario,
                            Est_Usuario = (short)usuario.Est_Usuario,
                            Fec_Registro = (DateTime)usuario.Fec_Registro,
                            Usu_Registro = usuario.Usu_Registro
                        });
                    }
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí, puedes loggearla, relanzarla, etc.
                throw new Exception("Error al listar usuarios: " + ex.Message);
            }
        }



    }
}
