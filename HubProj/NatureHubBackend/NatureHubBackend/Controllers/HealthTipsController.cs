using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NatureHub2.Models;
using NatureHub2.Repos;

namespace NatureHub2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthTipsController : ControllerBase
    {
        private readonly IHealthTipRepo _repo;

        public HealthTipsController(IHealthTipRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<HealthTip>> GetHealthTips() => await _repo.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<HealthTip> GetHealthTip(int id) => await _repo.GetByIdAsync(id);

        [HttpPost]
        public async Task AddHealthTip(HealthTip healthTip) => await _repo.AddAsync(healthTip);

        [HttpPut]
        public async Task UpdateHealthTip(HealthTip healthTip) => await _repo.UpdateAsync(healthTip);

        [HttpDelete("{id}")]
        public async Task DeleteHealthTip(int id) => await _repo.DeleteAsync(id);
    }
}
