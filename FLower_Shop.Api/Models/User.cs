using Flower_Shop.Api.Enums;

namespace Flower_Shop.Api.Models
{
    /// <summary>
    /// Сущность пользователя для работы с БД через EF Core.
    /// Не должна попадать в контроллеры/API-ответы — наружу отдавать через UserDto.
    /// </summary>

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

        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    }
}
