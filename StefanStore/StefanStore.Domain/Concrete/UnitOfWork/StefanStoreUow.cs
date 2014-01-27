using System;
using StefanStore.Domain.Abstract;
using StefanStore.Domain.Abstract.UnitOfWork;

namespace StefanStore.Domain.Concrete.UnitOfWork
{
    public class StefanStoreUow : IUnitOfWork, IDisposable
    {
        private StefanStoreDbContext DbContext { get; set; }
        private IProductRepository _products;

        public StefanStoreUow()
        {
            CreateDbContext();
        }

        private void CreateDbContext()
        {
            DbContext = new StefanStoreDbContext();

            DbContext.Configuration.ProxyCreationEnabled = false;
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Configuration.ValidateOnSaveEnabled = false;
        }

        #region IUnitOfWork
        public IProductRepository Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new ProductRepository(DbContext);
                }
                return _products;
            }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }
        #endregion
    }
}
