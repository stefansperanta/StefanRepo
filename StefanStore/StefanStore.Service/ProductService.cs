using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StefanStore.Domain;
using StefanStore.Domain.Abstract.UnitOfWork;
using StefanStore.Domain.Concrete;

namespace StefanStore.Service
{
    public class ProductService:IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Product product)
        {
            _unitOfWork.Products.Add(product);
        }

        public void Delete(int id)
        {
            _unitOfWork.Products.Delete(id);
        }

        public Product GetProduct(int id)
        {
            return _unitOfWork.Products.GetById(id);
        }

        public IEnumerable<Product> GetPagedList(int pageNumber, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            _unitOfWork.Products.Update(product);
        }
    }
}
