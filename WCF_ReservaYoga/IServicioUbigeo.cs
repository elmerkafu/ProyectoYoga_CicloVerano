using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbigeo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<UbigeoDC> Ubigeo_Departamentos();

        [OperationContract]
        List<UbigeoDC> Ubigeo_ProvinciasDepartamento(string IdDepa);

        [OperationContract]
        List<UbigeoDC> Ubigeo_DistritosProvinciaDepartamento(string IdDepa, string IdProv);
    }
    [DataContract]
    [Serializable]
    public class UbigeoDC
    {
        [DataMember]
        public String Id_Ubigeo { get; set; }

        [DataMember]
        public String IdDepa { get; set; }

        [DataMember]
        public String IdProv { get; set; }

        [DataMember]
        public String IdDist { get; set; }

        [DataMember]
        public String Departamento { get; set; }

        [DataMember]
        public String Provincia { get; set; }

        [DataMember]
        public String Distrito { get; set; }


    }
}
