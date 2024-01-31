using eshop.DataAccess.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess
{
    public class EFCategoryRepository:ICategoryRepository
    {
        private readonly EShopDbContext dbContext;

        public EFCategoryRepository(EShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
