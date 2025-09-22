namespace ECommerce.DAL.DataContext.Entities
{
    public class Wishlist : TimeStample
    {
        public string UserId { get; set; } = null!;
        public AppUser User { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}