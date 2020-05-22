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
        public int IdAppointMent { get; set; }
        public int Professor { get; set; }
        public int Student { get; set; }
        public int Course { get; set; }
        public int Schedule { get; set; }
        public bool statusApprovedDisapproved { get; set; }
        public bool virtualOn_Site { get; set; }
        public string reasonForAppointment { get; set; }
        public bool professorResponse { get; set; }
        
    }
}