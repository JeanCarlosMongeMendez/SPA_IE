using Newtonsoft.Json;
using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class CommentAPIController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }
        public IEnumerable<CommentAPIDTO> commentsList()
        {
            IEnumerable<CommentAPIDTO> comments = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/Comment/");
                try
                {
                    var responseTask = client.GetAsync("GetAllCommentSP");
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<CommentAPIDTO>>();
                        readTask.Wait();
                        comments = readTask.Result;
                    }
                    else
                    {
                        comments = Enumerable.Empty<CommentAPIDTO>();
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator");
                    }
                }
                catch
                {
                    throw;
                }

            }
            return comments;

        }


        public PartialViewResult List()
        {

            return PartialView("List", commentsList());
        }


        public PartialViewResult Edit(int id)
        {
            CommentAPIDTO commentDTO = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/Comment/");
                try
                {
                    var responseTask = client.GetAsync("GetComment/" + id);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<CommentAPIDTO>();
                        readTask.Wait();
                        commentDTO = readTask.Result;
                    }
                    else
                    {
                        commentDTO = new CommentAPIDTO();
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator");
                    }
                }
                catch (AggregateException agg_ex)
                {
                    var ex = agg_ex.InnerExceptions[0];
                }
            }
            return PartialView("Edit", commentDTO);
        }

        [HttpPost]
        public PartialViewResult Edit(CommentAPIDTO comment)
        {
            int apiResult = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/Comment/");
                try
                {
                    var json = JsonConvert.SerializeObject(comment);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var responseTask = client.PutAsync("PutComment", content);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<Int32>();
                        readTask.Wait();
                        apiResult = readTask.Result;
                    }
                }
                catch
                {
                    throw;
                }
            }
            return PartialView("List", commentsList());
        }

        public PartialViewResult Create()
        {

            return PartialView("Create");
        }

        [HttpPost]
        public PartialViewResult Create(CommentAPIDTO comment)
        {
            int apiResult = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/Comment/");
                try
                {
                    var json = JsonConvert.SerializeObject(comment);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var responseTask = client.PostAsync("PostComment", content);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<Int32>();
                        readTask.Wait();
                        apiResult = readTask.Result;
                    }
                }
                catch
                {
                    throw;
                }
            }
            return PartialView("List", commentsList());
        }
        public PartialViewResult Delete(int id)
        {
            int apiResult = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/Comment/");
                try
                {
                    var responseTask = client.DeleteAsync("DeleteComment/" + id);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<Int32>();
                        readTask.Wait();
                        apiResult = readTask.Result;
                    }
                }
                catch
                {
                    throw;
                }
            }
            return PartialView("List", commentsList());
        }
   
    }
}