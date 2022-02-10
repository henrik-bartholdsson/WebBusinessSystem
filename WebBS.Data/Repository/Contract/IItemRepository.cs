using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebBS.Data.Models;

namespace WebBS.Data.Repository.Contract
{
    public interface IItemRepository
    {
        public Task<IEnumerable<Item>> GetItemsByCategoryId(Guid guid);
    }
}
