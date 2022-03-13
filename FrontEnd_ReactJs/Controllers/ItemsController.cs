using Microsoft.AspNetCore.Mvc;
using System;
using WebBS.Core.Service;
using WebBS.Data.Repository.Contract;

namespace FrontEnd_ReactJs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IWebBSService _service;
        private readonly IUnitOfWork _unitOfWork;
        public ItemsController(IWebBSService service, IUnitOfWork unitOfWork)
        {
            _service = service;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetItems([FromQuery] Guid guid)
        {
            var itemsInCategory = _service.GetAllItemsInCategory(guid).Result;

            return Ok(itemsInCategory);
        }
    }
}
