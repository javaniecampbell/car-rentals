using NUnit.Framework;
using shopping_cart.DomainObjects;
using shopping_cart.DTOs;

namespace ShoppingCart.Tests
{
    public class DomainCartTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ItemsCountShouldBeGreaterThanZero()
        {
            //Arrange
            CustomerCart sut = new CustomerCart();
            CartItemDto item = new CartItemDto()
            {
                ProductId = 1,
                Quantity = 1,
                Price = 2.99f
            };
            // Act
            sut.AddtoCart(item);
            var cart = sut.ToEntity();

            // Assert
            Assert.Greater(cart.CartItems.Count, 0); // 

        }

        [Test]
        public void ItemsShouldIncreaseByOneWhenAnItemIsGiven()
        {
            //Arrange
            CustomerCart sut = new CustomerCart();
            CartItemDto item = new CartItemDto()
            {
                ProductId = 1,
                Quantity = 1,
                Price = 2.99f
            };
            // Act
            sut.AddtoCart(item);
            var cart = sut.ToEntity();

            // Assert
            Assert.Greater( 0, cart.CartItems.Count, "Cart Is Not Empty"); // 
            Assert.AreEqual( 1, cart.CartItems.Count, "Count is Equal to One"); //

        }
        [Test]
        public void ItemQuantityShouldIncreaseByOneWhenGivenTheSameItem()
        {
            //Arrange
            CustomerCart sut = new CustomerCart();
            CartItemDto item = new CartItemDto()
            {
                ProductId = 1,
                Quantity = 1,
                Price = 2.99f
            };
            // Act
            sut.AddtoCart(item);
            sut.AddtoCart(item);

            var cart = sut.ToEntity();
            var cartItem = cart.CartItems.Find(i => i.ProductId == item.ProductId);
            // Assert
            //Assert.Greater(cart.CartItems.Count, 0, "Cart Is Not Empty"); // 
            Assert.AreEqual(2, cartItem.Quantity, $"Item with Product ID [{item.ProductId}] is Equal to Two"); //

        }


    }
}