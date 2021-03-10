namespace shopping_cart.Data
{
    // Data Entities - Database
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }

    }


}