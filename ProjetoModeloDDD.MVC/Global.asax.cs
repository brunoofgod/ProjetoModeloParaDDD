using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BrunoofgodArch.MVC.AutoMapper;

namespace BrunoofgodArch.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings();
        }
    }
}
