using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCapp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
               name: "Parametry",
               url: "{par1}/{par2}/{par3}",
               defaults: new { controller = "Home", action = "Parametry" }
               );

            routes.MapRoute(
                name: "SamochodSzczegoly",
                url: "Samochod-{id}",
                defaults: new {controller = "Sklep", action = "Szczegoly" }
                );

            routes.MapRoute(
                name: "SamochodLista",
                url: "Model/{nazwa}",
                defaults: new { controller = "Sklep", action = "Lista" },
                constraints: new { nazwa =@"[\w]+"}
                );
            routes.MapRoute(
            name: "Helper",
            url: "Helper/{action}/{id}",
            defaults: new { controller = "Helper", action = "Index", id = UrlParameter.Optional }
        );
            routes.MapRoute(
            name: "Date",
            url: "Date/{action}/{id}",
            defaults: new { controller = "Date", action = "Index", id = UrlParameter.Optional }
        );
            routes.MapRoute(
             name: "Pracownik2",
             url: "Pracownik2/{action}/{id}",
             defaults: new { controller = "Pracownik2", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
                name: "Kurs",
                url: "Kurs/{action}/{id}",
                defaults: new { controller = "Kurs", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Pracownik",
               url: "Pracownik/{action}/{id}",
               defaults: new { controller = "Pracownik", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
