using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBS.Data.Models;
using WebBS.Data.Repository.Contract;

namespace WebBS.Core.Service
{
    public class WebBSService : IWebBSService
    {
        private readonly IUnitOfWork _unitOfWork;
        public WebBSService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _unitOfWork.CategoryRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Category>> GetAllNestedCategoriesAsync()
        {
            return await _unitOfWork.CategoryRepository.GetNestedCategoriesAsync();
        }

        public async Task<IEnumerable<Item>> GetAllItemsInCategory(Guid guid)
        {
            var items = new List<Item>();

            var categories = 
                _unitOfWork
                .CategoryRepository
                .GetSubCategoriesAsync(guid)
                .Result;

            var myGuids = GetCategoriesId(categories);

            foreach(var g in myGuids)
            {
                items.AddRange(
                    _unitOfWork
                    .ItemRepository
                    .GetItemsByCategoryId(g)
                    .Result
                    .ToList());
            }

            return await Task.FromResult(items);
        }


        #region Helpers
        private IEnumerable<Guid> GetCategoriesId(IEnumerable<Category> categories)
        {
            var guids = new List<Guid>();

            foreach (var c in categories)
            {
                guids.Add(c.Id);
                if (c.SubCategories != null)
                {
                    guids.AddRange(GetCategoriesId(c.SubCategories));
                }
            }
            
            return guids;
        }

        #endregion

    }
}
