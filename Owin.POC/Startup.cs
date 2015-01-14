using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Owin.POC.Startup))]

namespace Owin.POC
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //WebApp
            //app.Run(context =>
            //{
            //    context.Response.ContentType = "text/plain";
            //    return context.Response.WriteAsync("Owin Self-Host test");
            //});

            // Configure Web API for OWIN Self-Host
            HttpConfiguration config = new HttpConfiguration();

            // Dynamically setup HTTP Attribute routing for Web API 
            config.MapHttpAttributeRoutes();

            // Enable CORS if needed
            //var corsAttribute = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(corsAttribute);

            app.UseWebApi(config);
        }
    }
}
