using SPA_IE.Models.Data;
using SPA_IE.Models.Data.DTO;
using System;
using System.Activities.Tracking;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain.DTO
{
    public class AppoitmentDTO
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

    }
}