using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_cart.Services
{
    public interface ICartsService
    {
        DTOs.CartDto GetCustomerCart(string userId);
        List<DTOs.CartDto> GetAllCarts();
    }
}
