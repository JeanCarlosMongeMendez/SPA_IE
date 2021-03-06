﻿
using SPA_IE.Models.Data.DTO;
using System.Collections.Generic;
using System.Linq;

namespace SPA_IE.Models.Data.Data
{
    public class CantonData
    {
        public List<CantonDTO> ListAllCanton()
        {
            List<CantonDTO> cantons = null;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                cantons = context.Canton
                  .Select(cantonItem => new CantonDTO()
                  {
                      IdCanton = cantonItem.IdCanton,
                      Name = cantonItem.Name,
                      IdProvinceCanton = cantonItem.IdProvinceCanton,



                  }).ToList<CantonDTO>();
            }

            return cantons;

        }


        public CantonDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {

                var cantonToReturn = (from cantonItem in context.Canton
                                      select new CantonDTO
                                      {
                                          IdCanton = cantonItem.IdCanton,
                                          Name = cantonItem.Name,
                                          IdProvinceCanton = cantonItem.IdProvinceCanton,

                                      }).Where(x => x.IdCanton == id).Single();


                return cantonToReturn;


            }
        }
        public IEnumerable<CantonDTO> GetByIdProvince(int id)
        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
                {

                    var cantonToReturn = (from cantonItem in context.Canton
                                          select new CantonDTO
                                          {
                                              IdCanton = cantonItem.IdCanton,
                                              Name = cantonItem.Name,
                                              IdProvinceCanton = cantonItem.IdProvinceCanton,

                                          }).Where(x => x.IdProvinceCanton == id);


                    return cantonToReturn.ToList();
                }
            }
            catch
            {
                throw;
            }
         }
    }
}