// User Service Interface
using MVC_Example.Dtos;

namespace MVC_Example.BusinessLayer.Services
{
    public interface IUserService
    {
        Task<UserDto> CreateAsync(UserDto userDto);
        Task<UserDto> GetByIdAsync(int id);
        Task<List<UserDto>> GetAllAsync();
        Task<UserDto> UpdateAsync(UserDto userDto);
        Task DeleteAsync(int id);
    }
}