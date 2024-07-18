using System.ComponentModel.DataAnnotations;

namespace JWT_Token_Learn.Models
{
    public class SignUp
    { 
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        // public byte[] Salt { get; set; }
        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }
    }
}
