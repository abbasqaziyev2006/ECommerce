using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.DataContext.Entities
{
    public class Address: TimeStample
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Company { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public bool IsDefault { get; set; } = false;
        public string UserId { get; set; } = null!;
        public AppUser? User { get; set; }
    }
}
