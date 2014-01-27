using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StefanStore.Infrastructure;

namespace StefanStore.Service
{
    public class ServiceModule:IAppModule
    {
        public void Bind(IBinder binder)
        {
           binder.Bind<IProductService,ProductService>();
        }
    }
}
