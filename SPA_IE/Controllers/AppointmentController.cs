using SPA_IE.Models.Data;
using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class AppointmentController : Controller
    {

        AppointmentData appointmentData = new AppointmentData();
        ProfessorData professorData = new ProfessorData();
        StudentData studentData = new StudentData();
        CourseData courseData = new CourseData();
        ScheduleData scheduleData = new ScheduleData();
        AppoitmentDTO appoitmentDTO = new AppoitmentDTO();

        public PartialViewResult GetAll()
        {
            IEnumerable<SelectAppointment_Result> appointments = appointmentData.ListAllSP();
            return PartialView("GetAll", appointments);
        }

        public PartialViewResult GetRequest()
        {
            IEnumerable<SelectAppointment_Result> appointments = appointmentData.ListAllRequestSP();
            return PartialView("GetRequest", appointments);
        }

        public PartialViewResult Create()
        {
            var professors = new SelectList(professorData.ListAllSP(), "IdProfessor", "Username");
            ViewData["professors"] = professors;

            var students = new SelectList(studentData.ListAllSP(), "IdStudent", "Username");
            ViewData["students"] = students;

            var courses = new SelectList(courseData.ListAllCourseSP(), "IdCourse", "Name");
            ViewData["courses"] = courses;

            var scheduleDay = new SelectList(scheduleData.ListAllSP(), "idSchedule", "Day") ;
            ViewData["scheduleDay"] = scheduleDay;

            var scheduleStart = new SelectList(scheduleData.ListAllSP(), "idSchedule", "StartTime");
            ViewData["scheduleStart"] = scheduleStart;

            var scheduleFinal = new SelectList(scheduleData.ListAllSP(), "idSchedule", "FinalTime");
            ViewData["scheduleFinal"] = scheduleFinal;

            return PartialView("Create");
        }

        [HttpPost]
        public PartialViewResult Create(AppoitmentDTO appoitment)
        {
            appointmentData.Add(appoitment);

            IEnumerable<SelectAppointment_Result> appointments = appointmentData.ListAllRequestSP();
            return PartialView("GetRequest", appointments);
        }

        public PartialViewResult Edit(int id)
        {
            AppoitmentDTO appoitment = appointmentData.GetById(id);

            var professors = new SelectList(professorData.ListAllSP(), "IdProfessor", "Username");
            ViewData["professors"] = professors;

            var students = new SelectList(studentData.ListAllSP(), "IdStudent", "Username");
            ViewData["students"] = students;

            var courses = new SelectList(courseData.ListAllCourseSP(), "IdCourse", "Name");
            ViewData["courses"] = courses;

            var scheduleDay = new SelectList(scheduleData.ListAllSP(), "idSchedule", "Day");
            ViewData["scheduleDay"] = scheduleDay;

            var scheduleStart = new SelectList(scheduleData.ListAllSP(), "idSchedule", "StartTime");
            ViewData["scheduleStart"] = scheduleStart;

            var scheduleFinal = new SelectList(scheduleData.ListAllSP(), "idSchedule", "FinalTime");
            ViewData["scheduleFinal"] = scheduleFinal;

            ViewData["IdProfessor"] = appoitment.IdProfessor;
            ViewData["IdStudent"] = appoitment.IdStudent;
            ViewData["IdCourse"] = appoitment.IdCourse;
            ViewData["IdSchedule"] = appoitment.IdSchedule;


            return PartialView("Edit", appoitment);

        }

        [HttpPost]
        public PartialViewResult Edit(AppoitmentDTO appoitment)
        {
            try
            {
                appointmentData.Update(appoitment);
                IEnumerable<SelectAppointment_Result> appoitments = appointmentData.ListAllSP();

                return PartialView("GetAll", appoitments);
            }
            catch
            {
                throw;
            }
        }

        public PartialViewResult Delete(int id)
        {
            try
            {
                appointmentData.Delete(id);
            IEnumerable<SelectAppointment_Result> appoitments = appointmentData.ListAllSP();

            return PartialView("GetRequest", appoitments);

            }
            catch
            {
                throw;
            }
        }

    }
}