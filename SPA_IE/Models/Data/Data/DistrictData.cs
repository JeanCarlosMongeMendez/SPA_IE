using SPA_IE.Models.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace SPA_IE.Models.Data.Data
{
    public class DistrictData
    {
        public List<DistrictDTO> ListAllDistrict()
        {
            List<DistrictDTO> districts = null;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                districts = context.District
                  .Select(districtItem => new DistrictDTO()
                  {
                      IdDistrict = districtItem.IdDistrict,
                      Name = districtItem.Name,
                      IdCantonDistrict= districtItem.IdCantonDistrict,


                  }).ToList<DistrictDTO>();
            }

            return districts;

        }


        public DistrictDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {

                var districtToReturn = (from districtItem in context.District
                                        select new DistrictDTO
                                        {
                                            IdDistrict = districtItem.IdDistrict,
                                            Name = districtItem.Name,
                                            IdCantonDistrict = districtItem.IdCantonDistrict,
                                        }).Where(x => x.IdDistrict == id).Single();


                return districtToReturn;


            }
        }
        public DistrictDTO GetByIdCanton(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {

                var districtToReturn = (from districtItem in context.District
                                        select new DistrictDTO
                                        {
                                            IdDistrict = districtItem.IdDistrict,
                                            Name = districtItem.Name,
                                            IdCantonDistrict = districtItem.IdCantonDistrict,
                                        }).Where(x => x.IdCantonDistrict == id).Single();


                return districtToReturn;


            }
        }
    }
}