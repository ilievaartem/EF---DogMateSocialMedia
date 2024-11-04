using DogMateSocialMedia.DataAccessLayer.Models;
using DogMateSocialMedia.DataAccessLayer.Paginations;
using DogMateSocialMedia.DataAccessLayer.Parameters;

namespace DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;

public interface IDogRepository : IRepository<Dog>
{
    Task<PagedList<Dog>> GetAsync(DogParameters dogParameters);
    Task AddDog(Dog dog);
    Task DeleteDog(int id);
}