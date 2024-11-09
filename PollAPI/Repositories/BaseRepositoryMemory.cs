using PollAPI.Models;

namespace PollAPI.Repositories;

public abstract class BaseRepositoryMemory<T, TId> : IBaseRepository<T, TId> where T : BaseEntity<TId>
{
    protected static readonly ICollection<T> _entities = new List<T>();
    public abstract Task<T> Create(T entity);
    
    public Task<ICollection<T>> GetAll()
    {
        return Task.FromResult(_entities);
    }
}