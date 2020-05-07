using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain.DTO
{
    public class UserProfileDTO
    {
        public int idUserProfile { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string userPhoto { get; set; }
        public string interests { get; set; }
        public string email { get; set; }
        public bool isAdmin { get; set; }
        public bool isEnable { get; set; }
        public int idProvince { get; set; }
        public string nameProvince { get; set; }
        public int idCanton { get; set; }
        public string nameCanton { get; set; }
        public int idDistrict { get; set; }
        public string nameDistrict { get; set; }
        public string usernameCreator { get; set; }
        public DateTime creationDate { get; set; }
    }
}