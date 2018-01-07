using System.Net.Http;
using System.Web.Http;
using HelloWorld.Model;

namespace HelloWorld.ConsoleApplication.Processor
{
    public class HelloWorldProcessor : BaseProcessor
    {
        
        public HelloWorldProcessor()
        {
            BaseUrl = "Home";
        }

        public string Process()
        {
            var response = Client.GetAsync(BaseUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<HelloWorldModel>().Result;
                // Send results
                return result.DisplayText;
            }
            return response.Content.ReadAsAsync<HttpError>().Result.Message;
        }
    }
}
