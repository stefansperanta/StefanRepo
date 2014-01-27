using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefanStore.Infrastructure
{
    public interface IAppModule
    {
        void Bind(IBinder binder);
    }
}