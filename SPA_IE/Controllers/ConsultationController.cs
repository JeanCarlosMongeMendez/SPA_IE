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
    public class ConsultationController : Controller
    {
        private ConsultationData consultationData = new ConsultationData();
      

        public PartialViewResult GetAll()
        {
            try
            {
                IEnumerable<SelectConsultation_Result> consultations = consultationData.ListAllSP();
            return PartialView("GetAll", consultations);
            }
            catch
            {
                throw;
            }
        }

       
        public PartialViewResult Create()
        {
            try
            {
                return PartialView("Create");
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        public PartialViewResult Create(ConsultationDTO   consultation)
        {
            try
            {
                consultationData.Add(consultation);
            IEnumerable<SelectConsultation_Result> consultations = consultationData.ListAllSP();
            return PartialView("GetAll", consultations);
            }
            catch
            {
                throw;
            }
        }

        public PartialViewResult Edit(int id)
        {
            try
            {
                ConsultationDTO consultation = consultationData.GetById(id);
           
            return PartialView(consultation);
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        public PartialViewResult Edit(ConsultationDTO consultation)
        {
            try
            {
                consultationData.Update(consultation);
            return PartialView("GetAll", consultationData.ListAllSP().AsEnumerable());
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
                consultationData.Delete(id);
            return PartialView("GetAll", consultationData.ListAllSP().AsEnumerable());
            }
            catch
            {
                throw;
            }
        }
    }
}