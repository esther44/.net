using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace projetMVC1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Test",
                url: "Test/Test9/{id}/{categorie}",
                defaults: new { controller = "Test", action = "Test9", id = UrlParameter.Optional, categorie = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "Testbis",
              url: "Test/Test10/{id}/{marque}/{prix}",
              defaults: new { controller = "Test", action = "Test10", id = UrlParameter.Optional, marque = UrlParameter.Optional, prix = UrlParameter.Optional }
          );
        }
    }
}
