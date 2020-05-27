using Microsoft.VisualStudio.TestTools.UnitTesting;

using SPA_IE.Models.Data.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA_IE.Models.Data.Data.Tests
{
    [TestClass()]
    public class CourseDataTests
    {


        [TestMethod()]
        public void AddCourseTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
             //Arrange

                CourseData courseData = new CourseData();
                var course = new Course();

                course.Name = "Lenguajes Test";
                course.Semestrer = "1";
                course.Description = "El curso más importante de la carrera.";
                course.state = true;
                //course.CreationDate = DateTime.Now;

             //Act

                courseData.Add(course);

             //Assert

                Assert.IsNotNull(course.IdCourse);

            }
        }

        [TestMethod()]
        public void GetByNameCourseTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
             //Arrange

                CourseData courseData = new CourseData();
                var course = new Course();
            
             //Act

                //Correct
                course = courseData.GetByNameCourse("Lenguajes Test");

                //Fail
                //course = courseData.GetByNameCourse("Lenguajes");

             //Assert

            Assert.AreEqual("Lenguajes Test", course.Name);
            Assert.AreEqual("1", course.Semestrer);
            Assert.AreEqual("El curso más importante de la carrera.", course.Description);
            }
        }

        [TestMethod()]
        public void GetTestAndDeleteTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
             //Arrange

                CourseData courseData = new CourseData();
                var course = new Course();

             //Act

                //get and delete this course
                course = courseData.GetByNameCourse("Lenguajes Test");
                courseData.Delete(course.IdCourse);

            //Assert

                //get deleted course
                try
                {
                    course = courseData.GetByNameCourse("Lenguajes Test");
                    Assert.Fail("no exception thrown");
                }
                catch (Exception ex)
                {
                    Assert.IsTrue(ex is Exception);
                }
            }
        }

        internal static class MissingDllHack
        {
            // Must reference a type in EntityFramework.SqlServer.dll so that this dll will be
            // included in the output folder of referencing projects without requiring a direct 
            // dependency on Entity Framework. See http://stackoverflow.com/a/22315164/1141360.
            private static System.Data.Entity.SqlServer.SqlProviderServices instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}