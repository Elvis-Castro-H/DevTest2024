using Microsoft.EntityFrameworkCore;
using PollAPI.Contexts;
using PollAPI.Models;

namespace PollAPI.Repositories;

public class BaseRepositoryPostgres<T, TId> : IBaseRepository<T, TId> where T : BaseEntity<TId>
{
    protected readonly PostgresContext _context;

    public BaseRepositoryPostgres(PostgresContext context)
    {
        _context = context;
    }
    public async Task<ICollection<T>> GetAll()
    {
        var response = await _context.Set<T>().Where(e => !e.IsDeleted).ToListAsync();
        return response;
    }

    public async Task<T> Create(T entity)
    {
        entity.IsDeleted = false;
        _context.Set<T>().Add(entity);
        var response = await _context.SaveChangesAsync();
        return response > 0 ? entity : null;
    }

    public async Task<T> GetById(TId id)
    {
        var response = await _context.FindAsync<T>(id);
        return response != null && !response.IsDeleted ? response : null;
    }
}