using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SPA_IE.Models.Data.Data
{
    public class ProfessorData
    {

        public List<SelectProfessor_Result> ListAllSP()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SPSelectProfessor().ToList();
            }

        }

        public int Add(ProfessorDTO professor)
        {
            int resultToReturn;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.SPInsertUpdateProfessor(professor.IdProfessor, professor.Degree, professor.IdUserProfile, professor.CreateBy, DateTime.Now, professor.Username, professor.Password, professor.UserPhoto, professor.Interests, professor.Email, professor.IsAdmin, professor.IsEnable, professor.IdProvince, professor.IdCanton, professor.IdDistrict, "Insert");
            }

            return resultToReturn;

        }

        public int Update(ProfessorDTO professor)
        {
            int resultToReturn;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.SPInsertUpdateProfessor(professor.IdProfessor, professor.Degree, professor.IdUserProfile, professor.CreateBy, DateTime.Now, professor.Username, professor.Password, professor.UserPhoto, professor.Interests, professor.Email, professor.IsAdmin, professor.IsEnable, professor.IdProvince, professor.IdCanton, professor.IdDistrict, "Update");
            }

            return resultToReturn;

        }
        public SelectProfessorById_Result GetByIdProfessorSP(int id)
        {

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var professor= context.SPSelectProfessorById(id).Single();

                return professor;
            }


        }
        public int Delete(int id)
        {

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var resultToReturn = context.SPDeleteStudent(id);

                return resultToReturn;
            }

        }


        public ProfessorDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var professorToReturn = (from professor in context.Professor
                                       join userProfile in context.UserProfile on professor.IdUserProfile equals userProfile.IdUserProfile
                                       join province in context.Province on userProfile.IdProvince equals province.IdProvince
                                       join canton in context.Canton on userProfile.IdCanton equals canton.IdCanton
                                       join district in context.District on userProfile.IdDistrict equals district.IdDistrict
                                       select new ProfessorDTO
                                       {
                                           IdProfessor= professor.IdProfessor,
                                           Degree = professor.Degree,
                                           IdUserProfile = userProfile.IdUserProfile,
                                           CreateBy = professor.CreateBy,
                                           CreationDate = professor.CreationDate,
                                           Username = userProfile.Username,
                                           Password = userProfile.Password,
                                           UserPhoto = userProfile.UserPhoto,
                                           Interests = userProfile.Interests,
                                           Email = userProfile.Email,
                                           IsAdmin = userProfile.IsAdmin,
                                           IsEnable = userProfile.IsEnable,
                                           IdProvince = userProfile.IdProvince,
                                           NameProvince = province.Name,
                                           IdCanton = userProfile.IdCanton,
                                           NameCanton = canton.Name,
                                           IdDistrict = userProfile.IdDistrict,
                                           NameDistrict = district.Name,

                                       }).Where(x => x.IdProfessor == id && x.IsEnable == true).Single();
                return professorToReturn;
            }
        }





        /*public List<ProfessorDTO> ListAllProfessor()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
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
                                      idUserProfile = userProfile.idUserProfile,
                                      creationDate = (DateTime)userProfile.creationDate,




                                  }).ToList();
                return professors;
            }
        }

        public ProfessorDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
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
                                             idUserProfile = userProfile.idUserProfile,
                                             password = userProfile.password,
                                             interests = userProfile.interests,
                                             email = userProfile.email,
                                             nameProvince = province.name,
                                             idCanton = canton.idCanton,
                                             nameCanton = canton.name,
                                             nameDistrict = district.name,



                                         }).Where(x => x.IdProfessor == id).Single();
                return professorToReturn;
            }
        }

        public void Update(ProfessorDTO professorDTO)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var userProfile = context.UserProfile.First<UserProfile>(user => user.idUserProfile.Equals(professorDTO.idUserProfile));
                userProfile.username = professorDTO.username;
                userProfile.password = professorDTO.password;
                userProfile.userPhoto = "photo";
                userProfile.interests = professorDTO.interests;
                userProfile.email = professorDTO.email;
                userProfile.isAdmin = false;
                userProfile.isEnable = true;
                userProfile.idCanton = professorDTO.idCanton;
                userProfile.idProvince = professorDTO.idProvince;
                userProfile.idDistrict = professorDTO.idDistrict;
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
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                UserProfile userProfile = new UserProfile();
                userProfile.username = professorDTO.username;
                userProfile.password = "pass";
                userProfile.userPhoto = null;
                userProfile.interests = null;
                userProfile.email = professorDTO.email;
                userProfile.isAdmin = professorDTO.isAdmin;
                userProfile.isEnable = true;
                userProfile.idCanton = professorDTO.idCanton;
                userProfile.idDistrict = professorDTO.idProvince;
                userProfile.idProvince = professorDTO.idDistrict;
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
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var resultToReturn = context.deleteProfessorSP(id);
                return resultToReturn;
            }
        }*/
    }
}