using PollAPI.Contexts;
using PollAPI.Models;

namespace PollAPI.Repositories;

public class VoteRepositoryPostgres : BaseRepositoryPostgres<Vote, int>, IVoteRepository
{
    public VoteRepositoryPostgres(PostgresContext context) : base(context)
    {
    }
}