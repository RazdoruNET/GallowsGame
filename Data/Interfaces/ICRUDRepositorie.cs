namespace Data.Interfaces;

public interface ICRUDRepositorie<TEntity>
{
    Task<TEntity> GetById(long id);
    Task<IEnumerable<TEntity>> GetAll();
    Task<TEntity> Add(TEntity model);
}