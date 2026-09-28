using Flower_Shop.Api.DTOs;
using Flower_Shop.Api.Enums;

namespace Flower_Shop.Api.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(int id);
        Task<UserDto> CreateUserAsync(CreateUserDto dto);
        Task DeleteUserAsync(int id);
        Task<UserDto> ChangeUserAsync(int id, ChangeUserDto dto);
        Task ChangeUserPasswordAsync(int id, ChangeUserPasswordDto dto);
        Task ChangeUserRoleAsync(int id, ChangeUserRoleDto dto);
    }
}
