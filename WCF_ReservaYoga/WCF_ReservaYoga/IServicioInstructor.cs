using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioInstructor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioInstructor
    {
        [OperationContract]
        Boolean InsertarInstructor(InstructorDC objInstructorDC);

        [OperationContract]
        Boolean ActualizarInstructor(InstructorDC objInstructorDC);

        [OperationContract]
        Boolean EliminarInstructor(String strCodigo);

        [OperationContract]
        InstructorDC ConsultarInstructor(String strCodigo);

        [OperationContract]
        List<InstructorDC> ListarInstructor();

        [OperationContract]
        List<InstructorDC> ListarNombreInstructor();
    }
    [DataContract]
    [Serializable]
    public class InstructorDC
    {

        [DataMember]
        public String Id_Instructor { get; set; }
        [DataMember]
        public String Nombre { get; set; }
        [DataMember]
        public String ApePaterno { get; set; }
        [DataMember]
        public String ApeMaterno { get; set; }
        [DataMember]
        public String Correo { get; set; }
        [DataMember]
        public String Tel_inst { get; set; }
        [DataMember]
        public String Dni_inst { get; set; }
        [DataMember]
        public String Dir_inst { get; set; }
        [DataMember]
        public DateTime Fec_nac { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public String Departamento { get; set; }
        [DataMember]
        public String Provincia { get; set; }
        [DataMember]
        public String Distrito { get; set; }
        [DataMember]
        public String Foto { get; set; }
        [DataMember]
        public Int16 Est_ins { get; set; }

        [DataMember]
        public String EstadoInst { get; set; }

        [DataMember]
        public DateTime Fec_reg { get; set; }
        [DataMember]
        public String Usu_reg { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        [DataMember]
        public String NombreInstructor { get; set; }
    }
}
