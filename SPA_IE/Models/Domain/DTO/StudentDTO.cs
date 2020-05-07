using SPA_IE.Models.Domain.DTO;
using System;

namespace SPA_IE.Models.Data.DTO
{
    public class StudentDTO : UserProfileDTO
    {
        public int IdStudent { get; set; }
        public string IdentificationCard { get; set; }

        public Nullable<bool> isASIP { get; set; }
        public Nullable<bool> isActive { get; set; }

    }
}