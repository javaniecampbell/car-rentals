namespace shopping_cart.DTOs
{
    public class CartItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }

        private float _subTotal;
        public float SubTotal
        {
            get
            { 
                _subTotal = Price * Quantity;
                return _subTotal;
            }
        }
    }


}