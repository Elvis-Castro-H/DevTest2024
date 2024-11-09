using PollAPI.Models;

namespace PollAPI.Repositories;

public class VoteRepositoryMemory : BaseRepositoryMemory<Vote, int>, IVoteRepository
{
    private static int currentId = 0;
    public override Task<Vote> Create(Vote entity)
    {
        entity.Id = currentId++;
        _entities.Add(entity);
        return Task.FromResult(entity);
    }
}