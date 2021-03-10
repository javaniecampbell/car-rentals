using System;
using System.Collections.Generic;

namespace shopping_cart.Data
{
    /// <summary>
    /// Shopping Cart Data Model for the database schema
    /// </summary>
    public class Cart
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public List<CartItem> CartItems { get; set; }
        public int Id { get; set; }
        public float TotalCost { get; set; }
        public string UserId { get; set; }
    }
}
