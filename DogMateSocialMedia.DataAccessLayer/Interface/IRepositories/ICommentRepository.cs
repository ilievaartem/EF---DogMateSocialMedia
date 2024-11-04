using DogMateSocialMedia.DataAccessLayer.Models;
using DogMateSocialMedia.DataAccessLayer.Paginations;
using DogMateSocialMedia.DataAccessLayer.Parameters;

namespace DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;

public interface ICommentRepository : IRepository<Comment>
{
    Task<PagedList<Comment>> GetAsync(CommentParameters commentParameters);
    Task AddComment(Comment comment);
    Task DeleteComment(int id);
}