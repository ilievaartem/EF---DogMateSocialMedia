using DogMateSocialMedia.BusinessLogicLayer.DTO.Request;
using DogMateSocialMedia.DataAccessLayer.Parameters;

namespace DogMateSocialMedia.BusinessLogicLayer.Interfaces.Services;

public interface IUserService
{
    Task<UserDTO> GetUserByIdAsync(int id);
    Task<IEnumerable<UserDTO>> GetAllUsersAsync(UserParameters userParameters);
    Task CreateUserAsync(UserDTO userCreate);
    Task DeleteUserAsync(int id);
}