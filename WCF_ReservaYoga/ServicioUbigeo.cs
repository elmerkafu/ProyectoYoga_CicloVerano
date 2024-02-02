using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbigeo" en el código y en el archivo de configuración a la vez.
    public class ServicioUbigeo : IServicioUbigeo
    {
        public List<UbigeoDC> Ubigeo_Departamentos()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                var result = MisReservas.usp_Ubigeo_Departamentos();

                // Mapear el resultado a objetos UbigeoDC
                List<UbigeoDC> objListaUbigeoDC = result.Select(r => new UbigeoDC
                {
                    IdDepa = r.IDDEPA,
                    Departamento = r.DEPARTAMENTO
                    // Agregar otros campos según sea necesario
                }).ToList();

                return objListaUbigeoDC;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<UbigeoDC> Ubigeo_ProvinciasDepartamento(string IdDepa)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                var result = MisReservas.usp_Ubigeo_ProvinciasDepartamento(IdDepa);

                // Mapear el resultado a objetos UbigeoDC
                List<UbigeoDC> objListaUbigeoDC = result.Select(r => new UbigeoDC
                {
                    IdProv = r.IDPROV,
                    Provincia = r.PROVINCIA
                    // Agregar otros campos según sea necesario
                }).ToList();

                return objListaUbigeoDC;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<UbigeoDC> Ubigeo_DistritosProvinciaDepartamento(string IdDepa, string IdProv)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                var result = MisReservas.usp_Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);

                // Mapear el resultado a objetos UbigeoDC
                List<UbigeoDC> objListaUbigeoDC = result.Select(r => new UbigeoDC
                {

                    IdDist = r.IDDIST,
                    Distrito = r.DISTRITO
                    // Agregar otros campos según sea necesario
                }).ToList();

                return objListaUbigeoDC;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
