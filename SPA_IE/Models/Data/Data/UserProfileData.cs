using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class UserProfileData
    {
        public List<UserProfileDTO> ListAllUserProfile()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {

                var userProfiles = (from userProfile in context.UserProfile
                                    join province in context.Province on userProfile.idProvince equals province.idProvince
                                    join canton in context.Canton on userProfile.idCanton equals canton.idCanton
                                    join district in context.District on userProfile.idDistrict equals district.idDistrict
                                    join creatorBy in context.UserProfile on userProfile.idUserProfile equals creatorBy.createBy
                                    select new UserProfileDTO
                                    {
                                        idUserProfile = userProfile.idUserProfile,
                                        username = userProfile.username,
                                        password = userProfile.password,
                                        userPhoto = userProfile.userPhoto,
                                        interests = userProfile.interests,
                                        email= userProfile.email,
                                        isAdmin= userProfile.isAdmin,
                                        isEnable= userProfile.isEnable,
                                        idProvince= province.idProvince,
                                        nameProvince= province.name,
                                        idCanton= canton.idCanton,
                                        nameCanton= canton.name,
                                        idDistrict= district.idDistrict,
                                        nameDistrict=district.name,
                                        usernameCreator= creatorBy.username,
                                        creationDate = (DateTime)userProfile.creationDate,
                                      }).ToList();
                return userProfiles;


            }
        }


        public UserProfileDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {

                var studentToReturn = (from userProfile in context.UserProfile
                                       join province in context.Province on userProfile.idProvince equals province.idProvince
                                       join canton in context.Canton on userProfile.idCanton equals canton.idCanton
                                       join district in context.District on userProfile.idDistrict equals district.idDistrict
                                       join creatorBy in context.UserProfile on userProfile.idUserProfile equals creatorBy.createBy
                                       select new UserProfileDTO
                                       {
                                           idUserProfile = userProfile.idUserProfile,
                                           username = userProfile.username,
                                           password = userProfile.password,
                                           userPhoto = userProfile.userPhoto,
                                           interests = userProfile.interests,
                                           email = userProfile.email,
                                           isAdmin = userProfile.isAdmin,
                                           isEnable = userProfile.isEnable,
                                           idProvince = province.idProvince,
                                           nameProvince = province.name,
                                           idCanton = canton.idCanton,
                                           nameCanton = canton.name,
                                           idDistrict = district.idDistrict,
                                           nameDistrict = district.name,
                                           usernameCreator = creatorBy.username,
                                           creationDate = (DateTime)userProfile.creationDate,


                                       }).Where(x => x.idUserProfile== id).Single();


                return studentToReturn;


            }
        }














    }
}