using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace HelloWorld.WebApplication.Utils
{
    public class ApiClient
    {
        public static HttpClient GetClient()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddressUri"])
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Date = DateTime.UtcNow;
            return client;
        }
    }
}