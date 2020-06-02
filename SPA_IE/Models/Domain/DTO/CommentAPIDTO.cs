using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain.DTO
{
    public class CommentAPIDTO
    {
        public int IdComment { get; set; }
        public int IdNews { get; set; }
        public int IdUserProfile { get; set; }
        public string Commentary { get; set; }

        public string Username { get; set; }
    }
}