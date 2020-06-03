using SPA_IE.Models.Data;
using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Data.DTO;
using SPA_IE.Models.Domain.DTO;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.UI.HtmlControls;

namespace SPA_IE.Controllers
{
    public class HomeController : Controller
    {
        private ProvinceData provinceData = new ProvinceData();
        private StudentData studentData = new StudentData();
        private CantonData cantonData = new CantonData();

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

        public JsonResult GetCantonsByProvince(int id)
        {
            try
            {
                return Json(cantonData.GetByIdProvince(id), JsonRequestBehavior.AllowGet);
            }
            catch
            {
                throw;
            }
        }
    }
}