using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class RegistrationModel
    {
        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public bool AcceptTerms { get; set; }
    }
}
