using DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DogMateSocialMedia.DataAccessLayer.Data.Repositories;

public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext context;
    protected readonly DbSet<TEntity> table;

    public GenericRepository(AppDbContext context)
    {
        this.context = context;
        table = this.context.Set<TEntity>();
    }

    public virtual async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        table.Remove(entity);
    }

    public virtual async Task<IEnumerable<TEntity>> GetAsync() => await table.ToListAsync();

    public virtual async Task<TEntity> GetByIdAsync(int id) => await table.FindAsync(id);

    public abstract Task<TEntity> GetCompleteEntityAsync(int id);

    public virtual async Task InsertAsync(TEntity entity) => await table.AddAsync(entity);

    public virtual async Task UpdateAsync(TEntity entity) => table.Update(entity);
}