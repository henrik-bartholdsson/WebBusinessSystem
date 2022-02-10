using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebBS.Data.Models;

namespace WebBS.Data.Repository.Contract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public Task<IEnumerable<Category>> GetNestedCategoriesAsync();
        public Task<IEnumerable<Category>> GetSubCategoriesAsync(Guid guid);

        public Task<Category> FindByIdAsync(Guid guid);
    }
}
