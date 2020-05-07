
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
                      IdCanton = cantonItem.idCanton,
                      Name = cantonItem.name,



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
                                          IdCanton = cantonItem.idCanton,
                                          Name = cantonItem.name,
                                      }).Where(x => x.IdCanton == id).Single();


                return cantonToReturn;


            }
        }


    }
}