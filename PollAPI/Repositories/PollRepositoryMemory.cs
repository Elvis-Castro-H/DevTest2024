using PollAPI.Models;

namespace PollAPI.Repositories;

public class PollRepositoryMemory : BaseRepositoryMemory<Poll, int>, IPollRepository
{
    private static int currentId = 0;
    
    public override Task<Poll> Create(Poll entity)
    {
        entity.Id = currentId++;
        _entities.Add(entity);
        return Task.FromResult(entity);
    }
}