using System.ComponentModel.DataAnnotations;

namespace Flower_Shop.Api.DTOs
{
    /// <summary>
    /// Данные для создания профиля пользователя.
    /// </summary>
    /// <param name="Login">Логин пользователя. Обязательное поле</param>
    /// <param name="Password">Пароль пользователя. Обязательное поле</param>
    /// <param name="Email">Email. Обязательное поле</param>
    /// <param name="PhoneNumber">Номер телефона. Необязательное поле. Не передан - null</param>
    /// <param name="FirstName">Имя. Необязательное поле. Не передан - null</param>
    /// <param name="LastName">Фамилия. Необязательное поле. Не передан - null</param>
    /// <param name="MiddleName">Отчество. Необязательное поле. Не передан - null</param>
    public record CreateUserDto(
        [Required, MinLength(4)] string Login,
        [Required, MinLength(8)] string Password,
        [Required, EmailAddress] string Email,
        [Phone] string? PhoneNumber,
        string? FirstName,
        string? LastName,
        string? MiddleName
        );
}
