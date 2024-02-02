using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioInstructorDisciplina" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioInstructorDisciplina
    {
        [OperationContract]
        List<InstructorDisciplinaDC> Instructor();

        [OperationContract]
        List<InstructorDisciplinaDC> Instructor_Disciplina_Combo(String Id_Instructor);
        
    }
    [DataContract]
    [Serializable]
    public class InstructorDisciplinaDC
    {
        [DataMember]
        public String Id_Inst_Disp { get; set; }

        [DataMember]
        public String Id_Instructor { get; set; }

        [DataMember]
        public String Cod_disp { get; set; }

        [DataMember]
        public String NombreInstructor { get; set; } // AQUI 

        [DataMember]
        public String NombreDisciplina { get; set; }

        [DataMember]
        public String Nombre_del_Instructor { get; set; }

        [DataMember]
        public String Nombre {  get; set; }

    }
}
