﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Eogrenme
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute("Login" , "", new { controller = "Login", action = "Auth", id = UrlParameter.Optional });
            routes.MapRoute("Home", "home", new { controller = "AdminLogin", action = "Page", id = UrlParameter.Optional });
            routes.MapRoute("Logout", "logout", new { controller = "Login", action = "Logout", id = UrlParameter.Optional });

        }
    }
}
