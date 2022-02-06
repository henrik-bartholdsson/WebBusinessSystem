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

        public async Task<IEnumerable<Category>> GetAllNestedCategoriesAsync()
        {
            var result = await _context.Categories.Where(c => c.TopLevel == true).Include(x => x.SubCategories)
                .ThenInclude(x => x.SubCategories)
                .ToListAsync();
            return result;
        }
    }
}
