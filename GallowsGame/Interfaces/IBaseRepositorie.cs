namespace GallowsGame.Interfaces;

public interface IBaseRepositorie<TEntity>
{
    Task<TEntity> GetById(Guid id);
    Task<IEnumerable<TEntity>> GetAll();
}