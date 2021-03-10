using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shopping_cart.Data;
using shopping_cart.Services;

namespace shopping_cart.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartsController : ControllerBase
    {
       

        private readonly ILogger<CartsController> _logger;
        private readonly ICartsService _cartsService;
        private readonly ShoppingCartDbContext context;

        public CartsController(ILogger<CartsController> logger, ICartsService cartsService)
        {
            _logger = logger;
            _cartsService = cartsService;
        }
        // MVC - Model aka Database aka Entities aka Beans
        // V - DTOs aka Response Objects aka ViewModels
        // C  - Controllers

        // Data Layer
        // Services - Services communicate with Respositories
        // Repositories - communicate with the database only

        // Transport layout
       // COntrollers - Only communicate with services.
        [HttpGet]
        public ActionResult<IList<DTOs.CartDto>> Get()
        {
            var carts = _cartsService.GetAllCarts();
            return Ok(carts);
        }

        [HttpGet]
       [Route("{userId}")]
        public ActionResult<Cart> GetById(string userId)
        {
            var cart = _cartsService.GetCustomerCart(userId);
            return Ok(cart);
        }
    }
}
