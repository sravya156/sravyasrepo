using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NatureHub2.Models;
using NatureHub2.Repos;

namespace NatureHub2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewRepo _repo;

        public ReviewsController(IReviewRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Review>> GetReviews() => await _repo.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<Review> GetReview(int id) => await _repo.GetByIdAsync(id);

        [HttpPost]
        public async Task AddReview(Review review) => await _repo.AddAsync(review);

        [HttpPut]
        public async Task UpdateReview(Review review) => await _repo.UpdateAsync(review);

        [HttpDelete("{id}")]
        public async Task DeleteReview(int id) => await _repo.DeleteAsync(id);
    }
}
