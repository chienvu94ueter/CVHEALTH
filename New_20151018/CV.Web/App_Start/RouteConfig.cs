using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CV.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
         name: "About",
         url: "gioi-thieu",
         defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional },
         namespaces: new[]
         {
                    "CV.Web.Controllers"
         }
     );
            routes.MapRoute(
            name: "Category",
            url: "danh-muc",
            defaults: new { controller = "Category", action = "Index", id = UrlParameter.Optional },
            namespaces: new[]
            {
                    "CV.Web.Controllers"
            }
        );
            routes.MapRoute(
            name: "Category Detail",
            url: "danh-muc/{MetaTittle}",
            defaults: new { controller = "Category", action = "Detail", id = UrlParameter.Optional },
            namespaces: new[]
            {
                    "CV.Web.Controllers"
            }
        );
            routes.MapRoute(
           name: "News Detail",
           url: "{categoryMetaTitle}/{MetaTittle}",
           defaults: new { controller = "News", action = "Detail", id = UrlParameter.Optional },
           namespaces: new[]
           {
                    "CV.Web.Controllers"
           }
       );
            routes.MapRoute(
              name: "Contact",
              url: "lien-he",
              defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional },
              namespaces: new[]
              {
                    "CV.Web.Controllers"
              }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces:new []
                {
                    "CV.Web.Controllers"
                }
            );
        }
    }
}
