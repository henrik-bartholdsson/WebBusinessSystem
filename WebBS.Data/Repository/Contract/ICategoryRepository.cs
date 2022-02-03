using System.Collections.Generic;
using System.Threading.Tasks;
using WebBS.Data.Models;

namespace WebBS.Data.Repository.Contract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public Task<IEnumerable<Category>> GetAllNestedCategoriesAsync();
    }
}
