
using SPA_IE.Models.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class CantonData
    {
        public List<CantonDTO> ListAllCanton()
        {
            List<CantonDTO> cantons = null;
           
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
                {
                    cantons = context.Canton
                      .Select(cantonItem => new CantonDTO()
                      {
                          idCanton = cantonItem.idCanton,
                          name = cantonItem.name,



                      }).ToList<CantonDTO>();
                }
            
            return cantons;

        }


        public CantonDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {

                var cantonToReturn = (from cantonItem in context.Canton
                                       select new CantonDTO
                                       {
                                          idCanton = cantonItem.idCanton,
                                          name = cantonItem.name,
                                       }).Where(x => x.idCanton == id).Single();


                return cantonToReturn;


            }
        }


    }
}