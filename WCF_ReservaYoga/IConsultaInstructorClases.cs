using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IConsultaInstructorClases" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConsultaInstructorClases
    {
        [TransactionFlow(TransactionFlowOption.Allowed)]
        [OperationContract]
        List<ConsultaDC> ListarClasesProgramadasInstructor(String strCodigo, DateTime fecIni);
    }
    [DataContract]
    [Serializable]
    public class ConsultaDC
    {/*
        
        [DataMember]
        public Int16 Id_Clase_Prog { get; set; }*/

        [DataMember]
        public Int16 Id_Salon { get; set; }
        /*

        [DataMember]
        public String Id_Inst_Disp { get; set; }        */

        [DataMember]
        public DateTime Fec_Clase { get; set; }

        [DataMember]
        public DateTime Hora_Emp { get; set; }

        [DataMember]
        public DateTime Hora_Term { get; set; }

        [DataMember]
        public Int16 Est_clase { get; set; }
        [DataMember]
        public String EstadoClase { get; set; }
        [DataMember]
        public String NombreSalon { get; set; }
        /*

        [DataMember]
        public DateTime Fec_reg { get; set; }       

        [DataMember]
        public String Usu_reg { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }

        [DataMember]
        public String Fec_Ult_Mod { get; set; }*/

    }
}
