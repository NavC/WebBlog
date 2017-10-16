using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebBlog.Controllers;

namespace WebBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // When you have identical controller names MVC doesn't know which one to open up. This way MVC can know which Controller to open up
            var namespaces = new[] { typeof(PostsController).Namespace }; 

            routes.MapRoute( "Login", "login", new { controller = "Auth", action = "Login" }, namespaces);
            routes.MapRoute( "Home", "", new { controller = "Posts", action = "index"}, namespaces);

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
