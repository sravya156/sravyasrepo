using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NatureHub2.Models;
using NatureHub2.Repos;

namespace NatureHub2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepo _repo;

        public CartController(ICartRepo repo)
        {
            _repo = repo;
        }

   
        [HttpGet]
        public async Task<IEnumerable<Cart>> GetCartItems()
        {
            var cartItems = await _repo.GetAllAsync();
            return cartItems;  // Returns cart items with product details
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<Cart>> GetCartItem(int id)
        {
            var cartItem = await _repo.GetByIdAsync(id);
            if (cartItem == null)
            {
                return NotFound("Cart item not found.");
            }

            return Ok(cartItem);
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<Cart>>> GetCartByUserId(int userId)
        {
            var cartItems = await _repo.GetCartByUserIdAsync(userId);

            if (cartItems == null || !cartItems.Any())
            {
                return NotFound("No cart items found for the given user.");
            }

            return Ok(cartItems);  // Return cart items with product details
        }

        
        [HttpPost]
        public async Task<IActionResult> AddToCart(Cart cart)
        {
            await _repo.AddAsync(cart);
            return Ok(new { message = "Item added to cart successfully!" });
        }

        
        [HttpPut]
        public async Task<IActionResult> UpdateCartItem(Cart cart)
        {
            await _repo.UpdateAsync(cart);
            return Ok(new { message = "Cart item updated successfully!" });
        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveFromCart(int id)
        {
            await _repo.DeleteAsync(id);
            return Ok(new { message = "Cart item removed successfully!" });
        }
    }
}
