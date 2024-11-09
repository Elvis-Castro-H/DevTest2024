using Microsoft.EntityFrameworkCore;
using PollAPI.Contexts;
using PollAPI.Models;

namespace PollAPI.Repositories;

public class PollRepositoryPostgres : BaseRepositoryPostgres<Poll, int>, IPollRepository
{
    public PollRepositoryPostgres(PostgresContext context) : base(context)
    {
    }

    public async Task<ICollection<Poll>> GetAll()
    {
        return await _context.Set<Poll>().Include(p => p.Options).Where(e => !e.IsDeleted).ToListAsync();
    }
}