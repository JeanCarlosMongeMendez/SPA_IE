using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Data.DTO;
using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            IEnumerable<ProvinceDTO> userProfiles = provinceData.ListAllProvince();
            return View(userProfiles);
           
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