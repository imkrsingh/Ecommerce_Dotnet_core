using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Entities
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The confirmation password does not match.")]
        public string ConfirmPassword { get; set; }

        // Additional properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
