using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace StefanStore.Infrastructure.Concrete.NInject
{
    public class IocModuleLoader
    {
        public void LoadAssembly(IEnumerable<Assembly> assemblies)
        {
            // IKernel nInjectKernel = new StandardKernel();
            // //nInjectKernel.Load(AppDomain.CurrentDomain.GetAssemblies());
            // nInjectKernel.Load(assemblies);

            //// Type t = currentassembly.GetType(typeName, false, true);
            // foreach (var assembly in assemblies)
            // {
            //        foreach (Type t in this.GetType().Assembly.GetTypes())
            //            if (t. is IAppModule)
            //            {
            //            }
            // }


            // List<IAppModule> modules = nInjectKernel.GetAll<IAppModule>().ToList();
            // foreach (var module in modules)
            // {
            //     module.Bind(NInjectBinder.instance);
            // }
        }
    }
}