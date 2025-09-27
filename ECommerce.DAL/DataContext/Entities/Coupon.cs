namespace ECommerce.DAL.DataContext.Entities
{
    public class Coupon : TimeStample
    {
        public string Code { get; set; } = null!;
        public decimal DiscountPercentage { get; set; }
        public decimal? MinimumAmount { get; set; }
        public int? UsageLimit { get; set; }
        public int UsedCount { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
