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
    }
}
