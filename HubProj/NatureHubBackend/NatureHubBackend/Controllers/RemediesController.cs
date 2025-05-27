using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NatureHub2.Models;
using NatureHub2.Repos;

namespace NatureHub2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemediesController : ControllerBase
    {
        private readonly IRemedyRepo _repo;

        public RemediesController(IRemedyRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Remedy>> GetRemedies() => await _repo.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<Remedy> GetRemedy(int id) => await _repo.GetByIdAsync(id);

        [HttpPost]
        public async Task AddRemedy(Remedy remedy) => await _repo.AddAsync(remedy);

        [HttpPut]
        public async Task UpdateRemedy(Remedy remedy) => await _repo.UpdateAsync(remedy);

        [HttpDelete("{id}")]
        public async Task DeleteRemedy(int id) => await _repo.DeleteAsync(id);
    }
}
