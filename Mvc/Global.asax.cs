using Microsoft.Practices.Unity;
using Mvc.App_Start;
using MVCWeb.App_Start;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Mvc
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            UnityContainer container = new UnityContainer();
            IList<Assembly> assList = new List<Assembly>();
            
            assList.Add(Assembly.Load("Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assList.Add(Assembly.Load("IService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assList.Add(Assembly.Load("DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assList.Add(Assembly.Load("IDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            UnityRegister.RegisterAssembly
                (
                    ref container,
                    assList.ToArray()
                    //AppDomain.CurrentDomain.GetAssemblies()
                    //.Where(
                    //    m => m.FullName.IndexOf("Service") >= 0 
                    //    || m.FullName.IndexOf("DAL") >= 0
                    //).ToArray()
            );
            IDependencyResolver resolver=new  UnityDependencyResolver(container);

            GlobalFilters.Filters.Add((MvcActionFilterAttribute)resolver.GetService<MvcActionFilterAttribute>());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            DependencyResolver.SetResolver(resolver);
        }
    }
}