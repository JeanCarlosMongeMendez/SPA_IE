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
                UserProfileData userProfileData = new UserProfileData();
                var student = new StudentDTO();

                try
                {
                    userProfileData.Delete("User Test");
                    Assert.Fail("no exception thrown");
                }
                catch (Exception ex)
                {
                    Assert.IsTrue(ex is Exception);
                }

                //Create UserProfile
                student.Username = "User Test";
                student.Password = "123";
                student.Interests = "Nada";
                student.Email = "test@mail.com";
                student.IdDistrict = 1;
                student.IdCanton = 1;
                student.IdProvince = 1;
                student.IsAdmin = false;
                student.IsEnable = true;

                //Create Student
                student.IdentificationCard = "B00000";
                student.isASIP = false;
                student.isActive = true;

                //Act
                studentData.Add(student);

                //Assert
                Assert.IsNotNull(student.IdStudent);

            }
        }

        [TestMethod()]
        public void GetByNameStudentTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                StudentData studentData = new StudentData();

                //Act
                var student = studentData.GetStudentByUsername("User Test");
                var studentById = studentData.GetByIdStudentSP(Convert.ToInt32(student.IdUserProfile)); 

                //Assert
                Assert.AreEqual("B00000", studentById.IdentificationCard);
            }
        }

        [TestMethod()]
        public void GetTestAndDeleteTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                StudentData studentData = new StudentData();

                //Act

                //get and delete this course
                var student = studentData.GetByUsername("User Test");
                studentData.Delete(student.IdUserProfile);

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

        [TestMethod()]
        public void zDeleteAllTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                UserProfileData userProfileData = new UserProfileData();

                //Act
                userProfileData.Delete("User Test");

                //Assert
                Assert.IsTrue(true);
            }
        }

    }
}