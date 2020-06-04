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
    public class AppointmentDataTests
    {
        [TestMethod()]
        public void AddAppointmentTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {

                //Arrange
                AppointmentData appointmentData = new AppointmentData();
                var appoitment = new AppoitmentDTO();

                //Create appoitment
                appoitment.ReasonForAppointment = "Reason Appointment to test";
                appoitment.ProfessorResponse = true;
                appoitment.VirtualOn_Site = true;
                appoitment.StatusApprovedDisapproved = true;

                appoitment.IdCourse = 1;
                appoitment.IdProfessor = 1;
                appoitment.IdSchedule = 8;
                appoitment.IdStudent = 1; 


                //Act
                appointmentData.Add(appoitment);


                //Assert
                Assert.IsNotNull(appoitment.IdAppointment);
            }
        }

        [TestMethod()]
        public void GetByIdAppointmentTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                AppointmentData appointmentData = new AppointmentData();

                //Act
                var appointment = appointmentData.GetAppointmentByReasonSP("Reason Appointment to test");
                var appointmenteById = appointmentData.GetByIdAppointmentSP(appointment.IdAppointment);

                //Assert
                Assert.AreEqual("Reason Appointment to test", appointmenteById.ReasonForAppointment);
            }
        }

        [TestMethod()]
        public void GetTestAndDeleteTest()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                //Arrange
                AppointmentData appointmentData = new AppointmentData();

                //Act

                //get and delete this course
                var appointment = appointmentData.GetAppointmentByReasonSP("Reason Appointment to test");
                appointmentData.Delete(appointment.IdAppointment);

                //Assert
                //get deleted course
                try
                {
                    var appointmentGet = appointmentData.GetAppointmentByReasonSP("Reason Appointment to test");
                    Assert.Fail("no exception thrown");
                }
                catch (Exception ex)
                {
                    Assert.IsTrue(ex is Exception);
                }
            }
        }

        //[TestMethod()]
        //public void zDeleteAllTest()
        //{
        //    using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
        //    {
        //        //Arrange
        //        ProfessorData professorData = new ProfessorData();
        //        UserProfileData userProfileData = new UserProfileData();

        //        //Act
        //        var professor = professorData.GetProfessorByUsername("User Appointment");
        //        professorData.Delete(Convert.ToInt32(professor.IdUserProfile));
        //        userProfileData.Delete("User Appointment");

        //        //Assert
        //        Assert.IsTrue(true);
        //    }
        //}
    }
}