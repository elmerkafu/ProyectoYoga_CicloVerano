using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IConsultaInstructorClases" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConsultaInstructorClases
    {        
        [OperationContract]
        List<ConsultaDC> ListarClasesProgramadasInstructor(String strCodigo, DateTime fecIni);

        [OperationContract]
        List<ConsultaDC> ListarClasesEntreFechas(String strCodigo, DateTime fecIni, DateTime fecFin);
    }
    [DataContract]
    [Serializable]
    public class ConsultaDC
    {
        // DE TABLA CLASE PROGRAMADA

        [DataMember]
        public Int16 Id_Clase_Prog { get; set; }

        [DataMember]
        public Int16 Id_Salon { get; set; }        

        [DataMember]
        public String Id_Inst_Disp { get; set; }        

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

        // DE TABLA INSTRUCTOR - DISCIPLINA

        [DataMember]
        public String Cod_disp { get; set; }

        // DE TABLA DISCIPLINA

        [DataMember]
        public String NombreDisciplina { get; set; }

        [DataMember]
        public String Duracion { get; set; }

        [DataMember]
        public String Intensidad { get; set; }  

    }
}
