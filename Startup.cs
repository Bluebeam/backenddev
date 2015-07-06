using Microsoft.Owin;
using Netface.Data;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(Netface.Startup))]

namespace Netface
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

            // configure pre-populated data
            ShowRepo.Instance.AddShow(new Show(UniqueId.Next(), "Breaking Bad"));
            ShowRepo.Instance.AddShow(new Show(UniqueId.Next(), "House of Cards"));
            ShowRepo.Instance.AddShow(new Show(UniqueId.Next(), "Family Guy"));
            ShowRepo.Instance.FindById(1).Episodes.Add(new Episode(UniqueId.Next(), "Pilot"));
            ShowRepo.Instance.FindById(1).Episodes.Add(new Episode(UniqueId.Next(), "Cat's in the Bag..."));
            ShowRepo.Instance.FindById(1).Episodes.Add(new Episode(UniqueId.Next(), "...And the Bag's in the River"));
            ShowRepo.Instance.FindById(2).Episodes.Add(new Episode(UniqueId.Next(), "Chapter 1"));
            ShowRepo.Instance.FindById(2).Episodes.Add(new Episode(UniqueId.Next(), "Chapter 2"));
            ShowRepo.Instance.FindById(2).Episodes.Add(new Episode(UniqueId.Next(), "Chapter 3"));
            ShowRepo.Instance.FindById(3).Episodes.Add(new Episode(UniqueId.Next(), "Death Has a Shadow"));
            ShowRepo.Instance.FindById(3).Episodes.Add(new Episode(UniqueId.Next(), "I Never Met the Dead Man"));
            ShowRepo.Instance.FindById(3).Episodes.Add(new Episode(UniqueId.Next(), "Chitty Chitty Death Bang"));
        }
    }
}