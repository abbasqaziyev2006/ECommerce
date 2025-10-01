namespace ECommerce.BLL.ViewModels
{
    public class ProductVariantViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public List<string> Images { get; set; } = new();
        public int Quantity { get; set; }
    }
    public class CreateProductVariantViewModel { }
    public class UpdateProductVariantViewModel { }

}