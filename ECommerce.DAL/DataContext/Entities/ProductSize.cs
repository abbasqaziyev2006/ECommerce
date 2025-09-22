namespace ECommerce.DAL.DataContext.Entities
{
    public class ProductSize : TimeStample
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty; // "200gr", "500gr", "1000gr"
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; } = true;

        public Product Product { get; set; } = null!;
    }
}