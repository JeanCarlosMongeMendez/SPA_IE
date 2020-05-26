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
        private ConsultationData consultationData = new ConsultationData();;
      

        public PartialViewResult GetAll()
        {
            IEnumerable<SelectConsultation_Result> consultations = consultationData.ListAllSP();
            return PartialView("GetAll", consultations);
        }

       
        public PartialViewResult Create()
        {

            return PartialView("Create");
        }

        [HttpPost]
        public PartialViewResult Create(ConsultationDTO   consultation)
        {
            
            consultationData.Add(consultation);
            IEnumerable<SelectConsultation_Result> consultations = consultationData.ListAllSP();
            return PartialView("GetAll", consultations);
        }

        public ActionResult Edit(int id)
        {
            ConsultationDTO consultation = consultationData.GetById(id);
           
            return View(consultation);
        }

        [HttpPost]
        public ActionResult Edit(ConsultationDTO consultation)
        {
            consultationData.Update(consultation);
            return View("Index", consultationData.ListAllSP().AsEnumerable());
        }

        public ActionResult Delete(int id)
        {
            consultationData.Delete(id);
            return View("Index", consultationData.ListAllSP().AsEnumerable());
        }
    }
}