using Newtonsoft.Json;
using SPA_IE.Models.Data.Data;
using SPA_IE.Models.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Mvc;

namespace SPA_IE.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            IEnumerable<CommentDTO> news= null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/News/");
                try
                {
                    var responseTask = client.GetAsync("GetAllNewsSP");
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<CommentDTO>>();
                        readTask.Wait();
                        news = readTask.Result;
                    }
                    else
                    {
                        news= Enumerable.Empty<CommentDTO>();
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator");
                    }
                }
                catch
                {
                    throw;
                }
            }
            return Json(news, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id)
        {
            CommentDTO newsDTO = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/News/");
                try
                {
                    var responseTask = client.GetAsync("GetNews/" + id);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<CommentDTO>();
                        readTask.Wait();
                        newsDTO = readTask.Result;
                    }
                    else
                    {
                        newsDTO = new CommentDTO();
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator");
                    }
                }
                catch (AggregateException agg_ex)
                {
                    var ex = agg_ex.InnerExceptions[0];
                }
            }
            return Json(newsDTO, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(int id)
        {
            int apiResult = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/News/");
                try
                {
                    var responseTask = client.GetAsync("DeleteNews/" + id);
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
                client.BaseAddress = new Uri("https://localhost:44357/api/News/");
                try
                {
                    var json = JsonConvert.SerializeObject(news);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var responseTask = client.PostAsync("PostNews", content);
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
                client.BaseAddress = new Uri("https://localhost:44357/api/News/");
                try
                {
                    var json = JsonConvert.SerializeObject(news);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var responseTask = client.PutAsync("PutNews", content);
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