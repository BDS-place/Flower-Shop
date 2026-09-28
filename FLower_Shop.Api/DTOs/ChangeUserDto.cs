using System.ComponentModel.DataAnnotations;

namespace Flower_Shop.Api.DTOs
{
    /// <summary>
    /// Данные для изменения профиля пользователя.
    /// Все поля опциональны: непереданные (null) поля остаются без изменений.
    /// </summary>
    /// <param name="Email">Новый email. Не передан — не изменяется.</param>
    /// <param name="FirstName">Новое имя. Не передано — не изменяется.</param>
    /// <param name="LastName">Новая фамилия. Не передана — не изменяется.</param>
    /// <param name="MiddleName">Новое отчество. Не передано — не изменяется.</param>
    /// <param name="PhoneNumber">Новый номер телефона. Не передан — не изменяется.</param>
    public record ChangeUserDto(
        [EmailAddress] string? Email,
        string? FirstName,
        string? LastName,
        string? MiddleName,
        [Phone] string? PhoneNumber);
}
