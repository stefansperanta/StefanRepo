using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StefanStore.Domain.Abstract.UnitOfWork;
using StefanStore.Domain.Concrete.UnitOfWork;
using StefanStore.Infrastructure;

namespace StefanStore.Domain.IocBinding
{
    public class DomainModule : IAppModule
    {
        public void Bind(IBinder binder)
        {
            binder.Bind<IUnitOfWork, StefanStoreUow>();
        }
    }
}
