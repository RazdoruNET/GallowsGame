using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class BaseRepositorie<TEntity> : IBaseRepositorie<TEntity> where TEntity : class
{
    private readonly AppDbContext _db;
    private readonly DbSet<TEntity> _dbSet;
    public BaseRepositorie(AppDbContext db)
    {
        _db = db;
        _dbSet = _db.Set<TEntity>();
    }
    
    public async Task<TEntity> GetById(long id)
    {
        return await _dbSet.FindAsync(id);
    }
    
    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    public async Task<TEntity> Add(TEntity model)
    { 
        await _dbSet.AddAsync(model);
        await _db.SaveChangesAsync();

        return model;
    }
}