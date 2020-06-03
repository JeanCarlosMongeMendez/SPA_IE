using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA_IE.Models.Data.Data.Tests
{
    [TestClass()]
    public class StudentDataTests
    {
        [TestMethod()]
        public void AddStudentTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                    StudentData studentData = new StudentData();
                    var student = new StudentDTO();

                    //Create UserProfile
                    student.Username = "User Test";
                    student.Password = "123";
                    student.Interests = "Nada";
                    student.Email = "test@mail.com";
                    student.IsAdmin = true;
                    student.IsEnable = true;

                    //Create Student
                    student.IdentificationCard = "B73145";
                    student.isASIP = false;
                    student.isActive = true;

                //Act
                    studentData.Add(student);

                //Assert
                Assert.IsNotNull(student.IdStudent);

            }
        }

        [TestMethod()]
        public void GetByIdStudentTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                StudentData studentData = new StudentData();
                var student = studentData.GetStudentByUsername("Valeria Leiva Quiroz");

                Assert.AreEqual("B63817", student.IdentificationCard);
            }
        }

        [TestMethod()]
        public void GetByNameStudentTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                StudentData studentData = new StudentData();
                var student = studentData.GetStudentByUsername("User Test");

                Assert.AreEqual("B73145", student.IdentificationCard);
            }
        }

        [TestMethod()]
        public void GetTestAndDeleteTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                StudentData studentData = new StudentData();
                var student = new StudentDTO();

                //Act

                //get and delete this course
                student = studentData.GetByUsername("User Test");
                studentData.Delete(student.IdStudent);

                //Assert

                //get deleted course
                try
                {
                    student = studentData.GetByUsername("User Test");
                    Assert.Fail("no exception thrown");
                }
                catch (Exception ex)
                {
                    Assert.IsTrue(ex is Exception);
                }
            }
        }

    }
}