using System.Web.Http;
using WebActivatorEx;
using Bluebeam;
using Swashbuckle.Application;
using System.Net.Http;
using System;
using System.Web;

namespace Bluebeam
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Bluebeam");
                    c.RootUrl(GetBasePath);
                    c.IncludeXmlComments(GetXmlCommentsPath());
                })
                .EnableSwaggerUi();
        }

        private static string GetBasePath(HttpRequestMessage req)
        {
            return req.RequestUri.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/").TrimEnd('/');
        }

        private static string GetXmlCommentsPath()
        {
            return string.Format(@"{0}\bin\Bluebeam.xml", AppDomain.CurrentDomain.BaseDirectory);
        }

        private static string GetModelXmlCommentsPath()
        {
            return string.Format(@"{0}\bin\Bluebeam.xml", AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}