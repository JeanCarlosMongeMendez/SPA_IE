using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Domain.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        ProfessorData professorData = new ProfessorData();
        ProvinceData provinceData = new ProvinceData();
        CantonData cantonData = new CantonData();
        DistrictData districtData = new DistrictData();
        public ActionResult Index()
        {
            IEnumerable<ProfessorDTO> professors = professorData.ListAllProfessor();
            return View(professors);
        }
        public ActionResult Create()
        {
            var provinces = new SelectList(provinceData.ListAllProvince(), "IdProvince", "Name");
            ViewData["provinces"] = provinces;

            var cantons = new SelectList(cantonData.ListAllCanton(), "IdCanton", "Name");
            ViewData["cantons"] = cantons;
            var districts = new SelectList(districtData.ListAllDistrict(), "IdDistrict", "Name");
            ViewData["districts"] = districts;

            return View();
        }

        [HttpPost]
        public ActionResult Create(ProfessorDTO professor)
        {
            professorData.Add(professor);
           

            return View("Index", professorData.ListAllProfessor().AsEnumerable());
        }
        public ActionResult Edit(int id)
        {

            ProfessorDTO professor = professorData.GetById(id);



            var provinces = new SelectList(provinceData.ListAllProvince(), "IdProvince", "Name");
            ViewData["provinces"] = provinces;

            var cantons = new SelectList(cantonData.ListAllCanton(), "IdCanton", "Name");
            ViewData["cantons"] = cantons;

            var districts = new SelectList(districtData.ListAllDistrict(), "IdDistrict", "Name");
            ViewData["districts"] = districts;

            ViewData["idProvince"] = professor.idProvince;
            ViewData["idCanton"] = professor.idDistrict;
            ViewData["idDistrict"] = professor.idDistrict;

            return View(professor);

        }

        [HttpPost]
        public ActionResult Edit(ProfessorDTO professor)
        {
            professorData.Update(professor);

            return View("Index", professorData.ListAllProfessor().AsEnumerable());
        }
        public ActionResult Delete(int id)
        {
            professorData.Delete(id);
            return View("Index", professorData.ListAllProfessor().AsEnumerable());
        }


    }
}