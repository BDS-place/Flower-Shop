using Flower_Shop.Api.Enums;

namespace Flower_Shop.Api.DTOs
{
    /// <summary>
    /// Данные для отображения пользователя.
    /// </summary>
    /// <param name="UserId">Id-пользователя. Используется для индексации в БД</param>
    /// <param name="Email">Email пользователя. Используется для входа в систему и связи с пользователем</param>
    /// <param name="PhoneNumber">Номер телефона пользователя. Необязательное поле, не указан — null</param>
    /// <param name="FirstName">Имя пользователя. Необязательное поле, не указан — null</param>
    /// <param name="LastName">Фамилия пользователя. Необязательное поле, не указан — null</param>
    /// <param name="MiddleName">Отчество пользователя. Необязательное поле, не указан — null</param>
    /// <param name="Role">Роль пользователя. Используется для установки уровня доступа к системе</param>
    /// <param name="Status">Статус пользователя. Используется для мягкого удаления учетной записи без потери данных</param>
    public record UserDto(
        int UserId,
        string Email,
        string? PhoneNumber,
        string? FirstName,
        string? LastName,
        string? MiddleName,
        UserRole Role,
        UserStatus Status
        );
}
