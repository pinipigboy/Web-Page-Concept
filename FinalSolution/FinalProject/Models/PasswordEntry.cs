namespace FinalProject.Models;

public class PasswordEntry
    {
        public int Id { get; set; }
        public string Website { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // In a real app, this would be encrypted and not handled as plain text
    }