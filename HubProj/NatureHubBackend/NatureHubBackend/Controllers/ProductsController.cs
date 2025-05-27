using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NatureHub2.Models;
using NatureHub2.Repos;

namespace NatureHub2.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepo _repo;

        public ProductsController(IProductRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts() => await _repo.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id) => await _repo.GetByIdAsync(id);

        [HttpPost]
        public async Task AddProduct(Product product) => await _repo.AddAsync(product);

        [HttpPut]
        public async Task UpdateProduct(Product product) => await _repo.UpdateAsync(product);

        [HttpDelete("{id}")]
        public async Task DeleteProduct(int id) => await _repo.DeleteAsync(id);
    }
}
