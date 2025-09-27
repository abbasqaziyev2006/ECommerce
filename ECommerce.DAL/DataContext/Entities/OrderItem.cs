namespace ECommerce.DAL.DataContext.Entities
{
    public class OrderItem : TimeStample
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total => Price * Quantity;

        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}