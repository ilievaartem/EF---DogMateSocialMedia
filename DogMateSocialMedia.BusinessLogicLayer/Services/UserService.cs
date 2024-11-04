using AutoMapper;
using DogMateSocialMedia.BusinessLogicLayer.DTO.Request;
using DogMateSocialMedia.BusinessLogicLayer.Interfaces.Services;
using DogMateSocialMedia.DataAccessLayer.Interface;
using DogMateSocialMedia.DataAccessLayer.Models;
using DogMateSocialMedia.DataAccessLayer.Parameters;

namespace DogMateSocialMedia.BusinessLogicLayer.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public async Task<UserDTO> GetUserByIdAsync(int id)
    {
        var user = await unitOfWork.UserRepository.GetByIdAsync(id);
        return mapper.Map<User, UserDTO>(user);
    }

    public async Task<IEnumerable<UserDTO>> GetAllUsersAsync(UserParameters userParameters)
    {
        var users = await unitOfWork.UserRepository.GetAsync(userParameters);
        return users.Select(mapper.Map<User, UserDTO>);
    }

    public async Task CreateUserAsync(UserDTO userCreate)
    {
        var user = mapper.Map<UserDTO, User>(userCreate);
        await unitOfWork.UserRepository.AddUser(user);
        await unitOfWork.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(int id)
    {
        await unitOfWork.UserRepository.DeleteUser(id);
        await unitOfWork.SaveChangesAsync();
    }

    public UserService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
}