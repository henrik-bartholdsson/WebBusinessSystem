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
        private readonly WebBSContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public WebBSService(WebBSContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _unitOfWork.CategoryRepository.GetAllAsync();
        }

        public Item GetFirstItem()
        {
            return _context.Items.Where(i => i != null).FirstOrDefault();
        }

        public async Task<IEnumerable<Category>> GetAllNestedCategoriesAsync()
        {
            return await _unitOfWork.CategoryRepository.GetAllNestedCategoriesAsync();
        }


        #region Helpers


        #endregion

    }
}
