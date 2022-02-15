using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebBS.Core.Service;
using WebBS.Data.Repository.Contract;

namespace FrontEnd_ReactJs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IWebBSService _service;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IWebBSService service, IUnitOfWork unitOfWork)
        {
            _service = service;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var allCategories = _service.GetAllNestedCategoriesAsync().Result;
            return Ok(allCategories);
        }

        //[HttpGet]
        //public IActionResult Category([FromQuery] Guid guid)
        //{
        //    var category = _unitOfWork.CategoryRepository.FindByIdAsync(guid).Result;

        //    return Ok(category);
        //}

        //[HttpGet]
        //public IActionResult Items([FromQuery] Guid guid)
        //{
        //    var items = _service.GetAllItemsInCategory(guid).Result;

        //    return Ok(items);
        //}
    }
}
