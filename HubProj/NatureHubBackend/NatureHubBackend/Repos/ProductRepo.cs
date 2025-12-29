using Microsoft.EntityFrameworkCore;
using NatureHub2.Models;
using System;

namespace NatureHub2.Repos
{
    public class ProductRepo : Repository<Product>, IProductRepo
    {
        public ProductRepo(HubDb2Context context) : base(context) { }

        public async Task<IEnumerable<Product>> GetByCategoryAsync(string category)
        {
            return await _context.Products.Where(p => p.Category == category).ToListAsync();
        }
    }
}
