using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Model;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorld.WebApplication.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
            BaseUrl = "Home";
        }
        public ActionResult Index()
        {
            var result = new HelloWorldModel();
            var response = Client.GetAsync(BaseUrl).Result;
            if (response.IsSuccessStatusCode)
                result = response.Content.ReadAsAsync<HelloWorldModel>().Result;
            else
                result.DisplayText = response.Content.ReadAsAsync<HttpError>().Result.Message;
            return View(result);
        }
    }
}