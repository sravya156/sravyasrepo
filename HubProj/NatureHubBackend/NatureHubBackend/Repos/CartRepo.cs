using Microsoft.EntityFrameworkCore;
using NatureHub2.Models;
using System;

namespace NatureHub2.Repos
{
    public class CartRepo: Repository<Cart>, ICartRepo
    {
        public CartRepo(HubDb2Context context) : base(context) { }
        public async Task<IEnumerable<Cart>> GetAllAsync()
        {
            return await _context.Carts
                .Include(c => c.Product) // ✅ Include Product details
                .Include(c => c.User) // (Optional) Include User details
                .ToListAsync();
        }

        // ✅ Get a specific cart item by ID, including Product and User details
        public async Task<Cart?> GetByIdAsync(int id)
        {
            return await _context.Carts
                .Include(c => c.Product) // ✅ Include Product details
                .Include(c => c.User) // (Optional) Include User details
                .FirstOrDefaultAsync(c => c.CartId == id);
        }
        public async Task AddAsync(Cart cart)
        {
            await _context.Carts.AddAsync(cart);
            await _context.SaveChangesAsync();
        }

        // ✅ Update an existing cart item
        public async Task UpdateAsync(Cart cart)
        {
            _context.Carts.Update(cart);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Cart>> GetCartByUserIdAsync(int userId)
        {
            return await _context.Carts
                .Where(c => c.UserId == userId)
                .Include(c => c.Product)  // Fetch product details
                .ToListAsync();
        }

        // ✅ Remove a cart item by ID
        public async Task DeleteAsync(int id)
        {
            var cartItem = await _context.Carts.FindAsync(id);
            if (cartItem != null)
            {
                _context.Carts.Remove(cartItem);
                await _context.SaveChangesAsync();
            }
        }
    }



}
