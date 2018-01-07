using System;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.Model;
using HelloWorld.Service.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Service.Tests
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void GetResponseTest()
        {
            // Arrange
            var controller = new HomeController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            
            // Act 
            var response = controller.Get();
            
            // Assert - Got successful results from API
            Assert.IsTrue(response.IsSuccessStatusCode, "Home API was not found or there was an issue with the process");
            
            // Assert - Got display text from the API
            Assert.IsTrue(!string.IsNullOrEmpty(response.Content.ReadAsAsync<HelloWorldModel>().Result.DisplayText), "Home API response was null or empty");
        }
    }
}
