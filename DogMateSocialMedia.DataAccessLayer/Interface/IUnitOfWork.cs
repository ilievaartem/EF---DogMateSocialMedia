using DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;
using System.Threading.Tasks;

namespace DogMateSocialMedia.DataAccessLayer.Interface;

public interface IUnitOfWork
{
    IUserRepository UserRepository { get; }

        
    Task SaveChangesAsync();
}