using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class AppointmentData
    {

        //public List<SelectAppointment_Result> ListAllSP()
        //{
        //    using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
        //    {
        //        return context.SPSelectAppointment().ToList();
        //    }
        //}

        //public List<SelectRequestAppointment_Result> ListAllRequestSP()
        //{
        //    using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
        //    {
        //        return context.SelectRequestAppointment().ToList();
        //    }
        //}


        //public int Add(AppoitmentDTO appoitment)
        //{
        //    int resultToReturn;
        //    using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
        //    {
        //        resultToReturn = context.SPInsertUpdateAppointment(appoitment.IdAppointMent, appoitment.Professor, appoitment.Student, appoitment.Course, appoitment.Schedule, appoitment.statusApprovedDisapproved, appoitment.virtualOn_Site, appoitment.reasonForAppointment, appoitment.professorResponse,  "Insert");
        //    }
        //    return resultToReturn;
        //}

        //public int Update(AppoitmentDTO appoitment)
        //{
        //    int resultToReturn;
        //    using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
        //    {
        //        resultToReturn = context.SPInsertUpdateAppointment(appoitment.IdAppointMent, appoitment.Professor, appoitment.Student, appoitment.Course, appoitment.Schedule, appoitment.statusApprovedDisapproved, appoitment.virtualOn_Site, appoitment.reasonForAppointment, appoitment.professorResponse, "Update");
        //    }
        //    return resultToReturn;
        //}

        //public SelectStudentById_Result GetByIdAppointmentSP(int id)
        //{
        //    using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
        //    {
        //        var appointment = context.SPSelectAppointmentById(id).Single();
        //        return appointment;
        //    }
        //}

        //public int Delete(int id)
        //{
        //    using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
        //    {
        //        var resultToReturn = context.SPDeleteAppointment(id);

        //        return resultToReturn;
        //    }
        //}

        //public AppoitmentDTO GetById(int id)
        //{
        //    using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
        //    {
        //        var appointmentToReturn = (from Appointment in context.Appointment
                    
                    
                    
                    
                    
                    
        //            from student in context.Student
        //                               join userProfile in context.UserProfile on student.IdUserProfile equals userProfile.IdUserProfile
        //                               join province in context.Province on userProfile.IdProvince equals province.IdProvince
        //                               join canton in context.Canton on userProfile.IdCanton equals canton.IdCanton
        //                               join district in context.District on userProfile.IdDistrict equals district.IdDistrict
        //                               select new StudentDTO
        //                               {
        //                                   IdStudent = student.IdStudent,
        //                                   IdentificationCard = student.IdentificationCard,
        //                                   IdUserProfile = userProfile.IdUserProfile,
        //                                   isASIP = student.IsASIP,
        //                                   isActive = student.IsActive,
        //                                   CreateBy = student.CreateBy,
        //                                   CreationDate = student.CreationDate,
        //                                   Username = userProfile.Username,
        //                                   Password = userProfile.Password,
        //                                   UserPhoto = userProfile.UserPhoto,
        //                                   Interests = userProfile.Interests,
        //                                   Email = userProfile.Email,
        //                                   IsAdmin = userProfile.IsAdmin,
        //                                   IsEnable = userProfile.IsEnable,
        //                                   IdProvince = userProfile.IdProvince,
        //                                   NameProvince = province.Name,
        //                                   IdCanton = userProfile.IdCanton,
        //                                   NameCanton = canton.Name,
        //                                   IdDistrict = userProfile.IdDistrict,
        //                                   NameDistrict = district.Name,

        //                               }).Where(x => x.IdStudent == id && x.IsEnable == true && x.isActive == true).Single();
        //        return appointmentToReturn;
        //    }
        //}

    }
}