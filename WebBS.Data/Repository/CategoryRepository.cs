using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBS.Data.Models;
using WebBS.Data.Repository.Contract;

namespace WebBS.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly WebBSContext _context;
        public CategoryRepository(WebBSContext context) : base(context)
        {
            _context = context;
        }

        public Task<Category> FindByIdAsync(Guid guid)
        {
            var result = _context.Categories
                .Where(x => x.Id == guid)
                .Include(x => x.SubCategories)
                .ThenInclude(x => x.SubCategories)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<IEnumerable<Category>> GetNestedCategoriesAsync()
        {
            var result = await _context.Categories
                .Where(c => c.TopLevel == true)
                .Include(x => x.SubCategories)
                .ThenInclude(x => x.SubCategories)
                .ToListAsync();

            return result;
        }

        public async Task<IEnumerable<Category>> GetSubCategoriesAsync(Guid guid)
        {
            var result = await _context.Categories
                .Where(c => c.Id == guid).Include(x => x.SubCategories)
                .ThenInclude(x => x.SubCategories)
                .ToListAsync();

            return result;
        }
    }
}
