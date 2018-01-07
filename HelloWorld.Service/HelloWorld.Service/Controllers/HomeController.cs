using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.Model;

namespace HelloWorld.Service.Controllers
{
    public class HomeController : ApiController
    {
        private string _resultText = "Hello World!!";

        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new HelloWorldModel() { DisplayText = _resultText } );
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
