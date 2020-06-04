using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class UserProfileData
    {
        public UserProfileDTO GetByLogin(UserProfileDTO user)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
              var userProfileToReturn = (from userProfile in context.UserProfile
                                       join province in context.Province on userProfile.IdProvince equals province.IdProvince
                                       join canton in context.Canton on userProfile.IdCanton equals canton.IdCanton
                                       join district in context.District on userProfile.IdDistrict equals district.IdDistrict
                                       select new UserProfileDTO
                                       {
                                          
                                           IdUserProfile = userProfile.IdUserProfile,
                                           CreateBy = userProfile.CreateBy,
                                           CreationDate = userProfile.CreationDate,
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

                                       }).Where(x => x.Password == user.Password && x.IsEnable == true && x.Username == user.Username).Single();
                return userProfileToReturn;
            }
        }
    }
}