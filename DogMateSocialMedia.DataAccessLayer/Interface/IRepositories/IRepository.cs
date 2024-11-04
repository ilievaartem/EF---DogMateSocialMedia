﻿namespace DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;

public interface IRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAsync();
    Task<TEntity> GetByIdAsync(int id);
    Task<TEntity> GetCompleteEntityAsync(int id);
    Task InsertAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(int id);
}