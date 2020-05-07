using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class CourseData
    {

        public List<Course> ListAllCourseSP()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                return context.SelectCourseSP().ToList();

            }

        }

        public int Add(Course course)
        {
            int resultToReturn;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                resultToReturn = context.InsertUpdateCourseSP(course.idCourse,course.name,course.state,course.semestrer, course.description, "Insert");
            }

            return resultToReturn;

        }

        public int Update(Course course)
        {
            int resultToReturn;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                resultToReturn = context.InsertUpdateCourseSP(course.idCourse, course.name, course.state, course.semestrer, course.description,"Update");
            }

            return resultToReturn;

        }
        public Course GetByIdCourse(int id)
        {

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                var course = context.GetByIdCourseSP(id).Single();

                return course;
            }


        }
        public int Delete(int id)
        {

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                var resultToReturn = context.deleteCourseSP(id);

                return resultToReturn;
            }

        }
    }
}
