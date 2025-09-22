namespace ECommerce.DAL.DataContext.Entities
{
    public class OrderItem : TimeStample
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Price per item
        public Product Product { get; set; } = null!;
        public Order Order { get; set; } = null!;
    }
}