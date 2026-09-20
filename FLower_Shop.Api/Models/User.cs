using Flower_Shop.Api.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flower_Shop.Api.Models
{
    [Table("users")]
    public class User
    {
        public int UserId { get; set; }
        public string Login {  get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? PhoneNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public UserRole Role { get; set; }
        public UserStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
