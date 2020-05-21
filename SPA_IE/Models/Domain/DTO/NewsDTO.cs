using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain.DTO
{
    public class NewsDTO
    {
        public int IdNews { get; set; }
        public Nullable<int> IdUserCreator { get; set; }
        public string Description { get; set; }
        public string Documentation { get; set; }
        public string NewsType { get; set; }
        public string Image { get; set; }

        public string Username { get; set; }
    }
}