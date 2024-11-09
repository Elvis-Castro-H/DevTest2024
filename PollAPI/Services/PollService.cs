using AutoMapper;
using PollAPI.DTOs;
using PollAPI.Models;
using PollAPI.Repositories;

namespace PollAPI.Services;

public class PollService : BaseService<Poll, PollOutputDto, PollInputDto, int>, IPollService
{
    private readonly IPollRepository _repository;
    public PollService(IPollRepository repository, IMapper mapper) : base(repository, mapper)
    {
        _repository = repository;
    }
}