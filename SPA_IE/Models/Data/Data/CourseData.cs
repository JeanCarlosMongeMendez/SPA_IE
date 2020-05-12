using System.Collections.Generic;
using System.Linq;

namespace SPA_IE.Models.Data.Data
{
    public class CourseData
    {

        public List<Course> ListAllCourseSP()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SPSelectCourse().ToList();

            }

        }

        public int Add(Course course)
        {
            int resultToReturn;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.SPInsertUpdateCourse(course.IdCourse, course.Name, course.state, course.Semestrer, course.Description,course.Image, "Insert");
            }

            return resultToReturn;

        }

        public int Update(Course course)
        {
            int resultToReturn;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.SPInsertUpdateCourse(course.IdCourse, course.Name, course.state, course.Semestrer, course.Description, course.Image, "Update");
            }

            return resultToReturn;

        }
        public Course GetByIdCourse(int id)
        {

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var course = context.SPGetByIdCourse(id).Single();

                return course;
            }


        }
        public int Delete(int id)
        {

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var resultToReturn = context.SPDeleteCourse(id);

                return resultToReturn;
            }

        }
    }
}
