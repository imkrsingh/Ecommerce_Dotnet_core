using Microsoft.AspNetCore.Identity;

namespace EcomProduct.Entities
{
    public class ApplicationUser : IdentityUser
    {
        // Add additional properties if needed
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public string ProfilePictureUrl { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
