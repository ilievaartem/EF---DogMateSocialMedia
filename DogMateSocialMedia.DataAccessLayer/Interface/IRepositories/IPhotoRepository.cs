using DogMateSocialMedia.DataAccessLayer.Models;
using DogMateSocialMedia.DataAccessLayer.Paginations;
using DogMateSocialMedia.DataAccessLayer.Parameters;

namespace DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;

public interface IPhotoRepository : IRepository<Photo>
{
    Task<PagedList<Photo>> GetAsync(PhotoParameters photoParameters);
    Task AddPhoto(Photo photo);
    Task DeletePhoto(int id);
}