namespace ECommerce.DAL.DataContext.Entities
{
    public class Product : TimeStample
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? AdditionalInformation { get; set; }

        public string CoverImageName { get; set; } = null!;

        public int CategoryId { get; set; }
        public decimal BasePrice { get; set; }
        public Category? Category { get; set; }
        public decimal DiscountPrice { get;  set; }
        public ICollection<ProductImage> ProductImages { get; set; } = [];
        public ICollection<OrderItem> OrderItems { get; set; } = [];
        public ICollection<WishlistItem> WishlistItems { get; set; } = [];
        public ICollection<ProductVariant> ProductVariants { get; set; } = [];

    }
}