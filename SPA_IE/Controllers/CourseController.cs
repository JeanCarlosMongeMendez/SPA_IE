using SPA_IE.Models.Data;
using SPA_IE.Models.Data.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        CourseData courseData = new CourseData();
        public PartialViewResult Index()
        {
            IEnumerable<Course> courses = courseData.ListAllCourseSP();

            return PartialView(courses);

        }
        public PartialViewResult Create()
        {

            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Create(Course course)
        {
            courseData.Add(course);

            return PartialView("Index", courseData.ListAllCourseSP().AsEnumerable());
        }
        public PartialViewResult Edit(int id)
        {

            Course course = courseData.GetByIdCourse(id);



            return PartialView(course);
        }

        [HttpPost]
        public PartialViewResult Edit(Course course)
        {
            courseData.Update(course);
            return PartialView("Index", courseData.ListAllCourseSP().AsEnumerable());
        }

        public ActionResult Delete(int id)
        {
            courseData.Delete(id);
            return PartialView("Index", courseData.ListAllCourseSP().AsEnumerable());
        }

    }
}