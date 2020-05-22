using Newtonsoft.Json;
using SPA_IE.Models.Domain.DTO;
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


        public IEnumerable<NewsDTO> newsList()
        { 
            IEnumerable<NewsDTO> news = null;
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
                        var readTask = result.Content.ReadAsAsync<IList<NewsDTO>>();
                        readTask.Wait();
                        news = readTask.Result;
                    }
                    else
                    {
                        news = Enumerable.Empty<NewsDTO>();
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator");
                    }
                }
                catch
                {
                    throw;
                }
        
            }
            return news;
    }
        public PartialViewResult List()
        {
          
            return PartialView("List", newsList());
        }

        public PartialViewResult Edit(int id)
        {
            NewsDTO newsDTO = null;
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
                        var readTask = result.Content.ReadAsAsync<NewsDTO>();
                        readTask.Wait();
                        newsDTO = readTask.Result;
                    }
                    else
                    {
                        newsDTO = new NewsDTO();
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator");
                    }
                }
                catch (AggregateException agg_ex)
                {
                    var ex = agg_ex.InnerExceptions[0];
                }
            }
            return PartialView("Edit", newsDTO);
        }

        [HttpPost]
        public PartialViewResult Edit(NewsDTO news)
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
            return PartialView("List", newsList());
        }

        public PartialViewResult Create()
        {
            return PartialView("Create");
        }

        [HttpPost]
        public PartialViewResult Create(NewsDTO news)
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
            return PartialView("List", newsList());
        }

       
        public PartialViewResult Delete(int id)
        {
            int apiResult = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/News/");
                try
                {
                    var responseTask = client.DeleteAsync("DeleteNews/" + id);
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
            return PartialView("List", newsList());
        }

       

       
    }
}