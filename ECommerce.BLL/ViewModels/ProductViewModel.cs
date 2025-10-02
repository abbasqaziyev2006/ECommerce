
namespace ECommerce.BLL.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public string DetailsUrl => $"{Name?.Replace(" ", "-").Replace("/", "-")}-{Id}";

        public string? Description { get; set; }

        public string? AdditionalInformation { get; set; }

        public decimal Price { get; set; }

        public string? CoverImageName { get; set; }

        public string? CategoryName { get; set; }
        public int CategoryId { get; set; }
        public List<ProductImageViewModel> Images { get; set; } = new();
        public List<ProductVariantViewModel> Variants { get; set; } = new();
    }

    public class CreateProductViewModel
    {
    }

    public class UpdateProductViewModel
    {


    }
}

