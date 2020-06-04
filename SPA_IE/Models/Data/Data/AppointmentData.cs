using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class AppointmentData
    {

        public List<SelectAppointment_Result> ListAllSP()

        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SelectAppointment().ToList();
            }
            }
            catch
            {
                throw;
            }
        }

        public List<SelectAppointment_Result> ListAllRequestSP()
        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SelectAppointment().ToList();
            }
        }
            catch
            {
                throw;
            }
        }


        public int Add(AppoitmentDTO appoitment)
        {
            int resultToReturn;
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.InsertUpdateAppointment(appoitment.IdAppointment, appoitment.IdProfessor, appoitment.IdStudent, appoitment.IdCourse, appoitment.IdSchedule, appoitment.StatusApprovedDisapproved, appoitment.VirtualOn_Site, appoitment.ReasonForAppointment, appoitment.ProfessorResponse, "Insert");
            }
            return resultToReturn;
            }
            catch
            {
                throw;
            }
        }

        public int Update(AppoitmentDTO appoitment)
        {
            int resultToReturn;
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.InsertUpdateAppointment(appoitment.IdAppointment, appoitment.IdProfessor, appoitment.IdStudent, appoitment.IdCourse, appoitment.IdSchedule, appoitment.StatusApprovedDisapproved, appoitment.VirtualOn_Site, appoitment.ReasonForAppointment, appoitment.ProfessorResponse, "Update");
            }
            return resultToReturn;
            }
            catch
            {
                throw;
            }
        }

        public GetByIdAppointment_Result GetByIdAppointmentSP(int id)
        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var appointment = context.GetByIdAppointment(id).Single();
                return appointment;
            }
            }
            catch
            {
                throw;
            }
        }

        public int Delete(int id)
        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var resultToReturn = context.DeleteAppointment(id);

                return resultToReturn;
                }
            }
            catch
            {
                throw;
            }
        }

        public AppoitmentDTO GetById(int id)
        {
            try
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
            catch
            {
                throw;
            }

    
}
    }
}