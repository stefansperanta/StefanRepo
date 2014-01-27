using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StefanStore.Domain;

namespace StefanStore.Service
{
    public interface IProductService
    {
        void Create(Product customer);
        void Delete(int id);
        Product GetProduct(int id);
        IEnumerable<Product> GetPagedList(int pageNumber, int pageSize, out int totalRecords);
        void Update(Product customer);
    }
}
