using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain.DTO
{
    public class CommentDTO
    {
        public int IdComment { get; set; }
        public Nullable<int> IdUserProfile { get; set; }  
        public string Username { get; set; }
        public int IdConsultation { get; set; }
     
        public string Commentary { get; set; }
    }
}