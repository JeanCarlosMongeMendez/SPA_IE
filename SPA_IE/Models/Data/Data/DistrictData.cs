using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class DistrictData
    {
        public List<DistrictDTO> ListAllDistrict()
        {
            List<DistrictDTO> districts = null;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                districts = context.District
                  .Select(districtItem => new DistrictDTO()
                  {
                      IdDistrict = districtItem.idDistrict,
                      Name = districtItem.name,



                  }).ToList<DistrictDTO>();
            }

            return districts;

        }


        public DistrictDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {

                var districtToReturn = (from districtItem in context.District
                                        select new DistrictDTO
                                        {
                                            IdDistrict = districtItem.idDistrict,
                                            Name = districtItem.name,
                                        }).Where(x => x.IdDistrict == id).Single();


                return districtToReturn;


            }
        }
    }
}