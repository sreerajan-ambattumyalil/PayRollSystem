using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using PayRollSystem.App_Start;

namespace PayRollSystem
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}