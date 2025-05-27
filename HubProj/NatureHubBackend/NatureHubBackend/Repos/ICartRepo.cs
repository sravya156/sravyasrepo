using NatureHub2.Models;

namespace NatureHub2.Repos
{
    public interface ICartRepo {
        Task<IEnumerable<Cart>> GetAllAsync(); // ✅ Get all cart items
        Task<Cart?> GetByIdAsync(int id);
        Task AddAsync(Cart cart); // ✅ Add a new cart item
        Task UpdateAsync(Cart cart); // ✅ Update an existing cart item
        Task DeleteAsync(int id);
        Task<IEnumerable<Cart>> GetCartByUserIdAsync(int userId);
    }
}
