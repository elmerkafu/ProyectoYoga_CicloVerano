using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioDisciplina" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioDisciplina
    {
        [OperationContract]
        Boolean InsertarDisciplina(DisciplinaDC objDisciplinaDC);

        [OperationContract]
        Boolean ActualizarDisciplina(DisciplinaDC objDisciplinaDC);

        [OperationContract]
        Boolean EliminarDisciplina(String strCodigo);

        [OperationContract]
        List<DisciplinaDC> ListarDisciplina();

        [OperationContract]
        DisciplinaDC ConsultarDisciplina(String strCodigo);

        [OperationContract]
        List<DisciplinaDC> ListarCategoria();

        [OperationContract]
        Boolean UpdateDisciplinaEstado(DisciplinaDC objDisciplinaDC);


    }
    [DataContract]
    [Serializable]
    public class DisciplinaDC
    {
        [DataMember]
        public String Cod_disp { get; set; }

        [DataMember]
        public String Nombre { get; set; }

        [DataMember]
        public String Duracion { get; set; }

        [DataMember]
        public String Intensidad { get; set; }

        [DataMember]
        public Single Precio { get; set; }

        [DataMember]
        public Int16 Id_Cat { get; set; }

        [DataMember]
        public String Categoria { get; set; }

        [DataMember]
        public String Comentario { get; set; }

        [DataMember]
        public Int16 Estado { get; set; }

    }
}
