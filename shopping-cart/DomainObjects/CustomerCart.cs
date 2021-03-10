using shopping_cart.Data;
using shopping_cart.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_cart.DomainObjects
{
    // MVC / VM
    /// <summary>
    /// Business Logic Happens here
    /// </summary>
    /// Domain Object - Business Language being for the business value area
    public class CustomerCart
    {
        private CartDto _cart;

        public CustomerCart()
        {
            _cart = new CartDto();
        }
        public void AddtoCart(CartItemDto item)
        {
            if (_cart.CartItems.Exists(i => i.ProductId == item.ProductId))
            {
                var cartItem = _cart.CartItems.Find(i => i.ProductId == item.ProductId);
                cartItem.Quantity += item.Quantity;
                var index = _cart.CartItems.FindIndex(i => i.ProductId == item.ProductId);
                _cart.CartItems.RemoveAt(index);
                _cart.CartItems.Add(cartItem);
            }
            else
            {
                _cart.CartItems.Add(item);

            }
        }

        public void RemoveItem(int itemId, int quantity)
        {

        }

        public void IncreaseQuantity(int itemId, int quantity)
        {

        }
        // MVC
        // From Entry Point 
        // Request Object -> Controller -> Service -> Business Logic -> REAL WOLRD Database -> GOAL!! -> Transform -> Controller -> Response Object 
        // Request Response Pattern  TCP/ HTTP Request Response
        public void DecreaseQuantity(int itemId, int quantity)
        {

        }

        public Cart ToEntity()
        {
            var entity = new Cart();

            entity.Id = _cart.CartId;
            entity.TotalCost = _cart.TotalItemsCost;
            entity.UserId = _cart.UserId;
            _cart.CartItems
                   .ForEach(cartItem => entity.CartItems.Add(new CartItem
                   {
                       Name = cartItem.Name,
                       Id = cartItem.Id,
                       Price = cartItem.Price,
                       Quantity = cartItem.Quantity,
                       ProductId = cartItem.ProductId

                   }));
            return entity;
        }

        public CartDto FromEntity(Cart entity)
        {
            _cart.CartId = entity.Id;
            _cart.TotalItemsCost = entity.TotalCost;
            _cart.UserId = entity.UserId;

            if (entity.CartItems != null)
                entity.CartItems
                    .ForEach(cartItem => _cart.CartItems.Add(new DTOs.CartItemDto
                    {
                        Name = cartItem.Name,
                        Id = cartItem.Id,
                        Price = cartItem.Price,
                        Quantity = cartItem.Quantity,
                        ProductId = cartItem.ProductId

                    }));

            return _cart;
        }

        public bool IsEmpty(Cart cart)
        {
            return cart == null;
        }
    }
}
