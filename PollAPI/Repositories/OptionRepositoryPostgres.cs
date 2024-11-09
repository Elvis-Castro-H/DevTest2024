using PollAPI.Contexts;
using PollAPI.Models;

namespace PollAPI.Repositories;

public class OptionRepositoryPostgres : BaseRepositoryPostgres<Option, int>
{
    public OptionRepositoryPostgres(PostgresContext context) : base(context)
    {
    }
}