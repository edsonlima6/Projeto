using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyBISolutions.App_Start;
using MyBISolutions.Mappers;

namespace MyBISolutions
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            App_Start.Ninject.ConfigurarDependencias();
            //AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<DomainToViewModelMappingProfile>());
            AutoMapperonfig.RegisterMappings();
        }
        
    }
}
