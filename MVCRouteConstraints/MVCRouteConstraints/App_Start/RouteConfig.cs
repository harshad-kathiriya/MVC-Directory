using MVCRouteConstraints.CustomConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCRouteConstraints
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region Constraints at route level
            
            // postal code route
            routes.MapRoute(
                name: "PostalCode",
                url: "postalcode/{pin}",
                defaults: new { controller = "PostalCode", action = "index" },
               constraints: new { pin = @"\d{6}" } // Regexp validation 
                );

            // card route
            routes.MapRoute(
                name: "Card",
                url: "Card/{expiry}",
                defaults: new { controller = "Card", action = "index" },
                constraints: new { expiry = new CardExpiryConstraints("MMyyyy") }
                );

            #endregion

            // default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}