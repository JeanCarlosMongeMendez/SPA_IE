using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain.DTO
{
    public class ScheduleDTO
    {
        public int idSchedule { get; set; }
        public int IdCourse { get; set; }
        public int IdProfessor { get; set; }
        public System.DateTime Day { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime FinalTime { get; set; }

    }
}