using FrontEnd_MVCRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebBS.Core;
using WebBS.Core.Service;
using WebBS.Data.Repository.Contract;

namespace FrontEnd_MVCRazor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebBSService _service;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IWebBSService service, IUnitOfWork unitOfWork)
        {
            _service = service;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var allCategories = _service.GetAllNestedCategoriesAsync().Result;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        #region Api actions

        [HttpGet]
        public IActionResult MenuItems()
        {
            
            var allCategories = _service.GetAllNestedCategoriesAsync().Result;
            return Json(allCategories);
        }

        [HttpGet]
        public IActionResult Category([FromQuery] Guid guid)
        {
            var category = _unitOfWork.CategoryRepository.FindByIdAsync(guid).Result;

            return Json(category);
        }

        [HttpGet]
        public IActionResult Items([FromQuery] Guid guid)
        {
            var items = _service.GetAllItemsInCategory(guid).Result;

            return Json(items);
        }

        #endregion
    }
}
