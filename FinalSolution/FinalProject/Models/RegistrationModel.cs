using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class RegistrationModel
    {
        [Required, MaxLength(50)]
        public string? Username { get; set; }

        [Required, EmailAddress, MaxLength(100)]
        public string? Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password), Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}
