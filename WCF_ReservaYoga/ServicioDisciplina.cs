using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioDisciplina" en el código y en el archivo de configuración a la vez.
    public class ServicioDisciplina : IServicioDisciplina
    {
        public Boolean InsertarDisciplina(DisciplinaDC objDisciplinaDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                MisReservas.usp_InsertarDisciplina(
                    objDisciplinaDC.Nombre,
                    objDisciplinaDC.Duracion,
                    objDisciplinaDC.Intensidad,
                    Convert.ToDecimal(objDisciplinaDC.Precio),
                    Convert.ToInt16(objDisciplinaDC.Id_Cat)
                    );

                MisReservas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarDisciplina(DisciplinaDC objDisciplinaDC)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                MisReservas.usp_ActualizarDisciplina(
                    objDisciplinaDC.Cod_disp,
                    objDisciplinaDC.Nombre,
                    objDisciplinaDC.Duracion,
                    objDisciplinaDC.Intensidad,
                    Convert.ToDecimal(objDisciplinaDC.Precio),
                    objDisciplinaDC.Id_Cat
                    );
                MisReservas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarDisciplina(String strCodigo)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                MisReservas.usp_EliminarDisciplina(strCodigo);

                MisReservas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DisciplinaDC ConsultarDisciplina(String strCodigo)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                Tb_Disciplina objDisciplina = (from objDisp in MisReservas.Tb_Disciplina
                                               where objDisp.Cod_disp == strCodigo
                                               select objDisp).FirstOrDefault();

                DisciplinaDC objDisciplinaDC = new DisciplinaDC();

                if (objDisciplina == null)
                {
                    objDisciplinaDC.Cod_disp = "";
                }
                else
                {
                    objDisciplinaDC.Cod_disp = objDisciplina.Cod_disp;
                    objDisciplinaDC.Nombre = objDisciplina.Nombre;
                    objDisciplinaDC.Duracion = objDisciplina.Duracion;
                    objDisciplinaDC.Intensidad = objDisciplina.Intensidad;
                    objDisciplinaDC.Precio = Convert.ToSingle(objDisciplina.Precio);
                    objDisciplinaDC.Id_Cat = Convert.ToInt16(objDisciplina.Id_Cat);
                }
                return objDisciplinaDC;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DisciplinaDC> ListarDisciplina()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<DisciplinaDC> objListarDisciplinaDC = new List<DisciplinaDC>();

                var query = (from miDisp in MisReservas.Tb_Disciplina
                             join misCateg in MisReservas.Tb_Categoria
                             on miDisp.Id_Cat equals misCateg.Id_Cat
                             orderby miDisp.Cod_disp
                             select miDisp).ToList();

                foreach (var objDisciplina in query)
                {
                    DisciplinaDC objDisciplinaDC = new DisciplinaDC();
                    objDisciplinaDC.Cod_disp = objDisciplina.Cod_disp;
                    objDisciplinaDC.Nombre = objDisciplina.Nombre;
                    objDisciplinaDC.Duracion = objDisciplina.Duracion;
                    objDisciplinaDC.Intensidad = objDisciplina.Intensidad;
                    objDisciplinaDC.Precio = Convert.ToSingle(objDisciplina.Precio);
                    //objDisciplinaDC.Id_Cat = Convert.ToInt16(objDisciplina.Id_Cat);


                    objDisciplinaDC.Categoria = objDisciplina.Tb_Categoria.Nombre;
                    objListarDisciplinaDC.Add(objDisciplinaDC);
                }
                return objListarDisciplinaDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DisciplinaDC> ListarCategoria()
        {
            try
            {
                // Instanciamos el modelo 
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();

                List<DisciplinaDC> objListaCategoriaDC = new List<DisciplinaDC>();

                // con LINQ...
                var query = (from miCategoria in MisReservas.Tb_Categoria
                             select miCategoria
                    ).ToList();
                foreach (var objCategoria in query)
                {
                    DisciplinaDC objDisciplinaDC = new DisciplinaDC();
                    objDisciplinaDC.Id_Cat = Convert.ToInt16(objCategoria.Id_Cat);
                    objDisciplinaDC.Nombre = objCategoria.Nombre;

                    objListaCategoriaDC.Add(objDisciplinaDC);
                }
                return objListaCategoriaDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }       

    }
}
