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
using WebBS.Data.Models;

namespace FrontEnd_MVCRazor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebBSService _service;

        public HomeController(ILogger<HomeController> logger, IWebBSService service)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var allCategories = _service.GetAllNestedCategoriesAsync();
            var firstItem = _service.GetFirstItem();

            return View(firstItem);
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
    }
}
