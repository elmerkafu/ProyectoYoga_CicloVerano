using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioReserva" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioReserva
    {
        [OperationContract]
        Int16 ContarReservasTotales();

        [OperationContract]
        Int16 ContarReservasCliente(Int16 strCodigo);

        [OperationContract]
        DateTime? ObtenerFechaReservaPorCodigo(string codigoReserva);

        [OperationContract]
        List<ReservaDC> ListarReservaClienteFechas(Int16 strCodigo, DateTime fecIni, DateTime fecFin);        

        [OperationContract]
        Boolean InsertarReserva(ReservaDC objReservaDC);

        [OperationContract]
        List<ReservaDC> ListarReservasCliente(Int16 intCod);


    }
    [DataContract]
    [Serializable]
    public class ReservaDC
    {
        [DataMember]
        public String Cod_resv { get; set; }

        [DataMember]
        public Int16 Id_Cliente { get; set; }

        [DataMember]
        public Int16 Id_Clase_Prog { get; set; }

        [DataMember]
        public String Nombre { get; set; }

        [DataMember]
        public Int16 Est_resv { get; set; }

        [DataMember]
        public String EstRev { get; set; }

        [DataMember]
        public DateTime Fec_resv { get; set; }

        [DataMember]
        public String Observacion { get; set; }

        [DataMember]
        public DateTime Fec_reg { get; set; }

        [DataMember]
        public String Usu_reg { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        // VIENE DE CLASE PROGRAMADA

        [DataMember]
        public DateTime Fec_Clase { get; set; }

        [DataMember]
        public DateTime Hora_Emp { get; set; }

        [DataMember]
        public DateTime Hora_Term { get; set; }


        // VIENE DE INSTRUCTOR

        [DataMember]
        public String NombreInstructor { get; set; }

        // VIENE DE DISCIPLINA

        [DataMember]
        public String Disciplina { get; set; }

        [DataMember]
        public String Duracion { get; set; }    

        [DataMember]
        public String Intensidad { get; set; }

       
        // VIENE DE SALON 

        [DataMember]
        public String Salon { get; set; }      // Nombre del salón       
    }
}
