namespace ECommerce.DAL.DataContext.Entities
{
    public class Order : TimeStample
    {
        public string UserId { get; set; } = null!;
        public AppUser User { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal TotalPrice { get; set; }
        public int? CouponId { get; set; }
        public Coupon? Coupon { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
}