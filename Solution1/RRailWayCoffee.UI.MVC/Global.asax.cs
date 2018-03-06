using RailWayCoffee.Services;
using RailWayCoffee.UI.MVC;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RRailWayCoffee.UI.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DependencyResolver.SetResolver(new RailWayCoffee.UI.MVC.Infrastructure.NinjectDependencyResolver());
            AutoMapperBootStrapper.ConfigureAutoMapper();
        }
    }
}
