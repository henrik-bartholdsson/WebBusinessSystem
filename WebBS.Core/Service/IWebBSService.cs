using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebBS.Data.Models;

namespace WebBS.Core.Service
{
    public interface IWebBSService
    {
        public Task<IEnumerable<Category>> GetCategories();
        public Task<IEnumerable<Category>> GetAllNestedCategoriesAsync();
        public Task<IEnumerable<Item>> GetAllItemsInCategory(Guid guid);
    }
}
