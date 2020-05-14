using Newtonsoft.Json;
using SPA_IE.Models.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            IEnumerable<CommentDTO> comments = null;
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
                        var readTask = result.Content.ReadAsAsync<IList<CommentDTO>>();
                        readTask.Wait();
                        comments = readTask.Result;
                    }
                    else
                    {
                        comments = Enumerable.Empty<CommentDTO>();
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator");
                    }
                }
                catch
                {
                    throw;
                }
            }
            return Json(comments, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id)
        {
            CommentDTO commentDTO = null;
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
                        var readTask = result.Content.ReadAsAsync<CommentDTO>();
                        readTask.Wait();
                        commentDTO = readTask.Result;
                    }
                    else
                    {
                        commentDTO = new CommentDTO();
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator");
                    }
                }
                catch (AggregateException agg_ex)
                {
                    var ex = agg_ex.InnerExceptions[0];
                }
            }
            return Json(commentDTO, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(int id)
        {
            int apiResult = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/Comment/");
                try
                {
                    var responseTask = client.GetAsync("DeleteComment/" + id);
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
            return Json(apiResult, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Add(CommentDTO news)
        {
            int apiResult = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/Comment/");
                try
                {
                    var json = JsonConvert.SerializeObject(news);
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
            return Json(apiResult, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update(CommentDTO news)
        {
            int apiResult = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/Comment/");
                try
                {
                    var json = JsonConvert.SerializeObject(news);
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
            return Json(apiResult, JsonRequestBehavior.AllowGet);
        }
    }
}