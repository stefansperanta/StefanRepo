using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SportsStore.WebUI.Infrastructure;
using StefanStore.Infrastructure;
using StefanStore.Infrastructure.Concrete.NInject;
using StefanStore.WebUI.Helpers;

namespace StefanStore.WebUI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

            List<Type> moduleTypes = new List<Type>();
            Type moduleType = typeof(IAppModule);

            foreach (var assembly in AssemblyLocator.GetBinFolderAssemblies())
            {
                try
                {
                    foreach (Type t in assembly.GetTypes())
                    {
                        if (moduleType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                            moduleTypes.Add(t);
                    }
                }
                catch (Exception e)
                {
                }
            }

            foreach (var type in moduleTypes)
            {
                IAppModule moduleInstance = (IAppModule)Activator.CreateInstance(type);
                moduleInstance.Bind(NInjectBinder.Instance);
            }

            //IEnumerable<Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies();
            //foreach (Assembly assembly in assemblies)
            //{
            //    foreach (Type type in assembly.GetTypes())
            //    {
            //        if (
            //            type.GetInterfaces()
            //                .Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof (IAppModule)))
            //        {

            //        }
            //    }
            //}
        }
    }
}