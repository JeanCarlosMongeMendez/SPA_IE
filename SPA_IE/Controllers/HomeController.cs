using SPA_IE.Models.Data;
using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Domain.DTO;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Security;
using System.Web.UI.HtmlControls;

namespace SPA_IE.Controllers
{
    public class HomeController : Controller
    {
        private ProvinceData provinceData = new ProvinceData();
        private StudentData studentData = new StudentData();
        UserProfileData userProfileData = new UserProfileData();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetRequest()
        {
            IEnumerable<SelectRequestStudent_Result> students = studentData.ListAllRequestSP();
            ViewBag.requests = students;
            return PartialView("Index");
        }

        [HttpPost]
        public PartialViewResult Login(string username, string password)
        {
            UserProfileDTO userProfileDTO = new UserProfileDTO();
            userProfileDTO.Username = username;
            userProfileDTO.Password = password;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                UserProfileDTO user = userProfileData.GetByLogin(userProfileDTO);
                if (user != null)
                {
                    Session["User"] = user;

                     return PartialView("Login", user);
                }
             
            }
            return PartialView("Index");


        }
    }
}