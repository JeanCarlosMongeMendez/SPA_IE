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
    
    public partial class SelectAppointment_Result
    {
        public int IdAppointment { get; set; }
        public int IdProfessor { get; set; }
        public string NameProfessor { get; set; }
        public int IdStudent { get; set; }
        public string NameStudent { get; set; }
        public int IdCourse { get; set; }
        public string Name { get; set; }
        public int idSchedule { get; set; }
        public System.DateTime Day { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime FinalTime { get; set; }
        public Nullable<bool> StatusApprovedDisapproved { get; set; }
        public Nullable<bool> VirtualOn_Site { get; set; }
        public string ReasonForAppointment { get; set; }
        public Nullable<bool> ProfessorResponse { get; set; }
    }
}
