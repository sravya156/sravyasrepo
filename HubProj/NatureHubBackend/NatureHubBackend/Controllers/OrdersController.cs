using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NatureHub2.Models;
using NatureHub2.Repos;

namespace NatureHub2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepo _repo;

        public OrdersController(IOrderRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Order>> GetOrders() => await _repo.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<Order> GetOrder(int id) => await _repo.GetByIdAsync(id);

        [HttpPost]
        public async Task AddOrder(Order order) => await _repo.AddAsync(order);

        [HttpPut]
        public async Task UpdateOrder(Order order) => await _repo.UpdateAsync(order);

        [HttpDelete("{id}")]
        public async Task DeleteOrder(int id) => await _repo.DeleteAsync(id);
    }
}
