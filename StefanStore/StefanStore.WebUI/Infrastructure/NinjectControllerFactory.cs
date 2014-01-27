using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using Ninject;
using Ninject.Modules;
using StefanStore.Domain;
using StefanStore.Domain.Abstract;
using StefanStore.Domain.Abstract.UnitOfWork;
using System.Collections.Generic;
using System.Linq;
using StefanStore.Infrastructure.Concrete.NInject;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        public NinjectControllerFactory()
        {

           ////foreach (Type t in this.GetType().Assembly.GetTypes())

           // //IEnumerable<Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies();
           // //foreach (var assembly  in assemblies)
           // //{
                
           // //}

           // //Assembly assemblyAAA = Assembly.LoadFrom("StefanStore.Service.dll");

           // //IocModuleLoader moduleLoader = new IocModuleLoader();
           // //moduleLoader.LoadAssembly(assemblies);

           // AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext
        requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController) NInjectBinder.Instance.Get(controllerType);
        }
        private void AddBindings()
        {
            Mock<IUnitOfWork> mock = new Mock<IUnitOfWork>();
            mock.Setup(m => m.Products.GetAll()).Returns(new List<Product> {
new Product { Name = "Table", Price = 25 },
new Product { Name = "Ball", Price = 179 },
new Product { Name = "Chair", Price = 95 }
}.AsQueryable());
            //ninjectKernel.Bind<IUnitOfWork>().ToConstant(mock.Object);

            //real implementation
            //ninjectKernel.Bind<IUnitOfWork>().To<StefanStoreUow>();
        }
    }
}