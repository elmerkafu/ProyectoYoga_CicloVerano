using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuarioRol" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuarioRol
    {
        [OperationContract]
        Boolean InsertarUsuario(UsuarioRolDC objUsuarioRolDC);

        [OperationContract]
        List<UsuarioRolDC> ListarRol();

        [OperationContract]
        UsuarioRolDC ConsultarUsuario(String Login);
    }
    [DataContract]
    [Serializable]
    public class UsuarioRolDC
    {
        // DE TABLA USUARIO
        [DataMember]
        public String Login_Usuario_Correo { get; set; }

        [DataMember]
        public int Est_Usuario { get; set; }

        [DataMember]
        public DateTime Fec_Registro { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

        [DataMember]
        public String Usu_Ult_Mod {  get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        [DataMember]
        public String Pass_Usuario { get; set; }
       
        [DataMember]
        public Int16 Id_Rol { get; set; }        


        // DE TABLA ROLES
        [DataMember]
        public String Nombre { get; set; }

        [DataMember]
        public Int16 Nivel { get; set; }

        // DE TABLA PERSONAL
        [DataMember]
        public String Nombres { get; set; }
        [DataMember]
        public String ApePaterno { get; set; }
        [DataMember]
        public String ApeMaterno { get; set; }
        [DataMember]
        public String Dni_Personal { get; set; }
        [DataMember]
        public DateTime Fec_nac { get; set; }
        [DataMember]
        public String Correo { get; set; }
        [DataMember]
        public String Telefono { get; set; }
        [DataMember]
        public String Direccion { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public String Departamento { get; set; }
        [DataMember]
        public String Provincia { get; set; }
        [DataMember]
        public String Distrito { get; set; }
        [DataMember]
        public Int16 Estado { get; set; }
        [DataMember]
        public DateTime Fec_Reg { get; set; }
        [DataMember]
        public String Usu_Reg { get; set; }
        [DataMember]
        public String Comentario { get; set; }

    }
}