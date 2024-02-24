using BlazorCrudApp.Data;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;
using SharedLibrary.ProductRepository;

namespace BlazorCrudApp.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext;
        public ProductRepository(AppDbContext appDbContext) 
        {
            this.appDbContext = appDbContext;        
        }

        public async Task<Product> AddProductAsync(Product model)
        {
            if (model is null) return null!;
           
            var chk = await appDbContext.Products.Where(_ => _.Name.ToLower().Equals(model.Name.ToLower())).FirstOrDefaultAsync();
            if(chk is null)return null!;
           var newDataAdded= appDbContext.Products.Add(model).Entity;
            await appDbContext.SaveChangesAsync();
            return newDataAdded;
        }

        public async Task<Product> DeleteProductAsync(int productId)
        {
            var product = await appDbContext.Products.FirstOrDefaultAsync(_ => _.Id == productId);
            if (product is null) return null!;
            appDbContext.Products.Remove(product);
            await appDbContext.SaveChangesAsync();
            return product;
                
                    }

        public Task<List<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProductAsync(Product model)
        {
            throw new NotImplementedException();
        }
    }
}
