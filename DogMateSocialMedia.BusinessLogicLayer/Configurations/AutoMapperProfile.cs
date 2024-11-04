using AutoMapper;
using DogMateSocialMedia.BusinessLogicLayer.DTO.Request;
using DogMateSocialMedia.DataAccessLayer.Models;

namespace DogMateSocialMedia.BusinessLogicLayer.Configurations;

public class AutoMapperProfile : Profile
{
    private void CreateUserMaps()
    {
        CreateMap<UserDTO, User>();
        CreateMap<User, UserDTO>();
    }

    public AutoMapperProfile()
    {
        CreateUserMaps();
    }
}