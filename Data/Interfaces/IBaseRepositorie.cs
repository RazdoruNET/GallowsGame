namespace Data.Interfaces;

public interface IBaseRepositorie<TEntity>
{
    Task<TEntity> GetById(long id);
    Task<IEnumerable<TEntity>> GetAll();
}