using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StefanStore.Domain.Concrete;

namespace StefanStore.Domain.Abstract.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        //void Rollback();

        IProductRepository Products { get; }
    }
}
