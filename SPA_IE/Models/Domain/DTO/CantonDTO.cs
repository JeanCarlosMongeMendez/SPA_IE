using System;

namespace SPA_IE.Models.Data.DTO
{
    public class CantonDTO
    {
        public int IdCanton { get; set; }
        public string Name { get; set; }

        public Nullable<int> IdProvinceCanton { get; set; }

    }
}