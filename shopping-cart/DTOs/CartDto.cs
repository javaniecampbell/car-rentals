using System;
using System.Collections.Generic;

namespace shopping_cart.DTOs
{
    // Response/ Requests Objects
    /// <summary>
    /// Response Object this only for public facing use
    /// </summary>
    public class CartDto
    {
        public CartDto()
        {
            CartItems = new List<CartItemDto>();
        }
        public List<CartItemDto> CartItems { get; set; }
        public int CartId { get; set; }
        public float TotalItemsCost { get; set; }
        public string UserId { get; set; }

    }
}
