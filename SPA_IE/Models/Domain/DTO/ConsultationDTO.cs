using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain.DTO
{
    public class ConsultationDTO
    {
        public int IdConsultation { get; set; }
        public Nullable<int> IdCourse { get; set; }
        public string NameCourse { get; set; }
        public string Description { get; set; }
        public Nullable<int> IdTransmitter { get; set; }
        public string NameTransmitter { get; set; }
        public Nullable<int> IdReceiver { get; set; }
        public string NameReceiver { get; set; }
    }
}