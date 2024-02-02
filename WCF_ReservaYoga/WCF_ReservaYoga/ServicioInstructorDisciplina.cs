using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ReservaYoga
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioInstructorDisciplina" en el código y en el archivo de configuración a la vez.
    
    public class ServicioInstructorDisciplina : IServicioInstructorDisciplina
    {
        public List<InstructorDisciplinaDC> Instructor()
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                var result = MisReservas.usp_Combo_Instructor();

                List<InstructorDisciplinaDC> objListarInstructorDC = result.Select(r => new InstructorDisciplinaDC
                { 
                    Id_Instructor = r.Id_Instructor,
                    NombreInstructor = r.Nombre_del_Instructor
                }).ToList();

                return objListarInstructorDC;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InstructorDisciplinaDC> Instructor_Disciplina_Combo(String Id_Instructor)
        {
            try
            {
                ReservaYogaEntities MisReservas = new ReservaYogaEntities();
                var result = MisReservas.usp_Combo_InstructorDisciplina(Id_Instructor);

                List<InstructorDisciplinaDC> objListarDisciplinaDC = result.Select(r => new InstructorDisciplinaDC
                {
                    Cod_disp = r.Cod_disp,
                    NombreDisciplina = r.Nombre,
                }).ToList();

                return objListarDisciplinaDC;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
       
  
}
