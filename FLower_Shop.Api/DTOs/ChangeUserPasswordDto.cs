using System.ComponentModel.DataAnnotations;

namespace Flower_Shop.Api.DTOs
{
    /// <summary>
    /// Данные для изменения пароля пользователя.
    /// Все поля обязательные.
    /// </summary>
    /// <param name="OldPassword">Старый пароль пользователя. Сверяется с хэшом пароля из БД</param>
    /// <param name="NewPassword">Новый пароль пользователя. После успешной проверки старого пароля хэшируется и сохраняется</param>
    public record ChangeUserPasswordDto(
        [Required] string OldPassword,
        [Required, MinLength(8)] string NewPassword
        );
}
