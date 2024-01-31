using eshop.DataAccess.DataContext;
using eshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess
{
    public class EFProductRepository :IProductRepository
    {
        private readonly EShopDbContext dbContext;

        public EFProductRepository(EShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByName(string productName)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
