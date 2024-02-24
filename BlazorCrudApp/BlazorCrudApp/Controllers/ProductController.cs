using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models;
using SharedLibrary.ProductRepository;

namespace BlazorCrudApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository=productRepository;
        }
        [HttpGet("All-Products")]
        public async Task<ActionResult<List<Product>>>
    }
}
