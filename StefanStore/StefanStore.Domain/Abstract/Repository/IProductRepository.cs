using System.Linq;

namespace StefanStore.Domain.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable<Product> GetProductsByCategory(string categoryName); 
    }
}
