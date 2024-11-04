using DogMateSocialMedia.DataAccessLayer.Interface;
using DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;

namespace DogMateSocialMedia.DataAccessLayer.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext context;

    public IUserRepository UserRepository { get; }

    public UnitOfWork(AppDbContext context, IUserRepository userRepository)
    {
        this.context = context;
        UserRepository = userRepository;
    }

    public async Task SaveChangesAsync()
    {
        await context.SaveChangesAsync();
    }
}