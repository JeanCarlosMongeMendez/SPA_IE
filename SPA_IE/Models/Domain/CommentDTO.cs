using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class CommentDTO
    {
        public int IdComment { get; set; }
        public int IdNews { get; set; }
        public int IdUserProfile { get; set; }
        public string Commentary { get; set; }

        public string Username { get; set; }
    }
}