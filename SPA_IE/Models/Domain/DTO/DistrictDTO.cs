using System;

namespace SPA_IE.Models.Domain.DTO
{
    public class DistrictDTO
    {
        public int IdDistrict { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdCantonDistrict { get; set; }
    }
}