using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Rotas para páginas de erro
            routes.MapRoute(
                name: "Error404",
                url: "404",
                defaults: new { controller = "Error", action = "NotFound" }
            );

            routes.MapRoute(
                name: "Error500",
                url: "500",
                defaults: new { controller = "Error", action = "ServerError" }
            );

            routes.MapRoute(
                name: "Error403",
                url: "403",
                defaults: new { controller = "Error", action = "Forbidden" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
