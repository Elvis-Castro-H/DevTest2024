using PollAPI.DTOs;

namespace PollAPI.Services;

public interface IVoteService : IBaseService<VoteOutputDto, VoteInputDto, int>
{
    
}