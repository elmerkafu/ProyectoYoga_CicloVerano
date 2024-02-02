using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioSalon" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioSalon
    {
        [OperationContract]
        List<SalonDC> ListarSalon();

        [OperationContract]
        List<SalonDC> ListarSalon_Grid();

        [OperationContract]
        Boolean InsertarSalon(SalonDC objSalonDC);

        [OperationContract]
        Boolean ActualizarSalon(SalonDC objSalonDC);

        [OperationContract]
        SalonDC ConsultarSalon(Int16 strId);
    }
    [DataContract]
    [Serializable]
    public class SalonDC
    {
        [DataMember]
        public Int16 Id_Salon { get; set; }

        [DataMember]
        public String Nombre { get; set; }

        [DataMember]
        public String Area { get; set; }

        [DataMember]
        public Int16 Capacidad { get; set; }

        [DataMember]
        public Int16 Estado { get; set; }

        [DataMember]
        public String Descripcion { get; set; }

        [DataMember]
        public String EstadoTexto { get; set; }
     }
}
