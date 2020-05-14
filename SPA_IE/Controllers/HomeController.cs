using SPA_IE.Models.Data;
using SPA_IE.Models.Data.Data;
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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetStudents()
        {
            IEnumerable<SelectStudent_Result> students = studentData.ListAllSP();
            return View(students);
        }
    }
}