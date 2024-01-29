using eshop.DataAccess;
using eshop.Entities;

namespace eshop.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;
        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
            
        }
        public IEnumerable<Product> GetProducts()
        {
            IEnumerable<Product> products = repository.GetAll();
            return products; 
        }
    }
}

