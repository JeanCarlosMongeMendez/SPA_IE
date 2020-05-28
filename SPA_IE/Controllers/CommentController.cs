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
    public class CommentController : Controller
    {
        // GET: Comment
        CommentData commentData = new CommentData();
        public PartialViewResult GetAll()
        {
            try
            {
                IEnumerable<SelectComment_Result> comments = commentData.ListAllSP();
            return PartialView("GetAll", comments);
            
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
        public PartialViewResult Create(CommentDTO comment)
        {
            try
            {

                commentData.Add(comment);
            return PartialView("GetAll", commentData.ListAllSP().AsEnumerable());
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
                
            CommentDTO comment = commentData.GetById(id);

            return PartialView(comment);
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        public PartialViewResult Edit(CommentDTO comment)
        {
            try
            {
                commentData.Update(comment);
            return PartialView("GetAll", commentData.ListAllSP().AsEnumerable());
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
                commentData.Delete(id);
            return PartialView("GetAll", commentData.ListAllSP().AsEnumerable());
            }
            catch
            {
                throw;
            }
        }
    }
}