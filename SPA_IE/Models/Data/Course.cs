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
    
    public partial class Course
    {
        public int IdCourse { get; set; }
        public string Name { get; set; }
        public string Semestrer { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<bool> state { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
    }
}
