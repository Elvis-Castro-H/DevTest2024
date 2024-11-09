using PollAPI.Models;

namespace PollAPI.Repositories;

public interface IBaseRepository<T, TId> where T : BaseEntity<TId>
{
    Task<ICollection<T>> GetAll();
    Task<T> Create(T entity);
}