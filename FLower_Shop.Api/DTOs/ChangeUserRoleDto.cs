using Flower_Shop.Api.Enums;

namespace Flower_Shop.Api.DTOs
{
    /// <summary>
    ///  Данные для изменения роли пользователя.
    /// </summary>
    /// <param name="Role">Новая роль пользователя</param>
    public record ChangeUserRoleDto(
        UserRole Role
        );
}
