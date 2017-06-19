using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MediaWebView
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,
                "",
                new { Controller = "Customer", action = "List",
                    category = (string)null,
                    page = 1
                }              
            );

            routes.MapRoute(null,
                "Page{page}",
                new {controller = "Customer", action = "List",
                category = (string)null},
                new {page = @"\d+"}
                );

            routes.MapRoute(null,
                "{city}",
                new {controller = "Customer", action = "List", page = 1 }
                );

            routes.MapRoute(null,
                "{city}/Page{page}",
                new {controller = "Customer", action ="List"},
                new { page = @"\d+"}
                );

            routes.MapRoute(null, "{controller}/{action}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Customer", action = "List", id = UrlParameter.Optional }
            //);
        }
    }
}
