using SPA_IE.Models.Data;
using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class StudentController : Controller
    {
        private StudentData studentData = new StudentData();
        private ProvinceData provinceData = new ProvinceData();
        private CantonData cantonData = new CantonData();
        private DistrictData districtData = new DistrictData();

        public PartialViewResult GetAll()
        {
            IEnumerable<SelectStudent_Result> students = studentData.ListAllSP();
            return PartialView("GetAll", students);
        }

        public PartialViewResult GetRequest()
        {
            IEnumerable<SelectRequestStudent_Result> students = studentData.ListAllRequestSP();
            return PartialView("GetRequest", students);
        }

        public PartialViewResult AproveRequest(int id)
        {
            studentData.AproveRequest(id);
            IEnumerable<SelectRequestStudent_Result> students = studentData.ListAllRequestSP();
            return PartialView("GetRequest", students);
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
        public PartialViewResult Create(StudentDTO student)
        {
            student.CreationDate = DateTime.Now;
            student.isActive = false;
            student.IsEnable = true;
            studentData.Add(student);
            IEnumerable<SelectRequestStudent_Result> students = studentData.ListAllRequestSP();
            return PartialView("GetRequest", students);
        }

        public PartialViewResult GetById(int id)
        {
            var provinces = new SelectList(provinceData.ListAllProvince(), "IdProvince", "Name");
            ViewBag.provinces = provinces;

            var cantons = new SelectList(cantonData.ListAllCanton(), "IdCanton", "Name");
            ViewBag.cantons = cantons;

            var districts = new SelectList(districtData.ListAllDistrict(), "IdDistrict", "Name");
            ViewBag.districts = districts;
            var student = studentData.GetById(id);
            return PartialView("GetById", student);
        }

        public PartialViewResult Edit(int id)
        {
            StudentDTO student = studentData.GetById(id);
            var provinces = new SelectList(provinceData.ListAllProvince(), "IdProvince", "Name");
            ViewData["provinces"] = provinces;

            var cantons = new SelectList(cantonData.ListAllCanton(), "IdCanton", "Name");
            ViewData["cantons"] = cantons;

            var districts = new SelectList(districtData.ListAllDistrict(), "IdDistrict", "Name");
            ViewData["districts"] = districts;
            
            ViewData["idProvince"] = student.IdProvince;
            ViewData["idCanton"] = student.IdDistrict;
            ViewData["idDistrict"] = student.IdDistrict;
            return PartialView("Edit", student);

        }

        [HttpPost]
        public PartialViewResult Edit(StudentDTO student)
        {
            try
            {
                studentData.Update(student);
                IEnumerable<SelectStudent_Result> students = studentData.ListAllSP();
                return PartialView("GetAll", students);
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
                studentData.Delete(id);
                IEnumerable<SelectRequestStudent_Result> students = studentData.ListAllRequestSP();
                return PartialView("GetRequest", students);
            }
            catch
            {
                throw;
            }
        }
    }
}