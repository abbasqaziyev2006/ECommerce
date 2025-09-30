using ECommerce.DAL.DataContext.Entities;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.DAL.DataContext.Entities
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; }

        public List<Address> Addresses { get; set; } = [];
        public List<Order> Orders { get; set; } = [];
        public List<WishlistItem> WishlisItems { get; set; } = [];

    }
}
