using Microsoft.Owin;
using Bluebeam.Data;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(Bluebeam.Startup))]

namespace Bluebeam
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // always use attribute based routing
            HttpConfiguration config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            // enable CORS (Cross Origin Resource Sharing) 
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            SwaggerConfig.Register(config);

            // enable the web api
            app.UseWebApi(config);
        }
    }
}