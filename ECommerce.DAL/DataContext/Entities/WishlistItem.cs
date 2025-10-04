namespace ECommerce.DAL.DataContext.Entities
{
    public class WishlistItem : TimeStample
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string? UserId { get; set; }
        public AppUser AppUser { get; set; } = null!;
    }
}