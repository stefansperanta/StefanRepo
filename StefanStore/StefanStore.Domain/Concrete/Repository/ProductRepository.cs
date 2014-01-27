using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StefanStore.Domain.Abstract;

namespace StefanStore.Domain.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {

        }

        public IQueryable<Product> GetProductsByCategory(string categoryName)
        {
            return GetAll().Where(p => p.Category == categoryName);
        }
    }
}