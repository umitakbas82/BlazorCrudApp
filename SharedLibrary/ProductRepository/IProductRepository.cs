using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.ProductRepository
{
    public interface IProductRepository
    {
        Task<Product> AddProductAsync(Product model);
        Task<Product> UpdateProductAsync(Product model);
        Task<Product> DeleteProductAsync(int productId);
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int productId);
    }
}
