using System;
using System.Collections.Generic;
using System.Text;

namespace WebBS.Data.Repository.Contract
{
    public interface IUnitOfWork
    {
        IOrderHeadRepository OrderHeadRepository { get; }
        IItemRepository ItemRepository { get; }
        ICategoryRepository CategoryRepository { get; }
    }
}
