//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPA_IE.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Professor
    {
        public int IdProfessor { get; set; }
        public string Degree { get; set; }
        public Nullable<int> IdUserProfile { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
        public virtual UserProfile UserProfile1 { get; set; }
    }
}
