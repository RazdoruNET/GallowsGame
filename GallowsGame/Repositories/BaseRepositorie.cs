using GallowsGame.Interfaces;
using GallowsGame.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace GallowsGame.Repositories;

public class BaseRepositorie<TEntity> : IBaseRepositorie<TEntity> where TEntity : class
{
    private readonly AppDbContext _db;
    private readonly DbSet<TEntity> _dbSet;
    public BaseRepositorie(AppDbContext db)
    {
        _db = db;
        _dbSet = _db.Set<TEntity>();
    }
    
    public async Task<TEntity> GetById(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }
    
    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }
}