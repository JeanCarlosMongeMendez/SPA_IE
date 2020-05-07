using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Domain.DTO;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    //test
    public class HomeController : Controller
    {
        CantonData cantonData = new CantonData();
        ProvinceData provinceData = new ProvinceData();
        UserProfileData userProfileData = new UserProfileData();



        public ActionResult Index()
        {
            return View();

        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}