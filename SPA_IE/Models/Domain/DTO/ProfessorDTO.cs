using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain.DTO
{
    public class ProfessorDTO : UserProfileDTO
    {
        public int IdProfessor { get; set; }
        public string Degree { get; set; }
    }
}