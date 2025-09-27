namespace ECommerce.DAL.DataContext.Entities
{
    public class ContactInfo : TimeStample
    {
        public required string Phone { get; set; }
        public string? Address { get; set; }
        public required string Email { get; set; }

    }
}