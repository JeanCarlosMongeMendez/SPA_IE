using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.DTO
{
    public class StudentDTO : UserProfileDTO
    {
        public int IdStudent { get; set; }
        public string IdentificationCard { get; set; }
    }
}