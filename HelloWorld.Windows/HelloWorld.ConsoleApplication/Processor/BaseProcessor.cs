using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.ConsoleApplication.Utils;

namespace HelloWorld.ConsoleApplication.Processor
{
    public abstract class BaseProcessor
    {
        public string BaseUrl { get; set; }

        public HttpClient Client
        {
            get { return ApiClient.GetClient(); }
        }
    }
}
