using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWorld.WebApplication.Startup))]
namespace HelloWorld.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}