using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA_IE.Models.Data.Data.Tests
{
    [TestClass()]
    public class ProfessorDataTests
    {
        [TestMethod()]
        public void AddProfessorTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                ProfessorData professorData = new ProfessorData();
                UserProfileData userProfileData = new UserProfileData();
                var professor = new ProfessorDTO();

                try
                {
                    userProfileData.Delete("User Test Prof");
                    Assert.Fail("no exception thrown");
                }
                catch (Exception ex)
                {
                    Assert.IsTrue(ex is Exception);
                }

                //Create UserProfile
                professor.Username = "User Test Prof";
                professor.Password = "123";
                professor.Interests = "Nada";
                professor.Email = "test@mail.com";
                professor.IdDistrict = 1;
                professor.IdCanton = 1;
                professor.IdProvince = 1;
                professor.IsAdmin = false;
                professor.IsEnable = true;

                //Create Professor
                professor.Degree = "Bach in test";

                //Act
                professorData.Add(professor);

                //Assert
                Assert.IsNotNull(professor.IdProfessor);

            }
        }

        [TestMethod()]
        public void GetByIdProfessorTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                ProfessorData professorData = new ProfessorData();

                //Act
                var professor = professorData.GetProfessorByUsername("User Test Prof");
                var professorById = professorData.GetByIdProfessorSP(Convert.ToInt32(professor.IdUserProfile));

                //Assert
                Assert.AreEqual("Bach in test", professorById.Degree);
            }
        }


        [TestMethod()]
        public void GetTestAndDeleteTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                ProfessorData professorData = new ProfessorData();

                //Act

                //get and delete this course
                var professor = professorData.GetProfessorByUsername("User Test Prof");
                professorData.Delete(Convert.ToInt32(professor.IdUserProfile));           

                //Assert
                //get deleted course
                try
                {
                    var professorGet = professorData.GetProfessorByUsername("User Test Prof");
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
                userProfileData.Delete("User Test Prof");

                //Assert
                Assert.IsTrue(true);
            }
        }

    }
}