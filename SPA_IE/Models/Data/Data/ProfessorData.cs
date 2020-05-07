using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
                                  join userProfile in context.UserProfile on professor.idUserProfile equals userProfile.idUserProfile
                                  join province in context.Province on userProfile.idProvince equals province.idProvince
                                  join canton in context.Canton on userProfile.idCanton equals canton.idCanton
                                  join district in context.District on userProfile.idDistrict equals district.idDistrict
                                  select new ProfessorDTO
                                  {
                                      IdProfessor = professor.idProfessor,
                                      Degree = professor.degree,
                                      username = userProfile.username,
                                      idUserProfile = userProfile.idUserProfile
                                  }).ToList();
                return professors;
            }
        }

        public ProfessorDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                var professorToReturn = (from professor in context.Professor
                                         join userProfile in context.UserProfile on professor.idUserProfile equals userProfile.idUserProfile
                                         join province in context.Province on userProfile.idProvince equals province.idProvince
                                         join canton in context.Canton on userProfile.idCanton equals canton.idCanton
                                         join district in context.District on userProfile.idDistrict equals district.idDistrict
                                         select new ProfessorDTO
                                         {
                                             IdProfessor = professor.idProfessor,
                                             Degree = professor.degree,
                                             username = userProfile.username,
                                             idUserProfile = userProfile.idUserProfile
                                         }).Where(x => x.IdProfessor == id).Single();
                return professorToReturn;
            }
        }

        public void Update(ProfessorDTO professorDTO)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                var userProfile = context.UserProfile.First<UserProfile>(user => user.idUserProfile.Equals(professorDTO.idUserProfile));
                userProfile.username = professorDTO.username;
                userProfile.password = "pass";
                userProfile.userPhoto = "photo";
                userProfile.interests = "Games";
                userProfile.email = "@";
                userProfile.isAdmin = false;
                userProfile.isEnable = true;
                userProfile.idCanton = 1;
                userProfile.idDistrict = 1;
                userProfile.idProvince = 1;
                userProfile.creationDate = DateTime.Now;
                userProfile.createBy = null;
                context.SaveChanges();
                var professor = context.Professor.First<Professor>(prof => prof.idProfessor.Equals(professorDTO.IdProfessor));
                professor.idUserProfile = userProfile.idUserProfile;
                professor.degree = professorDTO.Degree;
                context.SaveChanges();
            }
        }

        public void Add(ProfessorDTO professorDTO)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                UserProfile userProfile = new UserProfile();
                userProfile.username = professorDTO.username;
                userProfile.password = "pass";
                userProfile.userPhoto = "photo";
                userProfile.interests = "Games";
                userProfile.email = "@";
                userProfile.isAdmin = false;
                userProfile.isEnable = true;
                userProfile.idCanton = 1;
                userProfile.idDistrict = 1;
                userProfile.idProvince = 1;
                userProfile.creationDate = DateTime.Now;
                userProfile.createBy = null;
                context.UserProfile.Add(userProfile);
                context.SaveChanges();
                Professor professor = new Professor();
                professor.idUserProfile = userProfile.idUserProfile;
                professor.degree = professorDTO.Degree;
                context.Professor.Add(professor);
                context.SaveChanges();
            }
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