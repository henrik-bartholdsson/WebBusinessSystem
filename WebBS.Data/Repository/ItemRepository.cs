using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Item>> GetItemsByCategoryId(Guid guid)
        {
            var items = await _context.Items.Where(x => x.Category == guid).ToListAsync();
            return items;
        }
    }
}
