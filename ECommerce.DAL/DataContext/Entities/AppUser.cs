using ECommerce.DAL.DataContext.Entities;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.DAL.DataContext.Entities
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public List<Address> Addresses { get; set; } = [];
        public List<Order> Orders { get; set; } = [];
        public List<Wishlist> Wishlist { get; set; } = [];

    }
}
