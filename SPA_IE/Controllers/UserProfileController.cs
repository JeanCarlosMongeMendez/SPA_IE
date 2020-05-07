using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Domain.DTO;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class UserProfileController : Controller
    {
        // GET: UserProfile
        UserProfileData userProfileData = new UserProfileData();

        public ActionResult Index()
        {

          
            return View();
        }
    }
}