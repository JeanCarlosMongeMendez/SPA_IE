using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class UserProfileController : Controller
    {
        // GET: UserProfile
        UserProfileData userProfileData = new UserProfileData();

        public ActionResult Index()
        {

            IEnumerable<UserProfileDTO> userProfiles = userProfileData.ListAllUserProfile();
            return View(userProfiles);
        }
    }
}