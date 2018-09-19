using ChuteCampeao.MVC.AutoMapper;
using ChuteCampeao.MVC.Helpers.Anotacoes;
using ChuteCampeao.StartUp;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ChuteCampeao.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Injeção de Dependências
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            Bootstraper.Register(container);
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

            //Auto Mapper
            AutoMapperConfig.RegisterMappings();
        }
    }
}
