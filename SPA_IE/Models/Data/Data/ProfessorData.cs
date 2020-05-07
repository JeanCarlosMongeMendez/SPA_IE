using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class ProfessorData
    {
        public List<ProfessorDTO> ListAllProfessor()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {

                var professors = (from professor in context.Professor
                                select new ProfessorDTO
                                {
                                   IdProfessor= professor.idProfessor,
                                   Degree= professor.degree,
                                }).ToList();


                return professors;


            }
        }

         
             public ProfessorDTO GetById( int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {


               var professorToReturn = (from professor in context.Professor
                                  select new ProfessorDTO
                                  {
                                      IdProfessor = professor.idProfessor,
                                      Degree = professor.degree,
                                  }).Where(x => x.IdProfessor == id).Single();


                return professorToReturn;


            }
        }

        public int Update(ProfessorDTO professorDTO)
        {
            int resultToReturn;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                resultToReturn = context.InsertUpdateProfessor(professorDTO.IdProfessor, professorDTO.Degree, "Update");
            }

            return resultToReturn;
        }

        public int Add(ProfessorDTO professorDTO)
        {
            int resultToReturn;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                resultToReturn = context.InsertUpdateProfessor(professorDTO.IdProfessor, professorDTO.Degree, "Insert");
            }
            
            return resultToReturn;

        }

        public int Delete(int id)
        {

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                var resultToReturn = context.deleteProfessorSP(id);

                return resultToReturn;
            }

        }



    }
}