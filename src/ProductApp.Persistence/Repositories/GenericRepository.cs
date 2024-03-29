using Microsoft.EntityFrameworkCore;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Common;
using ProductApp.Persistence.Context;

namespace ProductApp.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepositoryAsync<T> where T : BaseEntity
{
    private readonly ApplicationDbContext dbContext;

    public GenericRepository(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return  await dbContext.Set<T>().ToListAsync();
        
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await dbContext.Set<T>().FindAsync(id);
    }

    public async Task<T> AddAsync(T entity)
    {
        await dbContext.Set<T>().AddAsync(entity);
        await dbContext.SaveChangesAsync();
        return entity;
    }
}