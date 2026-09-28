namespace Flower_Shop.Api.Models
{
    /// <summary>
    /// Refresh-токен пользователя.
    /// </summary>
    public class RefreshToken
    {
        public int Id { get; set; }
        public string TokenHash { get; set; } = default!;
        public DateTime ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRevoked { get; set; }
        public string? DeviceInfo { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
