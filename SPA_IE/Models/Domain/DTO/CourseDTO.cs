using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain.DTO
{
    public class CourseDTO
    {

        public int IdCourse { get; set; }
        public string Name { get; set; }
        public string Semestrer { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<bool> state { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
    }
}