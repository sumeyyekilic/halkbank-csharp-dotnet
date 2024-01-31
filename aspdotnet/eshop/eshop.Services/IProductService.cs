using eshop.Entities;
using eshop.Services.DataTransferObjects.Request;
using eshop.Services.DataTransferObjects.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Services
{
    public interface IProductService
    {
        //IEnumerable<Product> GetProducts();
        Task<IEnumerable<ProductDisplayResponse>> GetProductsAsync();
        Task<IEnumerable<ProductDisplayResponse>> GetProductsByCategoryIdAsync(int categoryId);

        Task<ProductDisplayResponse> GetProductAsync(int id);
        Task<int> CreateAsync(CreateProductRequest request);
        Task<int> UpdateAsync(UpdateProductRequest request);

        Task DeleteAsync(int id);
        Task<IEnumerable<ProductDisplayResponse>> SearchByName(string name);


    }

}
