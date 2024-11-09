using AutoMapper;
using PollAPI.DTOs;
using PollAPI.Models;
using PollAPI.Repositories;

namespace PollAPI.Services;

public class VoteService : BaseService<Vote, VoteOutputDto, VoteInputDto, int>, IVoteService
{
    private readonly IVoteRepository _repository;
    public VoteService(IVoteRepository repository, IMapper mapper) : base(repository, mapper)
    {
        _repository = repository;
    }
}