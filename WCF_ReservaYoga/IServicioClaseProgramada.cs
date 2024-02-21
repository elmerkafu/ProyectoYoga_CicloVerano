using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioClaseProgramada" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioClaseProgramada
    {
        [OperationContract]
        List<ClaseProgramadaDC> ListarClaseProgramada();

        [OperationContract]
        Boolean InsertarClaseProgramada(ClaseProgramadaDC objClaseProgramadaDC);

        [OperationContract]
        Boolean ActualizarClaseProgramada(ClaseProgramadaDC objClaseProgramadaDC);

        [OperationContract]
        List<ClaseProgramadaDC> ListarNombreInstructor();

        [OperationContract]
        ClaseProgramadaDC ConsultarClaseProgramada(Int16 strId);

        [OperationContract]
        ClaseProgramadaDC ConsultarClase_PorFecha(DateTime strId);

        [OperationContract]
        List<ClaseProgramadaDC> ListarClasesPorFecha(DateTime strId);

    }
    [DataContract]
    [Serializable]
    public class ClaseProgramadaDC
    {
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
        public String Estado { get; set; }

        [DataMember]
        public DateTime Fec_reg { get; set; }

        [DataMember]
        public String Usu_reg { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        // DE TB.SALON

        [DataMember]
        public String NombreSalon { get; set; }

        [DataMember]
        public Int16 Capacidad { get; set; }

        // DE TB.INSTRUCTOR_DISCIPLINA

        [DataMember]
        public String NombreInstructor { get; set;}

        [DataMember]
        public String Nombre {  get; set; }

        [DataMember]
        public String ApellidoPInstructor { get; set; }

        [DataMember]
        public String ApellidoMInstructor { get; set; }

        [DataMember]
        public String Id_Instructor { get; set; }

        
        // DE TB.DISCIPLINA 

        [DataMember]
        public String NombreDisciplina { get; set; }

        [DataMember]
        public String Duracion { get; set; }

        [DataMember]
        public string Intensidad { get; set; }
    }
}
