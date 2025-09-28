namespace ECommerce.BLL.ViewModels
{
    public class ProductVariantViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string? CoverImageName { get; set; }
        public IList<string> ImageNames { get; set; } = [];
    }
    public class ProductVariantCreateViewModel { }
    public class ProductVariantUpdateViewModel { }

}