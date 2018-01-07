using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using HelloWorld.WebApplication.Utils;

namespace HelloWorld.WebApplication.Controllers
{
    public class BaseController : Controller
    {
        public string BaseUrl { get; set; }

        public HttpClient Client
        {
            get
            {
                return ApiClient.GetClient();
            }
        }
    }




}