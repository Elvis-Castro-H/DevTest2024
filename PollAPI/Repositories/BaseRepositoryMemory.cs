using PollAPI.Models;

namespace PollAPI.Repositories;

public abstract class BaseRepositoryMemory<T, TId> : IBaseRepository<T, TId> where T : BaseEntity<TId>
{
    protected static readonly ICollection<T> _entities = new List<T>();
    public abstract Task<T> Create(T entity);
    public Task<T> GetById(TId id)
    {
        var response = _entities.FirstOrDefault(e => e.Id.Equals(id));
        return Task.FromResult<T>(response);
    }

    public Task<ICollection<T>> GetAll()
    {
        return Task.FromResult(_entities);
    }
}