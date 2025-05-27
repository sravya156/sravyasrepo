using NatureHub2.Models;

namespace NatureHub2.Repos
{
    public interface IProductRepo : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetByCategoryAsync(string category);
    }
}
