//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_ReservaYoga
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Disciplina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Disciplina()
        {
            this.Tb_Instructor_Disciplina = new HashSet<Tb_Instructor_Disciplina>();
        }
    
        public string Cod_disp { get; set; }
        public string Nombre { get; set; }
        public string Duracion { get; set; }
        public string Intensidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> Id_Cat { get; set; }
        public string Comentario { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual Tb_Categoria Tb_Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Instructor_Disciplina> Tb_Instructor_Disciplina { get; set; }
    }
}
