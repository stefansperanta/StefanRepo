using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefanStore.Infrastructure
{
    public interface IBinder
    {
        void Bind<TAbstract, TConcrete>() where TConcrete : TAbstract;
        Object Get(Type type);
    }
}
