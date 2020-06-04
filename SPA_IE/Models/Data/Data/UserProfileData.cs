using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class UserProfileData
    {


        public int Delete(string username)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var resultToReturn = context.SPDeleteUserProfile(username);

                return resultToReturn;
            }
        }

    }
}