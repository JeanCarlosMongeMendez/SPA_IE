using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class AppointmentData
    {

        public List<SelectAppointment_Result> ListAllSP()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SelectAppointment().ToList();
            }
        }

        public List<SelectAppointment_Result> ListAllRequestSP()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SelectAppointment().ToList();
            }
        }


        public int Add(AppoitmentDTO appoitment)
        {
            int resultToReturn;
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.InsertUpdateAppointment(appoitment.IdAppointment, appoitment.IdProfessor, appoitment.IdStudent, appoitment.IdCourse, appoitment.IdSchedule, appoitment.StatusApprovedDisapproved, appoitment.VirtualOn_Site, appoitment.ReasonForAppointment, appoitment.ProfessorResponse, "Insert");
            }
            return resultToReturn;
        }

        public int Update(AppoitmentDTO appoitment)
        {
            int resultToReturn;
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.InsertUpdateAppointment(appoitment.IdAppointment, appoitment.IdProfessor, appoitment.IdStudent, appoitment.IdCourse, appoitment.IdSchedule, appoitment.StatusApprovedDisapproved, appoitment.VirtualOn_Site, appoitment.ReasonForAppointment, appoitment.ProfessorResponse, "Update");
            }
            return resultToReturn;
        }

        public GetByIdAppointment_Result GetByIdAppointmentSP(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var appointment = context.GetByIdAppointment(id).Single();
                return appointment;
            }
        }

        public int Delete(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var resultToReturn = context.DeleteAppointment(id);

                return resultToReturn;
            }
        }

        public AppoitmentDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var appointmentToReturn = (from appointment in context.Appointment
                                           join professor in context.Professor on appointment.IdProfessor equals professor.IdProfessor
                                           join student in context.Student on appointment.IdStudent equals student.IdStudent
                                           join course in context.Course on appointment.IdCourse equals course.IdCourse
                                           join schedule in context.Schedule on appointment.IdSchedule equals schedule.idSchedule

                                           select new AppoitmentDTO
                                           {
                                               IdAppointment = appointment.IdAppointment,
                                               IdProfessor = professor.IdProfessor,
                                               IdStudent = student.IdStudent,
                                               IdCourse = course.IdCourse,
                                               IdSchedule = schedule.idSchedule,
                                               StatusApprovedDisapproved = appointment.StatusApprovedDisapproved,
                                               VirtualOn_Site = appointment.VirtualOn_Site,
                                               ReasonForAppointment = appointment.ReasonForAppointment,
                                               ProfessorResponse = appointment.ProfessorResponse,

                                           }).Where(x => x.IdAppointment == id).Single();
                                                        return appointmentToReturn;
            }
        }

        public GetAppointmentByReason_Result GetAppointmentByReasonSP(string reason)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var appointment = context.GetAppointmentByReason(reason).Single();
                return appointment;
            }
        }

    }
}