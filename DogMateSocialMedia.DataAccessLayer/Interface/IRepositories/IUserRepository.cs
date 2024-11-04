using DogMateSocialMedia.DataAccessLayer.Models;
using DogMateSocialMedia.DataAccessLayer.Paginations;
using DogMateSocialMedia.DataAccessLayer.Parameters;

namespace DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;

public interface IUserRepository : IRepository<User>
{
    Task<PagedList<User>> GetAsync(UserParameters userParameters);
    Task AddUser(User user);
    Task DeleteUser(int id);
}