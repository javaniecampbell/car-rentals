using shopping_cart.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_cart.Repositories
{
    public class CartsRepository : ICartsRepository
    {
        private readonly ShoppingCartDbContext _context;

        public CartsRepository(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public List<shopping_cart.Data.Cart> GetAllCarts()
        {
            return _context.Carts.ToList();
        }

        public Data.Cart GetSingleCart(string userId)
        {
            var cart = _context.Carts.FirstOrDefault(c => c.UserId == userId);
            if(cart == null)
            {
                return null;
            }
            return cart;
        }
    }
}
