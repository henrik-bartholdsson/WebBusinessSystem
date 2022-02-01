using WebBS.Data.Models;
using WebBS.Data.Repository.Contract;

namespace WebBS.Data.Repository
{
    public class OrderHeadRepository : Repository<OrderHead>, IOrderHeadRepository
    {
        private readonly WebBSContext _context;
        public OrderHeadRepository(WebBSContext context) : base(context)
        {
            _context = context;
        }
    }
}
