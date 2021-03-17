using shopping_cart.DomainObjects;
using shopping_cart.DTOs;
using shopping_cart.Repositories;
using System.Collections.Generic;
using System.Linq;
namespace shopping_cart.Services
{
    public class CartsService : ICartsService
    {
        private readonly ICartsRepository _cartsRepository;
        private readonly CustomerCart _customerCart;
        public CartsService(ICartsRepository cartsRepository, CustomerCart customerCart)
        {
            _cartsRepository = cartsRepository;
            _customerCart = customerCart;
        }

        public List<CartDto> GetAllCarts()
        {
            var dtos = _cartsRepository.GetAllCarts()
                 .Select(c => new DTOs.CartDto()
                 {
                     CartId = c.Id,
                     TotalItemsCost = c.TotalCost,
                     UserId = c.UserId
                 });
            return dtos.ToList();

        }

        public CartDto GetCustomerCart(string userId)
        {
            // transformation in services
            // business logic 

            // etc
            var entity = _cartsRepository.GetSingleCart(userId);
            
            return _customerCart.FromEntity(entity);
        }
    }
}
