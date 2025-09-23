namespace ECommerce.DAL.DataContext.Entities
{
    public class Product : TimeStample
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? AdditionalInformation { get; set; }

        public decimal Price { get; set; }

        public string CoverImageName { get; set; } = null!;

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
        public List<OrderItem> OrderItems { get; set; } = [];
        public decimal DiscountPrice { get;  set; }
        public  List<ProductSize> ProductSizes { get; set; } = []; 
        public List<ProductTag> ProductTags { get; set; } = [];
        public List<ProductImage> Images { get; set; } = [];

    }
}