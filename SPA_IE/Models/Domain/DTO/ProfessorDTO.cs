using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain.DTO
{
    public class ProfessorDTO
    {
        public int idProfessor { get; set; }
        public string degree { get; set; }
        public int idUserProfile { get; set; }
    }
}