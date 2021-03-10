using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_cart.Repositories
{
    public interface ICartsRepository
    {
       Data.Cart GetSingleCart(string userId);
       List<Data.Cart> GetAllCarts();
    }

}
