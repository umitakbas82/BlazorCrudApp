using SharedLibrary.Models;
using SharedLibrary.ProductRepository;
using System.Net.Http.Json;

namespace BlazorCrudApp.Client.Services
{
    public class ProductService : IProductRepository
    {
        private readonly HttpClient httpClient;
        public ProductService (HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Product> AddProductAsync(Product model)
        {
            var product = await httpClient.PostAsJsonAsync("api/Product", model);
            var response = await product.Content.ReadFromJsonAsync<Product>();
            return response!;
        }

        public Task<Product> DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
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
