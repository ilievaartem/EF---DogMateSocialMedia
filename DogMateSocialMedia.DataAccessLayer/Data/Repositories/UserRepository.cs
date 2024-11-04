using DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;
using DogMateSocialMedia.DataAccessLayer.Models;
using DogMateSocialMedia.DataAccessLayer.Paginations;
using DogMateSocialMedia.DataAccessLayer.Parameters;

namespace DogMateSocialMedia.DataAccessLayer.Data.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context) { }

    public async Task AddUser(User user)
    {
        await table.AddAsync(user);
    }

    public Task DeleteUser(int id)
    {
        throw new NotImplementedException();
    }

    public override Task<User> GetCompleteEntityAsync(int id)
    {
        throw new NotImplementedException();
    }
    
    public async Task<PagedList<User>> GetAsync(UserParameters userParameters)
    {
        var query = table.AsQueryable();

        if (!string.IsNullOrEmpty(userParameters.Name))
            query = query.Where(u => u.Name.Contains(userParameters.Name));
        if (!string.IsNullOrEmpty(userParameters.Surname))
            query = query.Where(u => u.Surname.Contains(userParameters.Surname));

        return await PagedList<User>.ToPagedListAsync(query, userParameters.PageNumber, userParameters.PageSize);
    }

}