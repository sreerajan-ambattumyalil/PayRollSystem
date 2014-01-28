using System.Web.Mvc;
using System.Web.Routing;

namespace PayRollSystem.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Employee", action = "RegisterNewEmployee", id = UrlParameter.Optional }
            );
        }
    }
}