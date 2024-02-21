using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        Boolean InsertarCliente(ClienteDC objClienteDC);

        [OperationContract]
        Boolean ActualizarCliente(ClienteDC objClienteDC);

        [OperationContract]
        Boolean EliminarCliente(Int16 strId);

        [OperationContract]
        ClienteDC ConsultarCliente(Int16 strId);

        [OperationContract]
        List<ClienteDC> ListarCliente();

        [OperationContract]
        Boolean UpdateClienteEstado(ClienteDC objClienteDC);

        [OperationContract]
        List<ClienteDC> ListarClienteEstado();

        [OperationContract]
        ClienteDC ConsultaClienteDNI(String strDni);

    }
    [DataContract]
    [Serializable]
    public class ClienteDC
    {
        [DataMember]
        public Int16 Id_Cliente { get; set; }

        [DataMember]
        public String Nombres { get; set; }

        [DataMember]
        public String ApePaterno { get; set; }

        [DataMember]
        public String ApeMaterno { get; set; }

        [DataMember]
        public String Correo { get; set; }

        [DataMember]
        public String Tel_cli { get; set; }

        [DataMember]
        public String Dir_cli { get; set; }

        [DataMember]
        public String Dni_cli { get; set; }

        [DataMember]
        public String Sexo { get; set; }
        //Cambio 5
        [DataMember]
        public string SexoTexto { get; set; }

        [DataMember]
        public DateTime Fec_nac { get; set; }

        [DataMember]
        public Int16 Est_cli { get; set; }
        //Cambio 2
        [DataMember]
        public String EstadoTexto { get; set; }

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
        public DateTime Fec_reg { get; set; }

        [DataMember]
        public String Usu_reg { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        [DataMember]
        public String Comentario { get; set; }
    }
}
