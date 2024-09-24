using Microsoft.AspNetCore.Identity;

namespace CrudApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}