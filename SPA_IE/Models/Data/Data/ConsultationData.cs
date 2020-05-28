using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class ConsultationData
    {
        public List<SelectConsultation_Result> ListAllSP()
        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SPSelectConsultation().ToList();
                }
            }
            catch
            {
                throw;
            }
        }

 
        public int Add(ConsultationDTO consultation)
        {
            int resultToReturn;
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.SPInsertUpdateConsultation(consultation.IdConsultation, consultation.IdCourse, consultation.Description, consultation.IdTransmitter, consultation.IdReceiver,"Insert");
            }
            }
            catch
            {
                throw;
            }
            return resultToReturn;
        }

        public int Update(ConsultationDTO consultation)
        {
            int resultToReturn;
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.SPInsertUpdateConsultation(consultation.IdConsultation, consultation.IdCourse, consultation.Description, consultation.IdTransmitter, consultation.IdReceiver, "Update");
            }
            }
            catch
            {
                throw;
            }
            return resultToReturn;
        }

        public GetByIdConsultation_Result GetByIdStudentSP(int id)
        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var consulation = context.SPGetByIdConsultation(id).Single();
                return consulation;
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
                var resultToReturn = context.SPDeleteConsultation(id);

                return resultToReturn;
                }
            }
            catch
            {
                throw;
            }
        }

        public ConsultationDTO GetById(int id)
        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var consultationToReturn = (from consultation in context.Consultation
                                       join course in context.Course on consultation.IdCourse equals course.IdCourse
                                       join transmitter in context.UserProfile on consultation.IdTransmitter equals transmitter.IdUserProfile
                                       join receiver in context.UserProfile on consultation.IdReceiver equals receiver.IdUserProfile
                                       select new ConsultationDTO
                                       {
                                           IdConsultation= consultation.IdConsultation,
                                           IdCourse= consultation.IdCourse,
                                           NameCourse= course.Name,
                                           Description= consultation.Description,
                                           IdTransmitter= consultation.IdTransmitter,
                                           NameTransmitter= transmitter.Username,
                                           IdReceiver= consultation.IdReceiver,
                                           NameReceiver= receiver.Username,

                                       }).Where(x => x.IdConsultation == id ).Single();
                return consultationToReturn;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}