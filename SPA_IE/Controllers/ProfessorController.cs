using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        ProfessorData professorData = new ProfessorData();
        public ActionResult Index()
        {
            IEnumerable<ProfessorDTO> professors = professorData.ListAllProfessor();
            return View(professors);
        }
        public ActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Create(ProfessorDTO professor)
        {
            professorData.Add(professor);

            return View("Index", professorData.ListAllProfessor().AsEnumerable());
        }
        public ActionResult Edit(int id)
        {

            ProfessorDTO professor = professorData.GetById(id);

            return View(professor);
        }

        [HttpPost]
        public ActionResult Edit(ProfessorDTO professor)
        {
            professorData.Update(professor);

            return View("Index", professorData.ListAllProfessor().AsEnumerable());
        }
        public ActionResult Delete(int id)
        {
            professorData.Delete(id);
            return View("Index", professorData.ListAllProfessor().AsEnumerable());
        }


    }
}