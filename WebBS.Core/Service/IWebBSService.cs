using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebBS.Data.Models;

namespace WebBS.Core.Service
{
    public interface IWebBSService
    {
        public Item GetFirstItem();
        public Task<IEnumerable<Category>> GetCategories();
    }
}
