﻿using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class ProvinceData
    {
        public List<ProvinceDTO> ListAllProvince()
        {
            List<ProvinceDTO> provinces = null;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                provinces = context.Province
                  .Select(provinceItem => new ProvinceDTO()
                  {
                      IdProvince = provinceItem.idProvince,
                      Name = provinceItem.name,



                  }).ToList<ProvinceDTO>();
            }

            return provinces;

        }


        public ProvinceDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {

                var provinceToReturn = (from provinceItem in context.Province
                                      select new ProvinceDTO
                                      {
                                          IdProvince = provinceItem.idProvince,
                                          Name = provinceItem.name,
                                      }).Where(x => x.IdProvince == id).Single();


                return provinceToReturn;


            }
        }

    }
}