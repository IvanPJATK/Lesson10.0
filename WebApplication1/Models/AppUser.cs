using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email {  get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
