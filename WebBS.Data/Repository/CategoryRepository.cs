using Microsoft.EntityFrameworkCore;
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
            return await _context.Categories.Where(c => c.ParentId == 0).Include(x => x.SubCategories)
                .ThenInclude(x => x.SubCategories)
                .ToListAsync();
        }
    }
}
