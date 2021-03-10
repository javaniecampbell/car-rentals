using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopping_cart.Data;

namespace shopping_cart.Data
{
    public class ShoppingCartDbContext : DbContext
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options)
        : base(options)
        {
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<shopping_cart.Data.CartItem> CartItem { get; set; }
    }
}
