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
    
    public partial class Appointment
    {
        public int IdAppointment { get; set; }
        public Nullable<int> IdProfessor { get; set; }
        public Nullable<int> IdStudent { get; set; }
        public Nullable<int> IdCourse { get; set; }
        public Nullable<int> IdSchedule { get; set; }
        public Nullable<bool> StatusApprovedDisapproved { get; set; }
        public Nullable<bool> VirtualOn_Site { get; set; }
        public string ReasonForAppointment { get; set; }
        public Nullable<bool> ProfessorResponse { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
