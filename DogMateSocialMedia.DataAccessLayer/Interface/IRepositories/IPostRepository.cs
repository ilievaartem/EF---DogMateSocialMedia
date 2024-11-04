using DogMateSocialMedia.DataAccessLayer.Models;
using DogMateSocialMedia.DataAccessLayer.Paginations;
using DogMateSocialMedia.DataAccessLayer.Parameters;

namespace DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;

public interface IPostRepository : IRepository<Post>
{
    Task<PagedList<Post>> GetAsync(PostParameters postParameters);
    Task AddPost(Post post);
    Task DeletePost(int id);
}