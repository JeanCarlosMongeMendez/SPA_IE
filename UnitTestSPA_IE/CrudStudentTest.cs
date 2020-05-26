using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Data.DTO;
using SPA_IE.Controllers;
using System.Web.Mvc;

namespace UnitTestSPA_IE
{
    /// <summary>
    /// Descripción resumida de CrudStudent
    /// </summary>
    [TestClass]
    public class CrudStudentTest
    {
        [TestMethod]
        public void InsertStudentCorrectly()
        {
            //Arrange
            StudentController studentController = new StudentController();
            StudentDTO student = new StudentDTO();
            
            student.IdentificationCard = "B79038-TestStudent";
            student.isASIP = false;
            student.isActive = true;

            //Act
            ActionResult result = studentController.Create(student) as ActionResult;


            //Assert
            Assert.IsNotNull(result);

        }
    }
}
