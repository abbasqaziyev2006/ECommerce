namespace ECommerce.BLL.ViewModels
{
    public class WishlistItemViewModel
    {
        public int Id { get; set; }
        public string AppUserId { get; set; } = null!;
        public int ProductId { get; set; }
        public ProductViewModel? Product { get; set; }
    }

    public class CreateWishlistItemViewModel
    {
        public int Id { get; set; }
        public required string AppUserId { get; set; }
        public required int ProductId { get; set; }

    }

    public class UpdateWishlistItemViewModel
    {
    }
}