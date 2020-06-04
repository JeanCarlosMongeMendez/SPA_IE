using System;

namespace SPA_IE.Models.Domain.DTO
{
    public class UserProfileDTO
    {
        public int IdUserProfile { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserPhoto { get; set; }
        public string Interests { get; set; }
        public string Email { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        public Nullable<bool> IsEnable { get; set; }
        public Nullable<int> IdProvince { get; set; }
        public string NameProvince { get; set; }
        public Nullable<int> IdCanton { get; set; }
        public string NameCanton { get; set; }
        public Nullable<int> IdDistrict { get; set; }
        public string NameDistrict { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }


    }
}