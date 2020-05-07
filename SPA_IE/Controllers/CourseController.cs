using SPA_IE.Models.Data;
using SPA_IE.Models.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        CourseData courseData = new CourseData();
        public ActionResult Index()
        {
            IEnumerable<Course> courses = courseData.ListAllCourseSP();

            return View(courses);
          
        }
        public ActionResult Create()
        {
       
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            courseData.Add(course);

            return View("Index", courseData.ListAllCourseSP().AsEnumerable());
        }
        public ActionResult Edit(int id)
        {

            Course course = courseData.GetByIdCourse(id);

       

            return View(course);
        }

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            courseData.Update(course);
            return View("Index", courseData.ListAllCourseSP().AsEnumerable());
        }

        public ActionResult Delete(int id)
        {
            courseData.Delete(id);
            return View("Index", courseData.ListAllCourseSP().AsEnumerable());
        }

    }
}