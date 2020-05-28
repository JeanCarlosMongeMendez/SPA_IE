using SPA_IE.Models.Data;
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

        public PartialViewResult GetAll()
        {
            IEnumerable<SelectProfessor_Result> professors = professorData.ListAllSP();
            return PartialView("GetAll", professors);
        }

        public PartialViewResult Create()
        {
            var provinces = new SelectList(provinceData.ListAllProvince(), "IdProvince", "Name");
            ViewBag.provinces = provinces;

            var cantons = new SelectList(cantonData.ListAllCanton(), "IdCanton", "Name");
            ViewBag.cantons = cantons;

            var districts = new SelectList(districtData.ListAllDistrict(), "IdDistrict", "Name");
            ViewBag.districts = districts;

            return PartialView("Create");
        }

        [HttpPost]
        public PartialViewResult Create(ProfessorDTO professor)
        {
            professor.IsEnable = true;
            professorData.Add(professor);
            IEnumerable<SelectProfessor_Result> students = professorData.ListAllSP();
            return PartialView("GetAll", students);
        }

        public PartialViewResult GetById(int id)
        {
            var provinces = new SelectList(provinceData.ListAllProvince(), "IdProvince", "Name");
            ViewBag.provinces = provinces;

            var cantons = new SelectList(cantonData.ListAllCanton(), "IdCanton", "Name");
            ViewBag.cantons = cantons;

            var districts = new SelectList(districtData.ListAllDistrict(), "IdDistrict", "Name");
            ViewBag.districts = districts;
            var professor = professorData.GetById(id);
            return PartialView("GetById", professor);
        }

        public PartialViewResult Edit(int id)
        {
            ProfessorDTO professor = professorData.GetById(id);
            var provinces = new SelectList(provinceData.ListAllProvince(), "IdProvince", "Name");
            ViewData["provinces"] = provinces;

            var cantons = new SelectList(cantonData.ListAllCanton(), "IdCanton", "Name");
            ViewData["cantons"] = cantons;

            var districts = new SelectList(districtData.ListAllDistrict(), "IdDistrict", "Name");
            ViewData["districts"] = districts;

            ViewData["idProvince"] = professor.IdProvince;
            ViewData["idCanton"] = professor.IdDistrict;
            ViewData["idDistrict"] = professor.IdDistrict;
            return PartialView("Edit", professor);
        }

        [HttpPost]
        public PartialViewResult Edit(ProfessorDTO professor)
        {
            try
            {
                professorData.Update(professor);
                IEnumerable<SelectProfessor_Result> professors = professorData.ListAllSP();
                return PartialView("GetAll", professors);
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        public PartialViewResult Delete(int id)
        {
            try
            {
                professorData.Delete(id);
                IEnumerable<SelectProfessor_Result> professors = professorData.ListAllSP();
                return PartialView("GetAll", professors);
            }
            catch
            {
                throw;
            }
        }
    }
}