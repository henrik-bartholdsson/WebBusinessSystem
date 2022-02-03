using WebBS.Data.Models;
using WebBS.Data.Repository.Contract;

namespace WebBS.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebBSContext _context;
        public UnitOfWork(WebBSContext context)
        {
            _context = context;
            OrderHeadRepository = new OrderHeadRepository(_context);
            ItemRepository= new ItemRepository(_context);
            CategoryRepository= new CategoryRepository(_context);
        }


        public IOrderHeadRepository OrderHeadRepository { get; private set; }
        public IItemRepository ItemRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
    }
}
