namespace ECommerce.DAL.DataContext.Entities
{
    public class WebsiteInfo : Entity
    {
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public required string Email { get; set; }
        public required string Copyright { get; set; }
    }
}