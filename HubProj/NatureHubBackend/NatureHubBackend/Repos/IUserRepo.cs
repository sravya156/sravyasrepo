using NatureHub2.Models;

namespace NatureHub2.Repos
{
    public interface IUserRepo : IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);
    }
}
