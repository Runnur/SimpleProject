using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleProject.Infrastructure;

namespace SimpleProject
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            DependencyResolver.SetResolver(new NinjectDependencyResolver());
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
