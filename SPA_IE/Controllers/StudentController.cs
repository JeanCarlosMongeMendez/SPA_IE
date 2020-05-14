﻿using SPA_IE.Models.Data;
using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Data.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        StudentData studentData = new StudentData();
        ProvinceData provinceData = new ProvinceData();
        CantonData cantonData = new CantonData();
        DistrictData districtData = new DistrictData();
        public ActionResult Index()
        {
            IEnumerable<SelectStudent_Result> students = studentData.ListAllSP();
            return View(students);
        }
        public ActionResult Create()
        {
            var provinces = new SelectList(provinceData.ListAllProvince(), "IdProvince", "Name");
            ViewData["provinces"] = provinces;

            var cantons = new SelectList(cantonData.ListAllCanton(), "IdCanton", "Name");
            ViewData["cantons"] = provinces;

            var districts = new SelectList(districtData.ListAllDistrict(), "IdDistrict", "Name");
            ViewData["districts"] = districts;

            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentDTO student)
        {
            studentData.Add(student);


            return View("Index",studentData.ListAllSP().AsEnumerable());
        }
        public ActionResult Edit(int id)
        {

            StudentDTO student = studentData.GetById(id);



            var provinces = new SelectList(provinceData.ListAllProvince(), "IdProvince", "Name");
            ViewData["provinces"] = provinces;

            var cantons = new SelectList(cantonData.ListAllCanton(), "IdCanton", "Name");
            ViewData["cantons"] = cantons;

            var districts = new SelectList(districtData.ListAllDistrict(), "IdDistrict", "Name");
            ViewData["districts"] = districts;

            ViewData["IdProvince"] = student.IdProvince;
            ViewData["IdCanton"] = student.IdDistrict;
            ViewData["IdDistrict"] = student.IdDistrict;

            return View(student);

        }

        [HttpPost]
        public ActionResult Edit(StudentDTO student)
        {
            studentData.Update(student);

            return View("Index", studentData.ListAllSP().AsEnumerable());
        }
        public ActionResult Delete(int id)
        {
            studentData.Delete(id);
            return View("Index", studentData.ListAllSP().AsEnumerable());
        }
    }
}