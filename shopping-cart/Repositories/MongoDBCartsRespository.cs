using shopping_cart.Data;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_cart.Repositories
{
    public class MongoDBCartsRespository : ICartsRepository
    {
        // Dependency on mongodb
        private static ConcurrentBag<Cart> mongoDB = new ConcurrentBag<Cart>();
        public List<Cart> GetAllCarts()
        {
            return mongoDB.AsEnumerable().ToList();
        }

        public Cart GetSingleCart(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
