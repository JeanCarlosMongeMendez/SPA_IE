using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        StudentData studentData = new StudentData();
        public ActionResult Index()
        {
            IEnumerable<StudentDTO> students = studentData.ListAllStudents();
            return View(students);
        }
        public ActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentDTO student)
        {
            studentData.Add(student);

            return View("Index", studentData.ListAllStudents().AsEnumerable());
        }
        public ActionResult Edit(int id)
        {

            StudentDTO student= studentData.GetById(id);

            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(StudentDTO student)
        {
            studentData.Update(student);

            return View("Index", studentData.ListAllStudents().AsEnumerable());
        }
        public ActionResult Delete(int id)
        {
            studentData.Delete(id);
            return View("Index", studentData.ListAllStudents().AsEnumerable());
        }

    }
}