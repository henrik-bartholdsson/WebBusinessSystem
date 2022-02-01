using WebBS.Data.Models;
using WebBS.Data.Repository.Contract;

namespace WebBS.Data.Repository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        private readonly WebBSContext _context;

        public ItemRepository(WebBSContext context) : base(context)
        {
            _context = context;
        }
    }
}
